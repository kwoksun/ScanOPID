using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanOPID
{
    public partial class FrmMachineType : Form
    {
        public static int OPIDLength = 12;
        public int[] mttbl = { 12, 15 };
        public FrmMachineType()
        {
            InitializeComponent();
            DefType.Text = "KES-481";
            cbmtselect.SelectedIndex = 0;

        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            OPIDLength = mttbl[cbmtselect.SelectedIndex];
            DefType.Text = cbmtselect.Text;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
