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

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void cLICKAQUIPARAMASINFORMACIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercade frm = new FrmAcercade();
            frm.MdiParent = this;
            frm.Show();
        }   
    }
}
