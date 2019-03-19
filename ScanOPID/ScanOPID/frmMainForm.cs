using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScanOPID
{
    public partial class FrmMainForm : Form
    {
        private ModBarCodeFile barcode;
        private ModLogFile log;
        public FrmMainForm()
        {
            InitializeComponent();
            barcode = new ModBarCodeFile(this);
            log = new ModLogFile(this);
        }
        //显示串口设置界面
        private void SetupPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSetupPort sp = new FrmSetupPort();
            sp.ShowDialog(this);
        }
        /// <summary>
        /// InvokeRequired表示当前线程是否主线程之外的线程，是就调用委托
        /// </summary>
        /// <param name="s">接收的数据</param>
        private void DataUpdate(string s)
        {
            if (InvokeRequired)
            {
                Invoke((EventHandler)(delegate
                {
                    DataUpdate(s);
                }));
            }
            else
            {
                OPIDlabel.Text = s;
            }
        }
        private void ChangeStatus(string s)
        {
            if (InvokeRequired)
            {
                Invoke((EventHandler)(delegate
                {
                    ChangeStatus(s);
                }));
            }
            else
            {
                status.Text = s;
                status.Location = new Point(54, 13);
            }
        }
        //串口接收缓冲区有数据时执行
        private void RcvData(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //读取数据
            string data = Scanner.ReadLine();
            try
            {
                //主界面OPID更新
                //string opid = data.Substring(0, MachineType.OPIDLength);
                string opid = data.Substring(0, 15);
                DataUpdate(opid);
                //主界面Judgement更新
                JudgementBox.Image = Judgement.Images[1];
                //上传数据
                barcode.WriteBarCodeFile(opid, "1");
                //写Log
                log.CreateFile();
                log.WriteLogFile(ModLogFile.LogType.Norm, opid);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                DataUpdate(data);
                JudgementBox.Image = Judgement.Images[2];
                ChangeStatus("Scan NG");
                log.CreateFile();
                log.WriteLogFile(ModLogFile.LogType.Erro, data);
                MessageBox.Show("OPID数据不完整，请重新扫描！" + ex.Message);
            }
            catch (ModFileWriteException)
            {
                JudgementBox.Image = Judgement.Images[2];
            }
            catch(Exception)
            {
                JudgementBox.Image = Judgement.Images[2];
            }
        }
        //主窗口加载时执行
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                Scanner.Open();
                if (Scanner.IsOpen)
                {
                    ConnectStatus.Text = "已连接";
                    ConnectStatus.ForeColor = Color.Black;
                }
            }
            catch(Exception ex)
            {
                ConnectStatus.Text = "未连接";
                ConnectStatus.ForeColor = Color.Red;
                status.Text = "Conn Port NG";
                status.Location = new Point(24, 13);
                MessageBox.Show(ex.Message);
            }
            
        }
        //关闭程序时执行
        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            if (Scanner.IsOpen)
            {
                Scanner.DiscardInBuffer();
                Scanner.Close();
            }
        }
    }
}
