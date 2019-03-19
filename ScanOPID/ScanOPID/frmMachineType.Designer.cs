namespace ScanOPID
{
    partial class FrmMachineType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMachineType));
            this.MacType = new System.Windows.Forms.Label();
            this.DefType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmtselect = new System.Windows.Forms.ComboBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MacType
            // 
            this.MacType.AutoSize = true;
            this.MacType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.MacType.Location = new System.Drawing.Point(36, 36);
            this.MacType.Name = "MacType";
            this.MacType.Size = new System.Drawing.Size(74, 21);
            this.MacType.TabIndex = 0;
            this.MacType.Text = "当前机种";
            // 
            // DefType
            // 
            this.DefType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.DefType.Location = new System.Drawing.Point(142, 33);
            this.DefType.Multiline = true;
            this.DefType.Name = "DefType";
            this.DefType.ReadOnly = true;
            this.DefType.Size = new System.Drawing.Size(104, 31);
            this.DefType.TabIndex = 0;
            this.DefType.TabStop = false;
            this.DefType.Text = "KES-481";
            this.DefType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(36, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "切换机种";
            // 
            // cbmtselect
            // 
            this.cbmtselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmtselect.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbmtselect.FormattingEnabled = true;
            this.cbmtselect.Items.AddRange(new object[] {
            "KES-481",
            "KEM-496"});
            this.cbmtselect.Location = new System.Drawing.Point(142, 94);
            this.cbmtselect.Name = "cbmtselect";
            this.cbmtselect.Size = new System.Drawing.Size(104, 29);
            this.cbmtselect.TabIndex = 3;
            // 
            // OKBtn
            // 
            this.OKBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OKBtn.Location = new System.Drawing.Point(56, 158);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(71, 40);
            this.OKBtn.TabIndex = 7;
            this.OKBtn.Text = "设置";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CancelBtn.Location = new System.Drawing.Point(155, 158);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(71, 40);
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "关闭";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // MachineType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(284, 242);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.cbmtselect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DefType);
            this.Controls.Add(this.MacType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MachineType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MachineType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MacType;
        private System.Windows.Forms.TextBox DefType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmtselect;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}