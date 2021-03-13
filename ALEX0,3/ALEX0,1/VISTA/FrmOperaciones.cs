using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALEX0_1.VISTA
{
    public partial class FrmOperaciones : Form
    {
        public FrmOperaciones()
        {
            InitializeComponent();
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {

            try
            {
                
                int suma;
                suma = Convert.ToInt32(TxtDATO1.Text) + Convert.ToInt32(TxtDATO2.Text);

                TxtResultado.Text = suma.ToString();

            }
            catch (Exception ex ) {

                MessageBox.Show("Hola tus datos no son no correctos Revisa  " );
            
            }
            //TxtResultado.Text = TxtDATO1.Text + TxtDATO2.Text;
        }
        }

    } 