namespace BusylightTester
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRedWithSound = new System.Windows.Forms.Button();
            this.btnPulse = new System.Windows.Forms.Button();
            this.pnlKuandoBox = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTriggertime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTimeout = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSensivity = new System.Windows.Forms.ComboBox();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.btnJingle = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnJingle2 = new System.Windows.Forms.Button();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRedBlink = new System.Windows.Forms.Button();
            this.btnRBFlash = new System.Windows.Forms.Button();
            this.btnGBFlash = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlKuandoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 182);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 43);
            this.listBox1.TabIndex = 0;
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(12, 12);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(46, 23);
            this.btnGreen.TabIndex = 2;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnRedWithSound
            // 
            this.btnRedWithSound.Location = new System.Drawing.Point(12, 41);
            this.btnRedWithSound.Name = "btnRedWithSound";
            this.btnRedWithSound.Size = new System.Drawing.Size(95, 23);
            this.btnRedWithSound.TabIndex = 3;
            this.btnRedWithSound.Text = "Red with Sound";
            this.btnRedWithSound.UseVisualStyleBackColor = true;
            this.btnRedWithSound.Click += new System.EventHandler(this.btnRedWithSound_Click);
            // 
            // btnPulse
            // 
            this.btnPulse.Location = new System.Drawing.Point(64, 12);
            this.btnPulse.Name = "btnPulse";
            this.btnPulse.Size = new System.Drawing.Size(43, 23);
            this.btnPulse.TabIndex = 4;
            this.btnPulse.Text = "Pulse";
            this.btnPulse.UseVisualStyleBackColor = true;
            this.btnPulse.Click += new System.EventHandler(this.btnPulse_Click);
            // 
            // pnlKuandoBox
            // 
            this.pnlKuandoBox.Controls.Add(this.label3);
            this.pnlKuandoBox.Controls.Add(this.cmbTriggertime);
            this.pnlKuandoBox.Controls.Add(this.label2);
            this.pnlKuandoBox.Controls.Add(this.cmbTimeout);
            this.pnlKuandoBox.Controls.Add(this.label1);
            this.pnlKuandoBox.Controls.Add(this.cmbSensivity);
            this.pnlKuandoBox.Controls.Add(this.pbColor);
            this.pnlKuandoBox.Location = new System.Drawing.Point(12, 247);
            this.pnlKuandoBox.Name = "pnlKuandoBox";
            this.pnlKuandoBox.Size = new System.Drawing.Size(534, 100);
            this.pnlKuandoBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Triggertime";
            // 
            // cmbTriggertime
            // 
            this.cmbTriggertime.DisplayMember = "key";
            this.cmbTriggertime.FormattingEnabled = true;
            this.cmbTriggertime.Location = new System.Drawing.Point(328, 44);
            this.cmbTriggertime.Name = "cmbTriggertime";
            this.cmbTriggertime.Size = new System.Drawing.Size(67, 21);
            this.cmbTriggertime.TabIndex = 11;
            this.cmbTriggertime.ValueMember = "value";
            this.cmbTriggertime.SelectedIndexChanged += new System.EventHandler(this.cmbTriggertime_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Timeout";
            // 
            // cmbTimeout
            // 
            this.cmbTimeout.DisplayMember = "key";
            this.cmbTimeout.FormattingEnabled = true;
            this.cmbTimeout.Location = new System.Drawing.Point(234, 44);
            this.cmbTimeout.Name = "cmbTimeout";
            this.cmbTimeout.Size = new System.Drawing.Size(67, 21);
            this.cmbTimeout.TabIndex = 9;
            this.cmbTimeout.ValueMember = "value";
            this.cmbTimeout.SelectedIndexChanged += new System.EventHandler(this.cmbTimeout_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sensivity";
            // 
            // cmbSensivity
            // 
            this.cmbSensivity.DisplayMember = "key";
            this.cmbSensivity.FormattingEnabled = true;
            this.cmbSensivity.Location = new System.Drawing.Point(148, 44);
            this.cmbSensivity.Name = "cmbSensivity";
            this.cmbSensivity.Size = new System.Drawing.Size(67, 21);
            this.cmbSensivity.TabIndex = 7;
            this.cmbSensivity.ValueMember = "value";
            this.cmbSensivity.SelectedIndexChanged += new System.EventHandler(this.cmbSensivity_SelectedIndexChanged);
            // 
            // pbColor
            // 
            this.pbColor.BackColor = System.Drawing.Color.Blue;
            this.pbColor.Location = new System.Drawing.Point(24, 21);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(100, 50);
            this.pbColor.TabIndex = 2;
            this.pbColor.TabStop = false;
            // 
            // btnJingle
            // 
            this.btnJingle.Location = new System.Drawing.Point(113, 41);
            this.btnJingle.Name = "btnJingle";
            this.btnJingle.Size = new System.Drawing.Size(56, 23);
            this.btnJingle.TabIndex = 8;
            this.btnJingle.Text = "Jingle";
            this.btnJingle.UseVisualStyleBackColor = true;
            this.btnJingle.Click += new System.EventHandler(this.btnJingle_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(113, 12);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(56, 23);
            this.btnCustom.TabIndex = 9;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnJingle2
            // 
            this.btnJingle2.Location = new System.Drawing.Point(113, 70);
            this.btnJingle2.Name = "btnJingle2";
            this.btnJingle2.Size = new System.Drawing.Size(56, 23);
            this.btnJingle2.TabIndex = 10;
            this.btnJingle2.Text = "Jingle 2";
            this.btnJingle2.UseVisualStyleBackColor = true;
            this.btnJingle2.Click += new System.EventHandler(this.btnJingle2_Click);
            // 
            // tbVolume
            // 
            this.tbVolume.LargeChange = 25;
            this.tbVolume.Location = new System.Drawing.Point(130, 108);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbVolume.Size = new System.Drawing.Size(45, 68);
            this.tbVolume.SmallChange = 25;
            this.tbVolume.TabIndex = 11;
            this.tbVolume.TickFrequency = 25;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbVolume.Value = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Volume";
            // 
            // btnRedBlink
            // 
            this.btnRedBlink.Location = new System.Drawing.Point(12, 70);
            this.btnRedBlink.Name = "btnRedBlink";
            this.btnRedBlink.Size = new System.Drawing.Size(95, 23);
            this.btnRedBlink.TabIndex = 16;
            this.btnRedBlink.Text = "Red Blink";
            this.btnRedBlink.UseVisualStyleBackColor = true;
            this.btnRedBlink.Click += new System.EventHandler(this.btnYBFlash_Click);
            // 
            // btnRBFlash
            // 
            this.btnRBFlash.Location = new System.Drawing.Point(11, 125);
            this.btnRBFlash.Name = "btnRBFlash";
            this.btnRBFlash.Size = new System.Drawing.Size(107, 23);
            this.btnRBFlash.TabIndex = 15;
            this.btnRBFlash.Text = "Red Blue Flash";
            this.btnRBFlash.UseVisualStyleBackColor = true;
            this.btnRBFlash.Click += new System.EventHandler(this.btnRBFlash_Click);
            // 
            // btnGBFlash
            // 
            this.btnGBFlash.Location = new System.Drawing.Point(12, 98);
            this.btnGBFlash.Name = "btnGBFlash";
            this.btnGBFlash.Size = new System.Drawing.Size(107, 23);
            this.btnGBFlash.TabIndex = 14;
            this.btnGBFlash.Text = "Green Blue Flash";
            this.btnGBFlash.UseVisualStyleBackColor = true;
            this.btnGBFlash.Click += new System.EventHandler(this.btnGBFlash_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Made by Bart Hamblok  2017";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Minimized";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 246);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRedBlink);
            this.Controls.Add(this.btnRBFlash);
            this.Controls.Add(this.btnGBFlash);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.btnJingle2);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnJingle);
            this.Controls.Add(this.pnlKuandoBox);
            this.Controls.Add(this.btnPulse);
            this.Controls.Add(this.btnRedWithSound);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BusyLight Tester";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.pnlKuandoBox.ResumeLayout(false);
            this.pnlKuandoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRedWithSound;
        private System.Windows.Forms.Button btnPulse;
        private System.Windows.Forms.Panel pnlKuandoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSensivity;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTriggertime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTimeout;
        private System.Windows.Forms.Button btnJingle;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnJingle2;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRedBlink;
        private System.Windows.Forms.Button btnRBFlash;
        private System.Windows.Forms.Button btnGBFlash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

