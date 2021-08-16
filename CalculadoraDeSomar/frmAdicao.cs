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

        private void btnSOMAR_Click(object sender, EventArgs e)
        {
            if (txtSomar1.Text == "" || txtSomar2.Text == "")
                MessageBox.Show("Favor, preencher todos os campos!");
            else
            {
                int N1 = int.Parse(txtSomar1.Text);
                int N2 = int.Parse(txtSomar2.Text);

                int result = N1 + N2;
                lblResultado.Text = result.ToString();
            }
        }
    }
}
