using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTriangulo
{
    public partial class lblAreadoTriangulo : Form
    {
        public lblAreadoTriangulo()
        {
            InitializeComponent();
        }

        private void lblBase_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                double v1;
                double v2;
                double resultado;

                if (txtBase.Text != "" && txtAltura.Text != "")
                {
                    v1 = double.Parse(txtBase.Text);
                    v2 = double.Parse(txtAltura.Text);

                    resultado = (double)v1 * (double)v2 / 2;
                    lblResultado.Text = resultado.ToString();
                }


            }
        }
    }
}
