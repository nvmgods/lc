using System;
using System.Windows.Forms;

namespace RavenDevLauncher.Interface
{

    public partial class FrmMsgBox : Form
    {
        static FrmMsgBox newErrorMessage;
        static readonly string btn;
        public FrmMsgBox()
        {
            InitializeComponent();
            this.TopLevel = true;
            this.TopMost = true;

        }


        public static string ShowBox(string txtTitle, string txtMessage)
        {

            newErrorMessage = new FrmMsgBox();
            newErrorMessage.HeadLine.Text = txtTitle;
            newErrorMessage.MessageForm.Text = txtMessage;
            newErrorMessage.ShowDialog();
            return btn;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            Dispose();
        }

    }
}
