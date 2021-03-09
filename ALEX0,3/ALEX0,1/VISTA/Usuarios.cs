using ALEX0_1.MODEL;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ALEX0_1.VISTA
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {

            InitializeComponent();

             Carga();

        }


        void Carga()
        {


            using (programacionEntities db = new programacionEntities())
            {
                var Lista = db.UserList.ToList();
                
                foreach (var  iteracion in Lista)
                {
                    dataGridView1.Rows.Add(iteracion.Id,iteracion.NombreUsuario,iteracion.Apellido,iteracion.Edad,iteracion.Pass);
                }
            }

        }
    


        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                using (programacionEntities db = new programacionEntities())
                {

                    UserList userList = new UserList();


                    userList.NombreUsuario = TxtNombree.Text;
                    userList.Apellido = TxtApellido.Text;
                    userList.Edad = Convert.ToInt32(TxtEdad.Text);
                    userList.Pass = TxtContra.Text;

                    db.UserList.Add(userList);
                    db.SaveChanges();
                    MessageBox.Show("Save");

                }


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }

            Carga();

        }

        private void BtnBorrar_Click(object sender, EventArgs e)

        {

            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int Eliminar = Convert.ToInt32(TxtId.Text);

                    UserList userList = db.UserList.Where(x => x.Id == Eliminar).Select(x => x).FirstOrDefault();

                    ////  userList = db.UserList.Find(Eliminar);
                    db.UserList.Remove(userList);
                    db.SaveChanges();

                }


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            Carga();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try {
                using (programacionEntities db = new programacionEntities())
                {
                    int update = Convert.ToInt32(TxtId.Text);
                    UserList userList = db.UserList.Where(x => x.Id == update).Select(x => x).FirstOrDefault();

                    //userList user List = new userList();
                    //UserList = db.UserList.Find(16);

                    userList.NombreUsuario = TxtNombree.Text;
                    userList.Apellido = TxtApellido.Text;
                    userList.Edad = Convert.ToInt32(TxtEdad.Text);
                    userList.Pass = TxtContra.Text;
                    db.SaveChanges();
                }
            }
            catch(Exception ex) {

                MessageBox.Show(ex.ToString());
            }
            Carga();
        }
    }
}