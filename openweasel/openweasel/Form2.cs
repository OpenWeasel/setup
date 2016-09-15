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
            string extractPath = @"c:\oweaselsetup";
            
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
            //int i;
            backgroundWorker1.ReportProgress(20);
            Directory.CreateDirectory(@"c:\oweaselsetup");
            //should i chunk up extraction process?
            ZipFile.ExtractToDirectory(@"ow.zip", @"c:\oweaselsetup");

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
            if (progressBar1.Value == 20)
            {
                processlabel.Text = "Extracting:";
            }
            else
            {

            }
        }
    }
}
