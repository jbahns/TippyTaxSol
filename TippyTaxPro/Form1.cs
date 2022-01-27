using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TippyTaxPro
{
    public partial class Form1 : Form
    {
        private decimal subtotal, tipRate, tipAmt, taxRate, taxAmt, total;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            subtotal = Convert.ToDecimal(txtSubtotal.Text);
            tipRate = Convert.ToDecimal(comboTipRate.Text);
            taxRate = 6m;

            tipAmt = subtotal * (tipRate / 100);
            taxAmt = subtotal * (taxRate / 100);
            total = subtotal + tipAmt + taxAmt;

            txtTipAmt.Text = tipAmt.ToString("c");
            txtTaxAmt.Text = taxAmt.ToString("c");
            txtTotal.Text = total.ToString("c");
            txtTaxRate.Text = (taxRate/100).ToString("p1");
            comboTipRate.Text = (tipRate / 100).ToString("p1");

            txtSubtotal.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
