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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OPIDBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OPIDlabel = new System.Windows.Forms.Label();
            this.JudgeBox = new System.Windows.Forms.GroupBox();
            this.JudgementBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InfoBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ConnectStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Scanner = new System.IO.Ports.SerialPort(this.components);
            this.Judgement = new System.Windows.Forms.ImageList(this.components);
            this.Menu.SuspendLayout();
            this.OPIDBox.SuspendLayout();
            this.JudgeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JudgementBox)).BeginInit();
            this.InfoBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(584, 25);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupPortToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // setupPortToolStripMenuItem
            // 
            this.setupPortToolStripMenuItem.Name = "setupPortToolStripMenuItem";
            this.setupPortToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.setupPortToolStripMenuItem.Text = "Setup Port";
            this.setupPortToolStripMenuItem.Click += new System.EventHandler(this.SetupPortToolStripMenuItem_Click);
            // 
            // OPIDBox
            // 
            this.OPIDBox.Controls.Add(this.label3);
            this.OPIDBox.Controls.Add(this.OPIDlabel);
            this.OPIDBox.Location = new System.Drawing.Point(12, 330);
            this.OPIDBox.Name = "OPIDBox";
            this.OPIDBox.Size = new System.Drawing.Size(560, 70);
            this.OPIDBox.TabIndex = 1;
            this.OPIDBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "OPID";
            // 
            // OPIDlabel
            // 
            this.OPIDlabel.AutoSize = true;
            this.OPIDlabel.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OPIDlabel.Location = new System.Drawing.Point(216, 24);
            this.OPIDlabel.Name = "OPIDlabel";
            this.OPIDlabel.Size = new System.Drawing.Size(253, 29);
            this.OPIDlabel.TabIndex = 1;
            this.OPIDlabel.Text = "0000000000000000";
            // 
            // JudgeBox
            // 
            this.JudgeBox.Controls.Add(this.JudgementBox);
            this.JudgeBox.Controls.Add(this.label2);
            this.JudgeBox.Location = new System.Drawing.Point(286, 28);
            this.JudgeBox.Name = "JudgeBox";
            this.JudgeBox.Size = new System.Drawing.Size(286, 296);
            this.JudgeBox.TabIndex = 2;
            this.JudgeBox.TabStop = false;
            // 
            // JudgementBox
            // 
            this.JudgementBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.JudgementBox.Image = ((System.Drawing.Image)(resources.GetObject("JudgementBox.Image")));
            this.JudgementBox.Location = new System.Drawing.Point(17, 62);
            this.JudgementBox.Name = "JudgementBox";
            this.JudgementBox.Size = new System.Drawing.Size(250, 218);
            this.JudgementBox.TabIndex = 2;
            this.JudgementBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Judgement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Machine Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Scanner";
            // 
            // InfoBox
            // 
            this.InfoBox.Controls.Add(this.label4);
            this.InfoBox.Controls.Add(this.label6);
            this.InfoBox.Controls.Add(this.label5);
            this.InfoBox.Controls.Add(this.groupBox2);
            this.InfoBox.Controls.Add(this.groupBox3);
            this.InfoBox.Controls.Add(this.groupBox1);
            this.InfoBox.Controls.Add(this.label1);
            this.InfoBox.Location = new System.Drawing.Point(12, 28);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(268, 296);
            this.InfoBox.TabIndex = 3;
            this.InfoBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.status);
            this.groupBox2.Location = new System.Drawing.Point(21, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 43);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("宋体", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.status.Location = new System.Drawing.Point(64, 13);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(88, 24);
            this.status.TabIndex = 4;
            this.status.Text = "Normal";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ConnectStatus);
            this.groupBox3.Location = new System.Drawing.Point(21, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 43);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // ConnectStatus
            // 
            this.ConnectStatus.AutoSize = true;
            this.ConnectStatus.Font = new System.Drawing.Font("宋体", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConnectStatus.ForeColor = System.Drawing.Color.Black;
            this.ConnectStatus.Location = new System.Drawing.Point(64, 14);
            this.ConnectStatus.Name = "ConnectStatus";
            this.ConnectStatus.Size = new System.Drawing.Size(85, 24);
            this.ConnectStatus.TabIndex = 3;
            this.ConnectStatus.Text = "连接中";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(21, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 43);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(28, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "SP Motor接着";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Information";
            // 
            // Scanner
            // 
            this.Scanner.BaudRate = 115200;
            this.Scanner.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.RcvData);
            // 
            // Judgement
            // 
            this.Judgement.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Judgement.ImageStream")));
            this.Judgement.TransparentColor = System.Drawing.Color.Transparent;
            this.Judgement.Images.SetKeyName(0, "Busy.jpg");
            this.Judgement.Images.SetKeyName(1, "OK.jpg");
            this.Judgement.Images.SetKeyName(2, "NG.jpg");
            // 
            // FrmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.JudgeBox);
            this.Controls.Add(this.OPIDBox);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.Name = "FrmMainForm";
            this.Text = "ScanOPID";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.OPIDBox.ResumeLayout(false);
            this.OPIDBox.PerformLayout();
            this.JudgeBox.ResumeLayout(false);
            this.JudgeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JudgementBox)).EndInit();
            this.InfoBox.ResumeLayout(false);
            this.InfoBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupPortToolStripMenuItem;
        private System.Windows.Forms.GroupBox OPIDBox;
        private System.Windows.Forms.GroupBox JudgeBox;
        private System.Windows.Forms.GroupBox InfoBox;
        private System.Windows.Forms.Label OPIDlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox JudgementBox;
        internal System.IO.Ports.SerialPort Scanner;
        internal System.Windows.Forms.Label ConnectStatus;
        private System.Windows.Forms.ImageList Judgement;
        internal System.Windows.Forms.Label status;
    }
}

