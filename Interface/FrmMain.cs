using RavenDevLauncher.Logic;
using RavenDevLauncher.Network;
using RavenDevLauncher.Network.Packets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;



namespace RavenDevLauncher.Interface
{
    public partial class FrmMain : Form
    {

        //private Boolean status = false;
        private readonly string PatchHost = "http://127.0.01/patch";
        private readonly string Serverip = "127.0.0.1";
        private readonly int ServerPort = 10001;



        private INIFile ini = new INIFile(".\\DataTable\\GameSetting.ini");
        public string Patch = "Patch.ini";
        public string currentDirectory = Directory.GetCurrentDirectory();
        public string mainFile = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "RFOnline.bin";
        public string updatesDirectory = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "System\\updates";
        public WebClient webClient;
        public Stopwatch sw = new Stopwatch();
        public bool isBulkDownload = false;
        public string lastDownloadedFilePath;
        public string lastDownloadedRemoteUrl;
        public Queue<string> fileProcessQueue;
        public int totalFilesToBeProcessed = 0;
        public int totalFilesProcessed = 0;
        private Stream strResponse;
        private Stream fileStream;
        private HttpWebRequest webRequest;
        private HttpWebResponse webResponse;
        private WorldStatus worldstats;
        private NetworkClient networkClient;



        // private WorldLogin rf = new WorldLogin();
        //private RFBinLauncher rf = new RFBinLauncher();

        public FrmMain()
        {

            InitializeComponent();
            InitializeNetwork();
            IsAlreadyRunning();
            



        }







        #region Check For Instance       

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string Cmd, StringBuilder StrReturn, int ReturnLength, IntPtr HwndCallback);

        private const int SW_HIDE = 0;
        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;
        private const int SW_SHOWNOACTIVATE = 4;
        private const int SW_RESTORE = 9;
        private const int SW_SHOWDEFAULT = 10;

        private static bool IsAlreadyRunning()
        {
            // get all processes by Current Process name
            Process[] processes =
                Process.GetProcessesByName(
                    Process.GetCurrentProcess().ProcessName);

            // if there is more than one process...
            if (processes.Length > 1)
            {
                // if other process id is OUR process ID...
                // then the other process is at index 1
                // otherwise other process is at index 0
                int n = (processes[0].Id == Process.GetCurrentProcess().Id) ? 1 : 0;

                // get the window handle
                IntPtr hWnd = processes[n].MainWindowHandle;

                // if iconic, we need to restore the window
                if (IsIconic(hWnd)) ShowWindowAsync(hWnd, SW_RESTORE);

                // Bring it to the foreground
                SetForegroundWindow(hWnd);
                return true;
            }
            return false;
        }
        #endregion Check For Instance
        

        private void Updater_Load(object sender, EventArgs e)
        {
            if (IsAlreadyRunning())
            {
                FrmMsgBox.ShowBox("ERROR!", "Launcher is already running");
                Environment.Exit(0);
            }
            bannerBox.Show();
            worldstatus();
            newsform();
            newsbox2();
            rememberthename();
            deLlog();
            backgroundMusic();
            EnableLoginBtn(true);


        }

        public void PingHost(string nameOrAddress)
        {
            Ping ping = null;
            try
            {
                ping = new Ping();
                PingReply pingReply = ping.Send(nameOrAddress);
                _ = pingReply.Status;
                string text = pingReply.RoundtripTime.ToString();
                PingLabel.Text = "Ping " + text + " ms";
            }
            catch (PingException)
            {
            }
            finally
            {
                ping?.Dispose();
            }
        }



