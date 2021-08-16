using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraDeSomar
{
    public partial class frmAdicao : Form
    {
        public frmAdicao()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
           

            lblRes.Text = Convert.ToString(int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text));
        }

        private void frmAdicao_Load(object sender, EventArgs e)
        {
            lblRes.Text = "";
        }
    }
}
