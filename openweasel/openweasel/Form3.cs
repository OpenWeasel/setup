using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openweasel
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            string extractPath = @"c:\oweaselsetup";
            System.Diagnostics.Process ice = new System.Diagnostics.Process();
            ice.StartInfo.FileName = "IceWeasel.bat";
            ice.StartInfo.WorkingDirectory = extractPath;
           // System.Diagnostics.Process.Start(@"c:\oweasel\IceWeasel.bat");
        }
    }
}
