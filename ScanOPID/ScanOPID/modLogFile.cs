using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ScanOPID
{
    class ModLogFile
    {
        private DateTime dateTime;
        private FrmMainForm mf;
        public ModLogFile(FrmMainForm mf)
        {
            //传递主窗体指针
            this.mf = mf;
        }
        /// <summary>
        /// Norm 正常
        /// Warn 警告
        /// Erro 错误
        /// </summary>
        public enum LogType
        {
            Norm, Warn, Erro
        }
        //如果没有当前日期文件或文件夹则创建
        public void CreateFile()
        {
            dateTime = DateTime.Now.ToLocalTime();
            string LogPath = AppDomain.CurrentDomain.BaseDirectory + "\\Log\\" + dateTime.Year.ToString() + "\\" + dateTime.Month.ToString() + "月\\";
            string FileName = LogPath + dateTime.ToString("yyyy-MM-dd") + ".txt";
            if (!Directory.Exists(LogPath))
            {
                Directory.CreateDirectory(LogPath);
            }
            if (!File.Exists(FileName))
            {
                string s = "Type\tOPID\t\t\tTime";
                byte[] myByte = Encoding.UTF8.GetBytes(s);
                FileStream fs = null;
                try
                {
                    fs = new FileStream(FileName, FileMode.Append);
                    fs.Write(myByte, 0, myByte.Length);
                    fs.Flush();
                }
                catch (IOException e)
                {
                    mf.status.Text = "Create Dir NG";
                    MessageBox.Show("创建日志文件失败！" + e.Message);
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
        //写入日志内容
        public void WriteLogFile(LogType lt, string opid)
        {
            dateTime = DateTime.Now.ToLocalTime();
            string LogPath = AppDomain.CurrentDomain.BaseDirectory + "\\Log\\" + dateTime.Year.ToString() + "\\" + dateTime.Month.ToString() + "月\\";
            string FileName = LogPath + dateTime.ToString("yyyy-MM-dd") + ".txt";
            string content = "\r\n" + "[" + lt + "]\t" + opid + "\t" + dateTime.ToString();
            byte[] myByte = Encoding.UTF8.GetBytes(content);
            FileStream fs = null;
            try
            {
                fs = new FileStream(FileName, FileMode.Append);
                fs.Write(myByte, 0, myByte.Length);
                fs.Flush();
            }
            catch (IOException e)
            {
                mf.status.Text = "Create Log NG";
                mf.status.Location = new System.Drawing.Point(19, 13);
                MessageBox.Show("日志写入失败！" + e.Message);
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
