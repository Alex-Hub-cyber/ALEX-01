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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        public String UsuarioEstado;
        private void FrmMenu_Load(object sender, EventArgs e)
        {
           Lbl1.Text = UsuarioEstado;
        }

        private void cLICKAQUIPARAMASINFORMACIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercade frm = new FrmAcercade();
            frm.MdiParent = this;
            frm.Show();
            
            
        }


        private void arreglosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaVisualdeUsuario frm = new FrmListaVisualdeUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void crudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones frm = new FrmOperaciones();
            frm.MdiParent = this;
            frm.BtnResta.Enabled = false;

            frm.Show();
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones frm = new FrmOperaciones();
            frm.MdiParent = this;
            frm.BtnSuma.Enabled = false;

            frm.Show();
        }

        private void conexiónesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
