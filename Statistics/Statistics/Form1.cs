using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            statistics objStat = new statistics();
            objStat.numSet = txtInput.Text;
            txtMean.Text = objStat.calcMean().ToString("N2");
            txtVariance.Text = objStat.calcVariance().ToString("N2");
            txtStandardDeviation.Text = objStat.calcSD().ToString("N2");
        }
    }
}
