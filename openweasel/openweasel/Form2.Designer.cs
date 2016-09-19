namespace openweasel
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.install = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.installowandvb = new System.Windows.Forms.CheckBox();
            this.loadowintovb = new System.Windows.Forms.CheckBox();
            this.extract = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.processlabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // install
            // 
            this.install.Location = new System.Drawing.Point(390, 343);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(75, 23);
            this.install.TabIndex = 0;
            this.install.Text = "Install";
            this.install.UseVisualStyleBackColor = true;
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 343);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 140);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // installowandvb
            // 
            this.installowandvb.AutoSize = true;
            this.installowandvb.Checked = true;
            this.installowandvb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.installowandvb.Location = new System.Drawing.Point(242, 302);
            this.installowandvb.Name = "installowandvb";
            this.installowandvb.Size = new System.Drawing.Size(223, 17);
            this.installowandvb.TabIndex = 3;
            this.installowandvb.Text = "Install OpenWeasel and Oracle VirtualBox";
            this.installowandvb.UseVisualStyleBackColor = true;
            this.installowandvb.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // loadowintovb
            // 
            this.loadowintovb.AutoSize = true;
            this.loadowintovb.Location = new System.Drawing.Point(242, 273);
            this.loadowintovb.Name = "loadowintovb";
            this.loadowintovb.Size = new System.Drawing.Size(219, 17);
            this.loadowintovb.TabIndex = 4;
            this.loadowintovb.Text = "Load OpenWeasel into Oracle VirtualBox";
            this.loadowintovb.UseVisualStyleBackColor = true;
            // 
            // extract
            // 
            this.extract.AutoSize = true;
            this.extract.Location = new System.Drawing.Point(242, 243);
            this.extract.Name = "extract";
            this.extract.Size = new System.Drawing.Size(163, 17);
            this.extract.TabIndex = 5;
            this.extract.Text = "Extract Virtual Machine Drive";
            this.extract.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 173);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(453, 23);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // processlabel
            // 
            this.processlabel.AutoSize = true;
            this.processlabel.Location = new System.Drawing.Point(10, 156);
            this.processlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.processlabel.Name = "processlabel";
            this.processlabel.Size = new System.Drawing.Size(0, 13);
            this.processlabel.TabIndex = 7;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 378);
            this.Controls.Add(this.processlabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.extract);
            this.Controls.Add(this.loadowintovb);
            this.Controls.Add(this.installowandvb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.install);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenWeasel";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button install;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox installowandvb;
        private System.Windows.Forms.CheckBox loadowintovb;
        private System.Windows.Forms.CheckBox extract;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label processlabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}