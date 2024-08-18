using RavenDevLauncher.Interface;
using System.Net.Sockets;
using System.Text;


namespace RavenDevLauncher.Logic
{
    public class WorldStatus
    {
        public string[] online;

        public string Input;

        public string Output;

        public WorldStatus(string ip, int port, string message)
        {

            online = new string[3] { "⟳", "⟳", "⟳" };

            try
            {
                Input = message;
                NetworkStream stream = new TcpClient(ip, port).GetStream();
                byte[] bytes = Encoding.Unicode.GetBytes(message);
                stream.Write(bytes, 0, bytes.Length);
                bytes = new byte[64];
                StringBuilder stringBuilder = new StringBuilder();
                //int num = 0;
                do
                {
                    int count = stream.Read(bytes, 0, bytes.Length);
                    stringBuilder.Append(Encoding.Unicode.GetString(bytes, 0, count));
                }
                while (stream.DataAvailable);
                message = stringBuilder.ToString();
                if (Input == "Online")
                {
                    string[] array = message.Split(';');
                    for (int i = 0; i < 3; i++)
                    {
                        online[i] = array[i];
                    }
                }
                else
                { }

            }

            catch
            {

                if (Input != "Online")
                {
                    FrmMsgBox.ShowBox("ERROR !", MessageList.ERR_INIT_OBJECT);
                }
            }
        }
    }
}
