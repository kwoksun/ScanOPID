using System;
using System.Threading;
using System.Windows.Forms;

namespace ScanOPID
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Mutex mutex = new Mutex(true, Application.ProductName, out bool ret);
            //只能有一个程序实例在运行
            if (ret)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmMainForm());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("程序只能运行一次，请勿多开！", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }
    }
}
