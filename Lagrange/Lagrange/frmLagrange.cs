using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagrange
{
    public partial class frmLagrange : Form
    {
        public frmLagrange()
        {
            InitializeComponent();
        }

        private void bttnCalculate_Click(object sender, EventArgs e)
        {
            double x, x0, fx0, x1, fx1, res;
            x = Convert.ToDouble(txtx.Text);
            x0 = Convert.ToDouble(txtx0.Text);
            fx0 = Convert.ToDouble(txtfx0.Text);
            x1 = Convert.ToDouble(txtx1.Text);
            fx1 = Convert.ToDouble(txtfx1.Text);

            res = ((x - x1) / (x0 - x1)) * fx0 + ((x - x0) / (x1 - x0)) * fx1;

            txtRes.Text = res.ToString();
        }
    }
}
