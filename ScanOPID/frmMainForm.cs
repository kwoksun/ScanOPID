using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScanOPID
{
    public partial class FrmMainForm : Form
    {
        private ModBarCodeFile barcode;
        private ModLogFile log;
        private int count = 0;
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
            }
        }
        private void CountUpdate(string s)
        {
            if (InvokeRequired)
            {
                Invoke((EventHandler)(delegate
                {
                    CountUpdate(s);
                }));
            }
            else
            {
                Countlabel.Text = s;
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
                //JudgementBox.Image = Judgement.Images[1];
                JudgementBox.Image = Properties.Resources.OK;
                ChangeStatus("Normal");
                CountUpdate((++count).ToString());
                //上传数据
                barcode.WriteBarCodeFile(opid, "1");
                //写Log
                log.CreateFile();
                log.WriteLogFile(ModLogFile.LogType.Norm, opid);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                DataUpdate(data);
                //JudgementBox.Image = Judgement.Images[2];
                JudgementBox.Image = Properties.Resources.NG;
                ChangeStatus("Scan NG");
                log.CreateFile();
                log.WriteLogFile(ModLogFile.LogType.Erro, data);
                MessageBox.Show("OPID数据不完整，请重新扫描！" + ex.Message);
            }
            catch (ModFileWriteException)
            {
                MessageBox.Show("modfile exception");
                //JudgementBox.Image = Judgement.Images[2];
                JudgementBox.Image = Properties.Resources.NG;
            }
            catch(Exception)
            {
                MessageBox.Show("exception");
                //JudgementBox.Image = Judgement.Images[2];
                JudgementBox.Image = Properties.Resources.NG;
            }
        }
        //主窗口加载时执行
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                Scanner.PortName = Properties.Settings.Default.ComPort;
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
        //状态变更时自动更新文字位置
        private void UpdateStatusLocation(object sender, EventArgs e)
        {
            int marginX = StatusGB.Width - status.Width;
            int marginY = StatusGB.Height - status.Height;
            status.Location = new Point(marginX / 2, marginY / 2 + StatusGB.Margin.Top);
        }
        //退出按钮
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}