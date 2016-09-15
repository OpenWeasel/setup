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
                progressBar1.Value = 50;
                install.Enabled = false;
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


    }
}
