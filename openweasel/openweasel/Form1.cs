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
    public partial class OpenWeasel : Form
    {
        public OpenWeasel()
        {
            InitializeComponent();
        }

        private void OpenWeasel_Load(object sender, EventArgs e)
        {

        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                {
                Form2 frm = new Form2();
                frm.Show();
                Visible = false;
            }
            else
            { button1.Enabled = false; }
        }
       
        
    }
}
