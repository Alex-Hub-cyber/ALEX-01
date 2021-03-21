using ALEX0_1.DAO;
using System;
using System.Windows.Forms;

namespace ALEX0_1.VISTA
{
    public partial class FrmListaVisualdeUsuario : Form
    {
        public FrmListaVisualdeUsuario()
        {
            InitializeComponent();
        }

        private void FrmListaVisualdeUsuario_Load(object sender, EventArgs e)
        {
            ClsListaUsuario cls = new ClsListaUsuario();
            foreach (var iteracion in cls.User)
            {
                dataGridView1.Rows.Add(iteracion,ToString());

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
