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
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // install
            // 
            this.install.Location = new System.Drawing.Point(520, 422);
            this.install.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(100, 28);
            this.install.TabIndex = 0;
            this.install.Text = "Install";
            this.install.UseVisualStyleBackColor = true;
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(16, 422);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 28);
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(637, 172);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // installowandvb
            // 
            this.installowandvb.AutoSize = true;
            this.installowandvb.Checked = true;
            this.installowandvb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.installowandvb.Location = new System.Drawing.Point(323, 372);
            this.installowandvb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.installowandvb.Name = "installowandvb";
            this.installowandvb.Size = new System.Drawing.Size(293, 21);
            this.installowandvb.TabIndex = 3;
            this.installowandvb.Text = "Install OpenWeasel and Oracle VirtualBox";
            this.installowandvb.UseVisualStyleBackColor = true;
            this.installowandvb.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // loadowintovb
            // 
            this.loadowintovb.AutoSize = true;
            this.loadowintovb.Location = new System.Drawing.Point(323, 336);
            this.loadowintovb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadowintovb.Name = "loadowintovb";
            this.loadowintovb.Size = new System.Drawing.Size(288, 21);
            this.loadowintovb.TabIndex = 4;
            this.loadowintovb.Text = "Load OpenWeasel into Oracle VirtualBox";
            this.loadowintovb.UseVisualStyleBackColor = true;
            this.loadowintovb.CheckedChanged += new System.EventHandler(this.loadowintovb_CheckedChanged);
            // 
            // extract
            // 
            this.extract.AutoSize = true;
            this.extract.Location = new System.Drawing.Point(323, 299);
            this.extract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.extract.Name = "extract";
            this.extract.Size = new System.Drawing.Size(211, 21);
            this.extract.TabIndex = 5;
            this.extract.Text = "Extract Virtual Machine Drive";
            this.extract.UseVisualStyleBackColor = true;
            this.extract.CheckedChanged += new System.EventHandler(this.extract_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 213);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(604, 28);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // processlabel
            // 
            this.processlabel.AutoSize = true;
            this.processlabel.Location = new System.Drawing.Point(13, 192);
            this.processlabel.Name = "processlabel";
            this.processlabel.Size = new System.Drawing.Size(0, 17);
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
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.WorkerReportsProgress = true;
            this.backgroundWorker3.WorkerSupportsCancellation = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 465);
            this.Controls.Add(this.processlabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.extract);
            this.Controls.Add(this.loadowintovb);
            this.Controls.Add(this.installowandvb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.install);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
    }
}