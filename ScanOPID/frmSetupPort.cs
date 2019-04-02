using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace ScanOPID
{
    public partial class FrmSetupPort : Form
    {
        //主窗口变量
        private FrmMainForm mf;
        //构造初始化
        public FrmSetupPort()
        {
            InitializeComponent();
            //校验位、停止位赋值
            cbParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            List<string> vs = Enum.GetNames(typeof(StopBits)).ToList();
            vs.Remove("None");
            cbStopBits.Items.AddRange(vs.ToArray());
        }
        //窗口加载时执行
        private void SetupPort_Load(object sender, EventArgs e)
        {
            try
            {
                mf = (FrmMainForm)Owner;
            }catch(InvalidCastException ex)
            {
                MessageBox.Show("窗口打开失败！" + ex.Message);
            }
            cbPortName.Items.Clear();//清除所有下拉栏内容
            string[] PortNameItem = SerialPort.GetPortNames();//获取所有可用端口号
            Array.Sort(PortNameItem, delegate(string lhs, string rhs)//匿名委托
             {
                 //长度相等按数值比较
                 if (lhs.Length == rhs.Length)
                 {
                     return lhs.CompareTo(rhs);
                 }
                 //否则按长度比较
                 else
                 {
                     return lhs.Length.CompareTo(rhs.Length);
                 }
             });
            //端口号赋值
            cbPortName.Items.AddRange(PortNameItem);
            //下拉栏默认显示的值
            int n = cbPortName.Items.IndexOf(mf.Scanner.PortName.ToString());
            cbPortName.SelectedIndex = n == -1 ? 0 : n;
            cbBaudRate.SelectedIndex = cbBaudRate.Items.IndexOf(mf.Scanner.BaudRate.ToString());
            cbDataBits.SelectedIndex = cbDataBits.Items.IndexOf(mf.Scanner.DataBits.ToString());
            cbParity.SelectedIndex = cbParity.Items.IndexOf(mf.Scanner.Parity.ToString());
            cbStopBits.SelectedIndex = cbStopBits.Items.IndexOf(mf.Scanner.StopBits.ToString());
            //cbHandshake.SelectedIndex = cbHandshake.Items.IndexOf(mf.Scanner.Handshake.ToString());
        }
        //点击确定
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            //关闭当前串口
            if (mf.Scanner.IsOpen)
            {
                mf.Scanner.DiscardOutBuffer();
                mf.Scanner.Close();
            }
            Properties.Settings.Default.ComPort = cbPortName.Text;
            Properties.Settings.Default.Save();
            //串口属性按照选定值赋值
            mf.Scanner.PortName = cbPortName.Text;
            mf.Scanner.BaudRate = Convert.ToInt32(cbBaudRate.Text);
            mf.Scanner.DataBits = Convert.ToInt32(cbDataBits.Text);
            mf.Scanner.Parity = (Parity)Enum.Parse(typeof(Parity), cbParity.Text);
            mf.Scanner.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbStopBits.Text);
            try
            {
                if (mf.Scanner.DataBits == 5)
                {
                    if (mf.Scanner.StopBits == StopBits.Two)
                    {
                        throw new ArgumentException("数据位为5bit时，停止位不能为2bit");
                    }
                }
                else
                {
                    if(mf.Scanner.StopBits == StopBits.OnePointFive)
                    {
                        throw new ArgumentException("数据位为6,7,8bit时，停止位不能为1.5bit");
                    }
                }
                mf.Scanner.Open();
                mf.ConnectStatus.Text = "已连接";
                mf.ConnectStatus.ForeColor = Color.Black;
                mf.status.Text = "Normal";
            }
            catch (ArgumentException ex)
            {
                mf.ConnectStatus.Text = "未连接";
                mf.ConnectStatus.ForeColor = Color.Red;
                mf.status.Text = "Conn Port NG";
                MessageBox.Show("打开串口失败，错误的串口设置!" + ex.Message);
            }
            catch(Exception ex)
            {
                mf.ConnectStatus.Text = "未连接";
                mf.ConnectStatus.ForeColor = Color.Red;
                mf.status.Text = "Conn Port NG";
                MessageBox.Show("打开串口失败!" + ex.Message);
            }
            Close();
        }
        //点击取消
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
