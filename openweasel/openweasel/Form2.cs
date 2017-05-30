/* @author James Houston
 * @contributors Taylor Houston, Aaron McVanner
 * @version 2017.05.30
 * 
 * @purpose This program installs the newest version of OpenWeasel sandboxed browser.
 * 
 */
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
using System.Management.Automation; // is used with powershell scripting

/* To do list
 * 
 * [] Create hyper-v mounting script
 * 
 */


namespace openweasel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //string zipPath = @"\iw.zip";
            
            
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //cancel button = button2
        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            Close();
        }
        // install openweasel and virtualbox check box
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        if (installowandvb.Checked == true)
            {
                extract.Checked = false;
                loadowintovb.Checked = false;
                cbInstallOpenWeaselHyperV.Checked = false;
            }
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
                // installs virtualbox and openweasel switchnum = 1
                if (installowandvb.Checked == true & loadowintovb.Checked == false & extract.Checked == false & cbInstallOpenWeaselHyperV.Checked == false)
                {
                    install.Enabled = true;
                    switchnum = 1;
                }
                else
                {
                    // loads OW into VirtualBox. switchnum is 2.
                    if (installowandvb.Checked == false & loadowintovb.Checked == true & extract.Checked == false & cbInstallOpenWeaselHyperV.Checked == false)
                    {
                        install.Enabled = true;
                        switchnum = 2;
                    }
                    else
                    {
                        // extracts OW vhd. switchnum is 3
                        if (installowandvb.Checked == false & loadowintovb.Checked == false & extract.Checked == true & cbInstallOpenWeaselHyperV.Checked == false)
                        {
                            install.Enabled = true;
                            switchnum = 3;
                        }
                        else
                        {
                            // installs OW into hyper-v. switchnum is 4
                            if (installowandvb.Checked == false & loadowintovb.Checked == false & extract.Checked == false & cbInstallOpenWeaselHyperV.Checked == true)
                            {
                                install.Enabled = true;
                                switchnum = 4;
                            }

                            else
                            {
                                Form2 frm = new Form2();
                                frm.Show();
                                Visible = false;
                            }

                        }
                    }
                }
            }  //ifswitchnum=0 bracket 
            if (switchnum == 1)
            {
                //install openweasel and virtualbox
                UseWaitCursor = true;
                backgroundWorker1.RunWorkerAsync();



            }
           else
            {
                if (switchnum == 2)
                {
                    UseWaitCursor = true;
                    backgroundWorker2.RunWorkerAsync();
                    //load openweasel into virtualbox
                    //call backgroundWorker2 skips virtualbox extraction and install.bat goes straight to installp2.bat
                    //after all extraction processes gets finished.
                }
                else
                {
                    if (switchnum == 3)
                    {
                        UseWaitCursor = true;
                        backgroundWorker3.RunWorkerAsync();
                        //extract virtualbox file (ova)
                        //call backgroundWorker3
                        // extracts IceWeasel Browserova.zip
                    }
                    else
                    {

                    }
                }
            }
                 
         }
        //backgroundWorker1 gets ran if user choses to install IceWeasel and VirtualBox
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
            // testing change this report progress back to 50
            backgroundWorker1.ReportProgress(50);
            ZipFile.ExtractToDirectory(@"switch.zip", extractPath);
            backgroundWorker1.ReportProgress(60);
            //ZipFile.ExtractToDirectory(@"installtest.zip", extractPath);
            //starts up install.bat
            System.Diagnostics.Process install = new System.Diagnostics.Process();
            install.StartInfo.WorkingDirectory = extractPath;
            install.StartInfo.FileName = "install.bat";
            install.Start();
            //System.Diagnostics.Process.Start(@"c:\oweasel\installtest.bat");
           // System.Diagnostics.Process.Start(@"c:\oweasel\install.bat");
            backgroundWorker1.ReportProgress(70);
            //starts installp2.bat process
            System.Diagnostics.Process installp2 = new System.Diagnostics.Process();
            installp2.StartInfo.WorkingDirectory = extractPath;
            installp2.StartInfo.FileName = "installp2.bat";
            installp2.Start();
            //System.Diagnostics.Process.Start(@"c:\oweasel\installp2.bat");
            backgroundWorker1.ReportProgress(80);
            System.Diagnostics.Process switchbat = new System.Diagnostics.Process();
            switchbat.StartInfo.WorkingDirectory = extractPath;
            switchbat.StartInfo.FileName = "switch.bat";
            switchbat.Start();
            //System.Diagnostics.Process.Start(@"c:\oweasel\switch.bat");
            backgroundWorker1.ReportProgress(90);
            backgroundWorker1.ReportProgress(100);

        }
        // backgroundWorker1 installs both virtualbox and openweasel
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
                            processlabel.Text = "Extracting Shortcut File:";
                        }
                        else
                        {
                            if (progressBar1.Value == 35)
                            {
                                processlabel.Text = "Extracting IceWeasel Batch File:";
                            }
                            else
                            {
                                if (progressBar1.Value == 40)
                                {
                                    processlabel.Text = "Extracting IceWeasel Icon File:";
                                }
                                else
                                {
                                    if (progressBar1.Value == 42)
                                    {
                                        processlabel.Text = "Extracting Install File:";
                                    }
                                    else
                                    {
                                        if (progressBar1.Value == 45)
                                        {
                                            processlabel.Text = "Extracting Install File #2:";
                                        }
                                        else
                                        {
                                            if (progressBar1.Value == 50)
                                            {
                                                processlabel.Text = "Extracting Switch:";
                                            }
                                            else
                                            {
                                                if (progressBar1.Value == 60)
                                                {
                                                    processlabel.Text = "Mounting IceWeasel:";
                                                }
                                                else
                                                {
                                                    if (progressBar1.Value == 70)
                                                    {
                                                        processlabel.Text = "Mounting IceWeasel:";

                                                    }
                                                    else
                                                    {
                                                        if (progressBar1.Value == 80)
                                                        {
                                                            processlabel.Text = "Mounting IceWeasel:";
                                                        }
                                                        else
                                                        {
                                                            if (progressBar1.Value == 90)
                                                            {
                                                                processlabel.Text = "Mounting IceWeasel:";
                                                          
                                                            }
                                                            else
                                                            {
                                                                if (progressBar1.Value == 100)
                                                                    processlabel.Text = "Installation complete:";
                                                                Form3 frm = new Form3();
                                                                frm.Show();
                                                                Visible = false;
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
            }
        }
        // backgroundWorker2 loads openweasel into virtualbox
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker1.ReportProgress(10);
            Directory.CreateDirectory(@"c:\oweaselsetup");
            string extractPath = @"c:\oweaselsetup";
            ZipFile.ExtractToDirectory(@"IceWeasel Browserova.zip", extractPath);
            backgroundWorker2.ReportProgress(25);


            //starts installp2.bat process
            System.Diagnostics.Process installp2 = new System.Diagnostics.Process();
            installp2.StartInfo.WorkingDirectory = extractPath;
            installp2.StartInfo.FileName = "installp2.bat";
            installp2.Start();
            backgroundWorker2.ReportProgress(80);
            System.Diagnostics.Process switchbat = new System.Diagnostics.Process();
            switchbat.StartInfo.WorkingDirectory = extractPath;
            switchbat.StartInfo.FileName = "switch.bat";
            switchbat.Start();
            backgroundWorker2.ReportProgress(100);
            // icon should be created
            //
            //

        }
        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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
        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            if (progressBar1.Value == 10)
            {
                processlabel.Text = "Creating Directory:";
            }
            else
            {
                if (progressBar1.Value == 25)
                {
                    processlabel.Text = "Extracting .ova to Destination:";
                }
                else
                {
                    if (progressBar1.Value == 80)
                    {
                        processlabel.Text = "Mounting OpenWeasel Virtual HD:";
                    }
                    else
                    {
                        if (progressBar1.Value == 100)
                        {
                            processlabel.Text = "OpenWeasel Virtual HD Mounted:";
                            Form3 frm = new Form3();
                            frm.Show();
                            Visible = false;
                        }
                    }
                }
            }
        }

        // backgroundWorker3 extracts the virtualbox ova file
        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker1.ReportProgress(10);
            Directory.CreateDirectory(@"c:\oweaselsetup");
            // user should be able to set extraction path?
            string extractPath = @"c:\oweaselsetup";
            backgroundWorker3.ReportProgress(25);
            ZipFile.ExtractToDirectory(@"IceWeasel Browserova.zip", extractPath);
            backgroundWorker3.ReportProgress(100);
        }
        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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
        private void backgroundWorker3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            if (progressBar1.Value == 10)
            {
                processlabel.Text = "Creating Directory:";
            }
            else
            {
                if (progressBar1.Value == 25)
                {
                    processlabel.Text = "Extracting .ova to Destination:";
                }
                else
                {
                    if (progressBar1.Value == 100)
                    {
                        processlabel.Text = "Extraction Complete:";
                        Form3 frm = new Form3();
                        frm.Show();
                        Visible = false;
                    }
                }
            }
        }
        // loadowintovb check box
        private void loadowintovb_CheckedChanged(object sender, EventArgs e)
        {
            if (loadowintovb.Checked == true)
            {
                installowandvb.Checked = false;
                extract.Checked = false;
                cbInstallOpenWeaselHyperV.Checked = false;
            }
            else
            {

            }
        }
        // extract ova checkbox change event
        private void extract_CheckedChanged(object sender, EventArgs e)
        {
            if (extract.Checked == true)
            {
                loadowintovb.Checked = false;
                installowandvb.Checked = false;
                cbInstallOpenWeaselHyperV.Checked = false;
            }
        }


        // cbInstallOpenWeaselHyperV changed event when checked.
        private void cbInstallOpenWeaselHyperV_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInstallOpenWeaselHyperV.Checked == true)
            {

                loadowintovb.Checked = false;
                installowandvb.Checked = false;
                extract.Checked = false;
            }
       }
   
    }
}
