using System;
using System.IO;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace ScanOPID
{
    class ModBarCodeFile
    {
        private string computerName;
        private DateTime date;
        private FrmMainForm mf;
        public ModBarCodeFile(FrmMainForm mf)
        {
            //传递主窗体指针
            this.mf = mf;
            //获取计算机名
            computerName = System.Net.Dns.GetHostName().ToString();
            //if (computerName.Length == 0)
            //{
            //    MessageBox.Show("无效计算机名，请检查！");
            //    Application.Exit();
            //}留待后续使用
            if (!IsShareFolderExist())
            {
                MessageBox.Show("共享文件夹不存在，请检查！");
#if !DEBUG
                Environment.Exit(0);
#endif
            }
        }
        //判断指定共享文件夹是否存在
        public bool IsShareFolderExist()
        {
            //查找系统中所有共享文件夹
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Share");
            //共享文件夹在操作系统中的uint值为0x0，当判断type值为0且路径为指定路径时，该共享文件夹存在
            foreach(ManagementObject obj in searcher.Get())
            {
                uint type = uint.Parse(obj["type"].ToString());
                string path = obj["path"].ToString();
                if(type == 0 && Directory.Equals(path, "C:\\BarCode"))
                {
                    return true;
                }
            }
            return false;
        }
        //往BarCode中存放数据
        public void WriteBarCodeFile(string opid, string judgement)
        {
            date = DateTime.Now.ToLocalTime();
            string content = opid + ",NULL,NULL,NULL,NULL,NULL," + judgement + "," + date.ToString("yyyy/MM/dd HH:mm:ss") + "\r\n";
            byte[] myByte = Encoding.UTF8.GetBytes(content);
            FileStream fs = null;
            try
            {
                fs = new FileStream("C:\\BarCode\\" + computerName + ".dat", FileMode.Append);
                fs.Write(myByte, 0, myByte.Length);
                fs.Flush();
            }
            catch (IOException e)
            {
                MessageBox.Show("上传数据失败！" + e.Message);
                mf.status.Text = "Update Data NG";
                throw (ModFileWriteException)(new Exception(e.Message));
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
