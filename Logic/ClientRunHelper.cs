using RavenDevLauncher.Interface;
using RavenDevLauncher.Network.BinaryConverter;
using RavenDevLauncher.Network.Packets;
using System.Diagnostics;
using System.IO;


namespace RavenDevLauncher.Logic
{

    class ClientRunHelper
    {

        public static void WriteTmp(string path, Default_Set data)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            data.encrypt();
            byte[] bDefaultSet = BinaryStructConverter.ToByteArray(data);
            File.WriteAllBytes(path, bDefaultSet);
        }
        public static void RunClient(string filepath)
        {
            if (!File.Exists(filepath))
            {
                FrmMsgBox.ShowBox("ERROR !", MessageList.ERR_NOTEXIST_EXEFILE);

                return;
            }

            Process clientProcess = new Process();
            clientProcess.StartInfo.CreateNoWindow = false;
            clientProcess.StartInfo.FileName = filepath;
            clientProcess.StartInfo.WorkingDirectory = ".\\";
            clientProcess.StartInfo.UseShellExecute = false;
            clientProcess.Start();
        }
    }
}
