using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace openweasel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string zipPath = @"\iw.zip";
            
            
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            Close();
        }
        // install openweasel and virtualbox check box
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        // install button
        private void install_Click(object sender, EventArgs e)
        {
            int switchnum = 0;
            if (switchnum == 0)
            {
                if (installowandvb.Checked == true & loadowintovb.Checked == false & extract.Checked == false)
                {
                    install.Enabled = true;
                    switchnum = 1;
                }
                else
                {
                    if (installowandvb.Checked == false & loadowintovb.Checked == true & extract.Checked == false)
                    {
                        install.Enabled = true;
                        switchnum = 2;
                    }
                    else
                    {
                        if (installowandvb.Checked == false & loadowintovb.Checked == false & extract.Checked == true)
                        {
                            install.Enabled = true;
                            switchnum = 3;
                        }
                        else
                        {
                            Form2 frm = new Form2();
                            frm.Show();
                            Visible = false;
                        }
                    }
                }
            }  //ifswitchnum=0 bracket 
            if (switchnum == 1)
            {
                //install openweasel and virtualbox
                backgroundWorker1.RunWorkerAsync();



            }
           else
            {
                if (switchnum == 2)
                {
                    //load openweasel into virtualbox
                }
                else
                {
                    
                }
            }
                 
         }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string extractPath = @"c:\oweaselsetup";
            //int i;
            backgroundWorker1.ReportProgress(10);
            Directory.CreateDirectory(@"c:\oweaselsetup");
            //should i chunk up extraction process?
            ZipFile.ExtractToDirectory(@"IceWeasel Downloads.zip", extractPath);
            backgroundWorker1.ReportProgress(20);
            ZipFile.ExtractToDirectory(@"IceWeasel Browserova.zip", extractPath);
            backgroundWorker1.ReportProgress(25);
            ZipFile.ExtractToDirectory(@"VirtualBoxInstaller.zip", extractPath);
            backgroundWorker1.ReportProgress(30);
            ZipFile.ExtractToDirectory(@"IceWeasel Browsershortcut.zip", extractPath);
            backgroundWorker1.ReportProgress(35);
            ZipFile.ExtractToDirectory(@"IceWeaselbat.zip", extractPath);
            backgroundWorker1.ReportProgress(40);
            ZipFile.ExtractToDirectory(@"iceweaselicon.zip", extractPath);
            backgroundWorker1.ReportProgress(42);
            ZipFile.ExtractToDirectory(@"install.zip", extractPath);
            backgroundWorker1.ReportProgress(45);
            ZipFile.ExtractToDirectory(@"installp2.zip", extractPath);
            backgroundWorker1.ReportProgress(50);
            ZipFile.ExtractToDirectory(@"switch.zip", extractPath);
            /*
            for (int i = 0; i <= 1; i++)
            {
                //CHECK FOR CANCELLATION FIRST
                if (backgroundWorker1.CancellationPending)
                {
                    //CANCEL
                    e.Cancel = true;
                }
                else
                {
                    //progressBar1.Value = 10;
                    //install.Enabled = false;
                    //processlabel.Text = "Extracting:";
                    //System.Threading.Thread.Sleep(5000);
                    Directory.CreateDirectory(@"c:\oweaselsetup");
                    ZipFile.ExtractToDirectory(@"ow.zip", @"c:\oweaselsetup");
                    //progressBar1.Value = 20;
                    backgroundWorker1.ReportProgress(i);
                }
            }
            */
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                //display("You have Cancelled");
                progressBar1.Value = 0;
                //percentageLabel.Text = "0";
            }
            else
            {
                //display("Work completed successfully");
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            if (progressBar1.Value == 10)
            {
                processlabel.Text = "Creating Directory:";
            }
            else
            {
                if (progressBar1.Value == 20)
                {
                    processlabel.Text = "Extracting IceWeasel Browser.ova this may take awhile:";
                }
                else
                {
                    if (progressBar1.Value == 25)
                    {
                        processlabel.Text = "Extracting VirtualBox Installer.exe";
                    }
                    else
                    {
                        if (progressBar1.Value == 30)
                        {
                            processlabel.Text = "Extracting Icon File";
                        }
                        else
                        {
                            if (progressBar1.Value == 35)
                            {
                                processlabel.Text = "Extracting IceWeasel batch file";
                            }
                            else
                            {
                                if (progressBar1.Value == 40)
                                {
                                    processlabel.Text = "Extracting IceWeasel icon file";
                                }
                                else
                                {
                                    if (progressBar1.Value == 42)
                                    {
                                        processlabel.Text = "Extracting Install File";
                                    }
                                    else
                                    {
                                        if (progressBar1.Value == 45)
                                        {
                                            processlabel.Text = "Extracting Install File #2";
                                        }
                                        else
                                        {
                                            if (progressBar1.Value == 50)
                                            {
                                                processlabel.Text = "Extracting Switch";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
