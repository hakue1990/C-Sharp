using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrlenLaboratorium
{
    public partial class gazySuche : Form
    {
        public gazySuche()
        {
            InitializeComponent();
        }
        double operand1, operand2, operand3, operand4, operand5, result;
        public void Oblicz()
        {
            operand1 = Convert.ToDouble(textBox1.Text);
            operand2 = Convert.ToDouble(textBox2.Text);
            operand3 = Convert.ToDouble(textBox3.Text);
            operand4 = Convert.ToDouble(textBox4.Text);
            operand5 = Convert.ToDouble(textBox5.Text);

            result = (operand2 * 0.01 * 31.18 * operand3 * 1000 * (operand4 + 273) / (operand1 * (operand5 - (operand5 / operand4))));
            textBox6.Text = result.ToString();
        }
        private void btnOblicz_Click_1(object sender, EventArgs e)
        {
            Oblicz();
        }
    }
}
