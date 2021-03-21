using ALEX0_1.DAO;
using ALEX0_1.MODEL;
using System;
using System.Collections.Generic;
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
            Clear();


        }
        void Clear()
        {
            TxtId.Clear();
            TxtNombree.Clear();
            TxtApellido.Clear();
            TxtEdad.Clear();
            TxtContra.Clear();




        }





        void Carga()
        {
            dtgListaUsuarios.Rows.Clear();

            ClsDUserList clsDUserList = new ClsDUserList();

            List<UserList> Lista = clsDUserList.cargardatosUserList();


            foreach (var iteracion in Lista)
            {
                dtgListaUsuarios.Rows.Add(iteracion.Id, iteracion.NombreUsuario, iteracion.Apellido, iteracion.Edad, iteracion.Pass);
            }


        }



        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtId.Text.Equals(""))
            {
                ClsDUserList clsDUserList = new ClsDUserList();
                //clsDUserList.SaverDatosUser(TxtNombree.Text,TxtApellido.Text,Convert.ToInt32 (TxtEdad.Text),TxtContra.Text );

                UserList userList = new UserList();
                userList.NombreUsuario = TxtNombree.Text;
                userList.Apellido = TxtApellido.Text;
                userList.Edad = Convert.ToInt32(TxtEdad.Text);
                userList.Pass = TxtContra.Text;
                clsDUserList.SaverDatosUser(userList);

            }
            else
            {
                ClsDUserList clsDUserList = new ClsDUserList();



                UserList userList = new UserList();
                userList.Id = Convert.ToInt32(TxtId.Text);
                userList.NombreUsuario = TxtNombree.Text;
                userList.Apellido = TxtApellido.Text;
                userList.Edad = Convert.ToInt32(TxtEdad.Text);
                userList.Pass = TxtContra.Text;
                clsDUserList.updateUser(userList);
            }
                Carga();
                Clear();
            }
        
    

        private void BtnBorrar_Click(object sender, EventArgs e)

        {
            ClsDUserList user = new ClsDUserList();
            user.deleteuser(Convert.ToInt32(TxtId.Text));
         
            Carga();
            Clear();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        
            Carga();
            Clear();
        }

        private void dtgListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgListaUsuarios.CurrentRow.Cells[0].Value.ToString();
            String Nombree = dtgListaUsuarios.CurrentRow.Cells[1].Value.ToString();
            String Apellido = dtgListaUsuarios.CurrentRow.Cells[2].Value.ToString();
            String Edad = dtgListaUsuarios.CurrentRow.Cells[3].Value.ToString();
            String Contra = dtgListaUsuarios.CurrentRow.Cells[4].Value.ToString();

            TxtId.Text = Id;
            TxtNombree.Text = Nombree;
            TxtApellido.Text = Apellido;
            TxtEdad.Text = Edad;
            TxtContra.Text  = Contra;


        }
    }
}