        public void backgroundMusic()
        {
            INIFile ini = new INIFile(".\\R3Engine.ini");
            string text = ini.ReadValue("Sound", "LauncherMusic");
            if (text != "FALSE")
            {


                Random rand = new Random();
                string Bgm = null;

                int number = rand.Next(1, 5);
                if (number == 1)
                {
                    Bgm = currentDirectory + @"\Snd\BGM\1_RF_Online_ONE.mp3";
                }
                else if (number == 2)
                {
                    Bgm = currentDirectory + @"\Snd\BGM\2_RF_Online_Love_Theme.mp3";
                }
                else if (number == 3)
                {
                    Bgm = currentDirectory + @"\Snd\BGM\3_RF_Online_What_shall_i_do.mp3";
                }
                else if (number == 4)
                {
                    Bgm = currentDirectory + @"\Snd\BGM\4_RFonline_Intro.mp3";
                }
                else
                {
                    Bgm = currentDirectory + @"\Snd\Bgm\1_RF_Online_ONE.mp3";
                }
                try
                {
                    string FileName = Bgm;
                    mciSendString("open \"" + FileName + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
                    mciSendString("play " + FileName + " from 0", null, 0, IntPtr.Zero);
                }
                catch
                {
                    //FrmMsgBox.ShowBox("Warning", "Invalid background music file: ");
                }
            }
        }



        private void deLlog()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(".\\NetLog");
            try
            {
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
            catch
            { }
        }

        private void worldstatus()
        {
            try
            {
                new Thread((ThreadStart)delegate
                {
                    worldstats = new WorldStatus(Serverip, 2406, "Online");
                    Invoke((MethodInvoker)delegate
                    {
                        CoraOnline.Text = worldstats.online[0] ?? "";
                    });
                    Invoke((MethodInvoker)delegate
                    {
                        BellatoOnline.Text = worldstats.online[1] ?? "";
                    });
                    Invoke((MethodInvoker)delegate
                    {
                        AccretiaOnline.Text = worldstats.online[2] ?? "";
                    });
                }).Start();
            }
            catch
            {
                //LogHelper.Logging("GetOnline:" + ex.Message);
            }
        }

        private void newsform()
        {
            WebClient webclient = new WebClient();
            try
            {
                noticeBoxLabel.Text = webclient.DownloadString(PatchHost + "/notice.txt");
            }
            catch
            {

            }
        }

        private void newsbox2()
        {
            WebClient webclient = new WebClient();
            try
            {

                InfoBoxLabel.Text = webclient.DownloadString(PatchHost + "/serverinfo.txt");
            }
            catch
            {

            }
        }

        private void serverinfobtn_Click(object sender, EventArgs e)
        {
            WebClient webclient = new WebClient();
            try
            {
                InfoBoxLabel.Text = webclient.DownloadString(PatchHost + "/serverinfo.txt");
            }
            catch
            {

            }
        }

        private void boxinfobtn_Click(object sender, EventArgs e)
        {
            WebClient webclient = new WebClient();
            try
            {
                InfoBoxLabel.Text = webclient.DownloadString(PatchHost + "/boxinfo.txt");
            }
            catch
            {

            }
        }

        private void questinfobtn_Click(object sender, EventArgs e)
        {
            WebClient webclient = new WebClient();
            try
            {
                InfoBoxLabel.Text = webclient.DownloadString(PatchHost + "/questinfo.txt");
            }
            catch
            {

            }
        }

        private void combineinfobtn_Click(object sender, EventArgs e)
        {
            WebClient webclient = new WebClient();
            try
            {
                InfoBoxLabel.Text = webclient.DownloadString(PatchHost + "/combineinfo.txt");
            }
            catch
            {

            }
        }

        private void rememberthename()
        {
            if (ini.ReadValue("General", "RememberMe") == "true")
                try
                {
                    startGameBtn.Select();
                    checkBox1.Checked = true;
                    //txtboxPassword.Text = ini.ReadValue("Account", "Password");
                    txtboxUsername.Text = HasherAlgo.Decrypt(ini.ReadValue("Account", "Username"));
                    txtboxPassword.Text = HasherAlgo.Decrypt(ini.ReadValue("Account", "Password"));
                }
                catch
                { }
        }

        #region Updater

        private void Updater_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (Directory.Exists(updatesDirectory))
                try
                {
                    Directory.Delete(updatesDirectory, true);
                }
                catch
                { }
            networkClient.StopListen();
            Environment.Exit(0);
        }

       
        

        private void ClearDirectory(string path)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(path);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
            catch (Exception ex)
            {
                _ = FrmMsgBox.ShowBox("RF Online Updater", ex.Message);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            
            if (Directory.Exists(updatesDirectory))
            {
                try
                {
                    Directory.Delete(updatesDirectory, true);
                }
                catch { }
            }
            Environment.Exit(0);
        }


        






      
     

        #endregion Updater

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private int mouseStartX, mouseStartY;
        private int formStartX, formStartY;
        private bool FormDragging = false;

