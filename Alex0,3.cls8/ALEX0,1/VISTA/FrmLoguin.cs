using ALEX0_1.DOMINIO;
using ALEX0_1.NEGOCIO;
using ALEX0_1.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALEX0_1
{
    public partial class FrmLoguin : Form
    {
        public FrmLoguin()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.User = TxtUser.Text;
            log.Password = TxtPass.Text;

            ClsLoguin clsL = new ClsLoguin();
            int Variabledeevalucion = clsL.acceso(log);
            if (Variabledeevalucion == 1)
            {
                MessageBox.Show("WELCOME");

                FrmMenu frm = new FrmMenu();
                frm.UsuarioEstado = TxtUser.Text;
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("FALSE");
            {
               


            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}