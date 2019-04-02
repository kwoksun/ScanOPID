namespace ScanOPID
{
    partial class FrmMainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainForm));
            this.OPIDBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OPIDlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InfoBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StatusGB = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ConnectStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Scanner = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.JudgeBox = new System.Windows.Forms.GroupBox();
            this.JudgementBox = new System.Windows.Forms.PictureBox();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetupPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Countlabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OPIDBox.SuspendLayout();
            this.InfoBox.SuspendLayout();
            this.StatusGB.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.JudgeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JudgementBox)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OPIDBox
            // 
            this.OPIDBox.Controls.Add(this.label3);
            this.OPIDBox.Controls.Add(this.OPIDlabel);
            this.OPIDBox.Location = new System.Drawing.Point(12, 498);
            this.OPIDBox.Name = "OPIDBox";
            this.OPIDBox.Size = new System.Drawing.Size(592, 112);
            this.OPIDBox.TabIndex = 1;
            this.OPIDBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 38F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 59);
            this.label3.TabIndex = 3;
            this.label3.Text = "OPID";
            // 
            // OPIDlabel
            // 
            this.OPIDlabel.AutoSize = true;
            this.OPIDlabel.Font = new System.Drawing.Font("幼圆", 38F);
            this.OPIDlabel.Location = new System.Drawing.Point(147, 36);
            this.OPIDlabel.Name = "OPIDlabel";
            this.OPIDlabel.Size = new System.Drawing.Size(438, 51);
            this.OPIDlabel.TabIndex = 1;
            this.OPIDlabel.Text = "0000000000000000";
            this.OPIDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Machine Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Scanner";
            // 
            // InfoBox
            // 
            this.InfoBox.Controls.Add(this.label4);
            this.InfoBox.Controls.Add(this.label6);
            this.InfoBox.Controls.Add(this.label5);
            this.InfoBox.Controls.Add(this.StatusGB);
            this.InfoBox.Controls.Add(this.groupBox3);
            this.InfoBox.Controls.Add(this.groupBox1);
            this.InfoBox.Controls.Add(this.label1);
            this.InfoBox.Location = new System.Drawing.Point(12, 33);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(450, 450);
            this.InfoBox.TabIndex = 3;
            this.InfoBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // StatusGB
            // 
            this.StatusGB.Controls.Add(this.status);
            this.StatusGB.Location = new System.Drawing.Point(6, 364);
            this.StatusGB.Name = "StatusGB";
            this.StatusGB.Size = new System.Drawing.Size(438, 80);
            this.StatusGB.TabIndex = 4;
            this.StatusGB.TabStop = false;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("宋体", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.status.Location = new System.Drawing.Point(150, 26);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(137, 37);
            this.status.TabIndex = 4;
            this.status.Text = "Normal";
            this.status.SizeChanged += new System.EventHandler(this.UpdateStatusLocation);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ConnectStatus);
            this.groupBox3.Location = new System.Drawing.Point(6, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 80);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // ConnectStatus
            // 
            this.ConnectStatus.AutoSize = true;
            this.ConnectStatus.Font = new System.Drawing.Font("宋体", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConnectStatus.ForeColor = System.Drawing.Color.Black;
            this.ConnectStatus.Location = new System.Drawing.Point(153, 27);
            this.ConnectStatus.Name = "ConnectStatus";
            this.ConnectStatus.Size = new System.Drawing.Size(131, 37);
            this.ConnectStatus.TabIndex = 3;
            this.ConnectStatus.Text = "连接中";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(6, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(92, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 37);
            this.label7.TabIndex = 2;
            this.label7.Text = "SP Motor接着";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 42F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Information";
            // 
            // Scanner
            // 
            this.Scanner.BaudRate = 115200;
            this.Scanner.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.RcvData);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 42F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "Judgement";
            // 
            // JudgeBox
            // 
            this.JudgeBox.Controls.Add(this.JudgementBox);
            this.JudgeBox.Controls.Add(this.label2);
            this.JudgeBox.Location = new System.Drawing.Point(482, 33);
            this.JudgeBox.Name = "JudgeBox";
            this.JudgeBox.Size = new System.Drawing.Size(450, 450);
            this.JudgeBox.TabIndex = 2;
            this.JudgeBox.TabStop = false;
            // 
            // JudgementBox
            // 
            this.JudgementBox.Image = global::ScanOPID.Properties.Resources.Busy;
            this.JudgementBox.Location = new System.Drawing.Point(6, 114);
            this.JudgementBox.Name = "JudgementBox";
            this.JudgementBox.Size = new System.Drawing.Size(438, 330);
            this.JudgementBox.TabIndex = 2;
            this.JudgementBox.TabStop = false;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(944, 25);
            this.MainMenu.TabIndex = 4;
            this.MainMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetupPortToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // SetupPortToolStripMenuItem
            // 
            this.SetupPortToolStripMenuItem.Name = "SetupPortToolStripMenuItem";
            this.SetupPortToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.SetupPortToolStripMenuItem.Text = "Setup Port";
            this.SetupPortToolStripMenuItem.Click += new System.EventHandler(this.SetupPortToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Countlabel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(610, 498);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 112);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // Countlabel
            // 
            this.Countlabel.AutoSize = true;
            this.Countlabel.Font = new System.Drawing.Font("幼圆", 38F);
            this.Countlabel.Location = new System.Drawing.Point(190, 36);
            this.Countlabel.Name = "Countlabel";
            this.Countlabel.Size = new System.Drawing.Size(126, 51);
            this.Countlabel.TabIndex = 4;
            this.Countlabel.Text = "0000";
            this.Countlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 38F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(25, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 59);
            this.label8.TabIndex = 4;
            this.label8.Text = "Count";
            // 
            // FrmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(944, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.JudgeBox);
            this.Controls.Add(this.OPIDBox);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanOPID";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.OPIDBox.ResumeLayout(false);
            this.OPIDBox.PerformLayout();
            this.InfoBox.ResumeLayout(false);
            this.InfoBox.PerformLayout();
            this.StatusGB.ResumeLayout(false);
            this.StatusGB.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.JudgeBox.ResumeLayout(false);
            this.JudgeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JudgementBox)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox OPIDBox;
        private System.Windows.Forms.GroupBox InfoBox;
        private System.Windows.Forms.Label OPIDlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox StatusGB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label ConnectStatus;
        internal System.Windows.Forms.Label status;
        internal System.IO.Ports.SerialPort Scanner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox JudgeBox;
        private System.Windows.Forms.PictureBox JudgementBox;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetupPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Countlabel;
        private System.Windows.Forms.Label label8;
    }
}