        private void Updater_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseStartX = MousePosition.X;
            this.mouseStartY = MousePosition.Y;
            this.formStartX = this.Location.X;
            this.formStartY = this.Location.Y;
            FormDragging = true;
        }

        private void Updater_MouseMove(object sender, MouseEventArgs e)
        {
            if (FormDragging)
            {
                this.Location = new Point(
                this.formStartX + MousePosition.X - this.mouseStartX,
                this.formStartY + MousePosition.Y - this.mouseStartY
                );
            }
        }

        private void Updater_MouseUp(object sender, MouseEventArgs e)
        {
            FormDragging = false;
        }



       





        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings settings = new FrmSettings();
            settings.Show();
        }

        private void txtboxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://domination.gamecp.net/register.php");
        }
        private void websitebtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.rf-domination.com");
        }
        private void facebookbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/RFDomination");
        }
        private void discordbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.com/invite/h3tk7CXkR7");
        }



        void startGameBtn_MouseLeave(object sender, EventArgs e)
        {
            this.startGameBtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_login1));
        }

        void startGameBtn_MouseEnter(object sender, EventArgs e)
        {
            this.startGameBtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_login2));
        }

        void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_setup));
        }

        void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_setup_over));
        }

        void facebookbtn_MouseLeave(object sender, EventArgs e)
        {
            this.facebookbtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_facebook1));
        }

        void facebookbtn_MouseEnter(object sender, EventArgs e)
        {
            this.facebookbtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_facebook2));
        }

        void StopButton_MouseLeave(object sender, EventArgs e)
        {
            this.StopButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_cancel1));
        }

        void StopButton_MouseEnter(object sender, EventArgs e)
        {
            this.StopButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_cancel2));
        }

        void registerbtn_MouseLeave(object sender, EventArgs e)
        {
            this.registerbtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_join1));
        }

        void registerbtn_MouseEnter(object sender, EventArgs e)
        {
            this.registerbtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_join2));
        }

        void websitebtn_MouseLeave(object sender, EventArgs e)
        {
            this.websitebtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_gameguide));
        }

        void websitebtn_MouseEnter(object sender, EventArgs e)
        {
            this.websitebtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_gameguide_over));
        }

        void FullCheckButton_MouseLeave(object sender, EventArgs e)
        {
            this.FullCheckButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_fix_client1));
        }

        void FullCheckButton_MouseEnter(object sender, EventArgs e)
        {
            this.FullCheckButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_fix_client2));
        }

        void discordbtn_MouseLeave(object sender, EventArgs e)
        {
            this.discordbtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_discord1));
        }

        void discordbtn_MouseEnter(object sender, EventArgs e)
        {
            this.discordbtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_discord2));
        }

        void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_close1));
        }

        void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_close2));
        }

        void serverinfobtn_MouseLeave(object sender, EventArgs e)
        {
            this.serverinfobtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_info1));
        }

        void serverinfobtn_MouseEnter(object sender, EventArgs e)
        {
            this.serverinfobtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_info2));
        }

        void boxinfobtn_MouseLeave(object sender, EventArgs e)
        {
            this.boxinfobtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_boxinfo1));
        }

        void boxinfobtn_MouseEnter(object sender, EventArgs e)
        {
            this.boxinfobtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_boxinfo2));
        }

        void questinfobtn_MouseLeave(object sender, EventArgs e)
        {
            this.questinfobtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_questinfo1));
        }

        void questinfobtn_MouseEnter(object sender, EventArgs e)
        {
            this.questinfobtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_questinfo2));
        }

        void combineinfobtn_MouseLeave(object sender, EventArgs e)
        {
            this.combineinfobtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_combineinfo1));
        }

        void combineinfobtn_MouseEnter(object sender, EventArgs e)
        {
            this.combineinfobtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btn_combineinfo2));
        }

        void minimizeBox_MouseLeave(object sender, EventArgs e)
        {
            this.minimizeBox.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.minimize));
        }

        void minimizeBox_MouseEnter(object sender, EventArgs e)
        {
            this.minimizeBox.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.minimize2));
        }





        private void InitializeNetwork()
        {
            networkClient = new NetworkClient(Serverip, ServerPort);
            //networkClient = new NetworkClient("127.0.0.1", 10001);
            networkClient.OnError += NetworkClient_OnError;
            networkClient.OnConnected += NetworkClient_OnConnected;
            networkClient.ClientEvents += NetworkClient_ClientEvents;
            (new Thread(() =>
            {
                networkClient.StartClient();
            })).Start();
        }

        private void NetworkClient_OnError(object sender, EventArgs e)
        {
            ChangeStatus(false);
        }

        private void NetworkClient_OnConnected(object sender, EventArgs e)
        {
            ChangeStatus(true);
        }

        private void NetworkClient_ClientEvents(object sender, NetworkClientEventArgs e)
        {
            switch (e.CState)
            {
                case NetworkClientEventArgs.Callback.CRYPTO_KEY_INFORM:
                    EnableLoginBtn(true);
                    break;
                case NetworkClientEventArgs.Callback.LOGIN_ACCOUNT_WRONG_LOGIN:
                    EnableLoginBtn(true);
                    FrmMsgBox.ShowBox("ERROR !", MessageList.ERR_WRONG_ACCOUNT);
                    break;
                case NetworkClientEventArgs.Callback.LOGIN_ACCOUNT_WRONG_PW:
                    EnableLoginBtn(true);
                    FrmMsgBox.ShowBox("ERROR !", MessageList.ERR_WRONG_PASSWORD);
                    break;
                case NetworkClientEventArgs.Callback.LOGIN_ACCOUNT_SERVER_CLOSED:
                    EnableLoginBtn(true);
                    FrmMsgBox.ShowBox("Warning !", MessageList.ERR_NO_SERVICETIME);
                    break;
                case NetworkClientEventArgs.Callback.LOGIN_ACCOUNT_BANNED:
                    FrmMsgBox.ShowBox("ERROR !", MessageList.ERR_BLOCK_ACCOUNT);
                    break;
                case NetworkClientEventArgs.Callback.SERVER_LIST_INFORM:
                    FillServerList(e.Servers);
                    break;
                case NetworkClientEventArgs.Callback.SERVER_SESSION_RESULT:
                    RunGame(e.DefaultSet);
                    break;
            }
        }
        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            

            if (checkBox1.Checked)
            {
                // StartGameBtn.Select();
                ini.WriteValue("General", "RememberMe", "true");
                ini.WriteValue("Account", "Username", HasherAlgo.Encrypt(txtboxUsername.Text));
                ini.WriteValue("Account", "Password", HasherAlgo.Encrypt(txtboxPassword.Text));
            }
            else
            {
                ini.WriteValue("General", "RememberMe", "false");
                ini.WriteValue("Account", "Username", "");
                ini.WriteValue("Account", "Password", "");
            }

            if (txtboxUsername.Text == "" || txtboxUsername.TextLength < 3)
            {


                FrmMsgBox.ShowBox("ERROR !", MessageList.ERR_WRONG_ACCOUNT);
                return;
            }
            if (txtboxPassword.Text == "" || txtboxPassword.TextLength < 3)
            {

                FrmMsgBox.ShowBox("ERROR !", MessageList.ERR_WRONG_PASSWORD);

                return;
            }


            if (!string.IsNullOrEmpty(txtboxUsername.Text) && !string.IsNullOrEmpty(txtboxPassword.Text) ||
               txtboxUsername.Text.Length <= 13 && txtboxPassword.Text.Length <= 13)
            {
                try
                {
                    networkClient.DoLogin(txtboxUsername.Text, txtboxPassword.Text);
                }
                catch
                {

                }
                EnableLoginBtn(false);
            }
            else
            {
                FrmMsgBox.ShowBox("ERROR !", MessageList.ERR_WRONG_ACCOUNT);
            }
        }

        private void ChangeStatus(bool ok)
        {
            Invoke(new Action(() =>
            {
                status_label.Text = ok ? ("Ready") : ("Disconected");
            }));
        }
        private void EnableLoginBtn(bool state)
        {
            Invoke(new Action(() =>
            {
                startGameBtn.Enabled = state;
            }));
        }
        private void FillServerList(List<ServerState> _serverList)
        {




            Invoke(new Action(() =>
            {



                {
                    panel1.Enabled = true;
                    panel1.Visible = true;
                    panel1.BringToFront();
                    server_list.Enabled = true;
                    server_list.Visible = true;
                    server_list.BringToFront();
                    foreach (var server in _serverList)
                    {
                        string serverStatus = server.b_ServerState == 1 ? ("ONLINE") : ("OFFLINE");
                        server_list.Items.Add(new ListViewItem(new[] { server.s_ServerName, serverStatus }));
                        //server_list.Items.Add(server.s_ServerName + serverStatus);                      

                    }
                }
                foreach (ListViewItem li in server_list.Items)
                {
                    if (li.SubItems[1].Text == "ONLINE")
                    {
                        li.SubItems.Add("Color");
                        li.SubItems[1].ForeColor = Color.Green;
                        li.UseItemStyleForSubItems = false;
                    }
                    else
                    {
                        li.SubItems.Add("Color");
                        li.SubItems[1].ForeColor = Color.Red;
                        li.UseItemStyleForSubItems = false;

                    }

                }
                SetHeight(server_list, 25);



            }));

        }
        private void SetHeight(ListView listView, int height)
        {
            ImageList imgLst = new ImageList();
            imgLst.ImageSize = new Size(1, height);
            listView.SmallImageList = imgLst;
        }
        private void server_list_DrawItem(object sender, DrawListViewItemEventArgs e)
        {



            if ((e.State & ListViewItemStates.Focused) != 0)
            {

                // Draw the background and focus rectangle for a selected item.
                e.Graphics.FillRectangle(Brushes.DarkGray, e.Bounds);
                //e.DrawFocusRectangle();
            }
            else
            {
                // Draw the background for an unselected item.
                /* using (LinearGradientBrush brush =
                     new LinearGradientBrush(e.Bounds, Color.Orange,
                     Color.Maroon, LinearGradientMode.Horizontal))
                 {
                     e.Graphics.FillRectangle(brush, e.Bounds);
                 }*/
            }

            // Draw the item text for views other than the Details view.
            if (server_list.View != View.Details)
            {
                e.DrawText();
            }

        }

        private void server_list_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {

            TextFormatFlags flags = TextFormatFlags.VerticalCenter;

            using (StringFormat sf = new StringFormat())
            {
                // Store the column text alignment, letting it default
                // to Left if it has not been set to Center or Right.
                /*switch (e.Header.TextAlign)
                {
                    case HorizontalAlignment.Center:
                        sf.Alignment = StringAlignment.Center;
                        flags = TextFormatFlags.Left;
                        break;
                    case HorizontalAlignment.Right:
                        sf.Alignment = StringAlignment.Center;
                        flags = TextFormatFlags.Right;
                        break;
                }*/

                // Draw the text and background for a subitem with a 
                // negative value. 
                double subItemValue;
                if (e.ColumnIndex > 0 && Double.TryParse(
                    e.SubItem.Text, out subItemValue) &&
                    subItemValue < 0)
                {
                    // Unless the item is selected, draw the standard 
                    // background to make it stand out from the gradient.
                    if ((e.ItemState & ListViewItemStates.Selected) == 0)
                    {
                        e.DrawBackground();
                    }

                    // Draw the subitem text in red to highlight it. 
                    e.Graphics.DrawString(e.SubItem.Text,
                        server_list.Font, Brushes.Red, e.Bounds, sf);

                    return;
                }

                // Draw normal text for a subitem with a nonnegative 
                // or nonnumerical value.
                e.DrawText(flags);
            }

        }
        private void server_list_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y > 2 + (server_list.Items.Count * 25))
                server_list.Cursor = Cursors.Default;
            else
                server_list.Cursor = Cursors.Hand;
        }

        private void server_list_DoubleClick(object sender, MouseEventArgs e)
        {
            if (server_list.SelectedItems.Count > 0)
            {
                var item = server_list.SelectedItems[0];

                networkClient.SelectWordlRequest((short)item.Index);
                server_list.Enabled = true;
            }
        }



        private void RunGame(Default_Set defaultSet)
        {

            ClientRunHelper.WriteTmp(".\\System\\DefaultSet.tmp", defaultSet);
            ClientRunHelper.RunClient(Application.StartupPath + "\\" + "RF_Online.bin");
            networkClient.StopListen();
            Environment.Exit(0);
        }



        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            networkClient.StopListen();
            Environment.Exit(0);
        }
        public static void ForAllControls(Control parent, Action<Control> action)
        {
            foreach (Control c in parent.Controls)
            {
                action(c);
                ForAllControls(c, action);
            }
        }
    }

}