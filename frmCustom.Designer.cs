namespace BusylightTester
{
    partial class frmCustom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustom));
            this.label1 = new System.Windows.Forms.Label();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(208, 20);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(64, 20);
            this.txtRed.TabIndex = 1;
            this.txtRed.Text = "50";
            this.txtRed.TextChanged += new System.EventHandler(this.txtRed_TextChanged);
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(84, 20);
            this.tbRed.Maximum = 100;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(104, 45);
            this.tbRed.TabIndex = 2;
            this.tbRed.TickFrequency = 10;
            this.tbRed.Value = 50;
            this.tbRed.Scroll += new System.EventHandler(this.tbRed_Scroll);
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(84, 71);
            this.tbGreen.Maximum = 100;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(104, 45);
            this.tbGreen.TabIndex = 5;
            this.tbGreen.TickFrequency = 10;
            this.tbGreen.Value = 50;
            this.tbGreen.Scroll += new System.EventHandler(this.tbGreen_Scroll);
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(208, 71);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(64, 20);
            this.txtGreen.TabIndex = 4;
            this.txtGreen.Text = "50";
            this.txtGreen.TextChanged += new System.EventHandler(this.txtGreen_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Green";
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(84, 122);
            this.tbBlue.Maximum = 100;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(104, 45);
            this.tbBlue.TabIndex = 8;
            this.tbBlue.TickFrequency = 10;
            this.tbBlue.Value = 50;
            this.tbBlue.Scroll += new System.EventHandler(this.tbBlue_Scroll);
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(208, 122);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(64, 20);
            this.txtBlue.TabIndex = 7;
            this.txtBlue.Text = "50";
            this.txtBlue.TextChanged += new System.EventHandler(this.txtBlue_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Blue";
            // 
            // frmCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCustom";
            this.Text = "Busylight Custom Color";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustom_FormClosing);
            this.Shown += new System.EventHandler(this.frmCustom_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.Label label3;
    }
}