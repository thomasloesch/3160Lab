using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile = new StreamWriter("data.txt");

            Double pay = CalcPay(txtBxHours.Text, txtBxRate.Text);

            String outputString = txtBxName.Text + ", " + txtBxNumber.Text + ", " + pay;

            outputFile.Write(outputString);

            outputFile.Close();
        }

        private Double CalcPay(string _hours, string _rate)
        {
            double hours = Double.Parse(_hours),
                   rate = Double.Parse(_rate),
                   retval;

            if(hours < 40)
            {
                retval = hours * rate;
            }
            else
            {
                retval = 40 * rate;
                retval = retval + (hours - 40) * rate;
            }

            return retval;
        }
    }
}
