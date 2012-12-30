namespace Hack_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnScan = new System.Windows.Forms.Button();
            this.prgScanning = new System.Windows.Forms.ProgressBar();
            this.numStart = new System.Windows.Forms.NumericUpDown();
            this.numEnd = new System.Windows.Forms.NumericUpDown();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(508, 401);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtIP);
            this.tabPage1.Controls.Add(this.txtLog);
            this.tabPage1.Controls.Add(this.numEnd);
            this.tabPage1.Controls.Add(this.numStart);
            this.tabPage1.Controls.Add(this.prgScanning);
            this.tabPage1.Controls.Add(this.btnScan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(500, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Port Scanner";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(454, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(10, 99);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(483, 29);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan!";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // prgScanning
            // 
            this.prgScanning.Location = new System.Drawing.Point(10, 159);
            this.prgScanning.Name = "prgScanning";
            this.prgScanning.Size = new System.Drawing.Size(483, 23);
            this.prgScanning.TabIndex = 1;
            // 
            // numStart
            // 
            this.numStart.Location = new System.Drawing.Point(284, 40);
            this.numStart.Name = "numStart";
            this.numStart.Size = new System.Drawing.Size(30, 20);
            this.numStart.TabIndex = 2;
            // 
            // numEnd
            // 
            this.numEnd.Location = new System.Drawing.Point(404, 41);
            this.numEnd.Name = "numEnd";
            this.numEnd.Size = new System.Drawing.Size(31, 20);
            this.numEnd.TabIndex = 3;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(10, 188);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(483, 181);
            this.txtLog.TabIndex = 10;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(78, 41);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(127, 20);
            this.txtIP.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ip Adress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 402);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "HackTools";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.NumericUpDown numEnd;
        private System.Windows.Forms.NumericUpDown numStart;
        private System.Windows.Forms.ProgressBar prgScanning;
        private System.Windows.Forms.Button btnScan;
    }
}

