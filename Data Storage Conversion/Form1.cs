using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Storage_Conversion
{
    public partial class frmDataStorageConversion : Form
    {
        public frmDataStorageConversion()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //variables to manipulate
            double output = Int32.Parse(txtInput.Text);
            //convert from byte to byte
            if (rbFromByte.Checked)
            {
                output = output;
            }
            //convert from kilobit to byte
            else if (rbFromKilobit.Checked)
            {
                output = output * 1024;
            }
            //convert from megabit to byte
            else if (rbFromMegabit.Checked)
            {
                output = output * Math.Pow(1024, 2);
            }
            //convert from gigabit to byte
            else if (rbFromGigabit.Checked)
            {
                output = output * Math.Pow(1024, 3);
            }
            //convert from terabit to byte
            else if (rbFromTerabit.Checked)
            {
                output = output * Math.Pow(1024, 4);
            }

            //convert from byte to byte
            if (rbToByte.Checked)
            {
                output = output;
            }
            //convert from kilobit to byte
            else if (rbToKilobit.Checked)
            {
                output /= Math.Pow(1024, 1);
            }
            //convert from megabit to byte
            else if (rbToMegabit.Checked)
            {
                output /= Math.Pow(1024, 2);
            }
            //convert from gigabit to byte
            else if (rbToGigabit.Checked)
            {
                output /= Math.Pow(1024, 3);
            }
            //convert from terabit to byte
            else if (rbToTerabit.Checked)
            {
                output /= Math.Pow(1024, 4);
            }

            //set the txtOutput textbox to formatted input
            txtOutput.Text = output.ToString("0.00E0");
        }
    }
}
