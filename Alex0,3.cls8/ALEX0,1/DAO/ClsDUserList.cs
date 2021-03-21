using ALEX0_1.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALEX0_1.DAO
{
    class ClsDUserList
    {
        public List<UserList> cargardatosUserList()
        {
            List<UserList> Lista;
            using (programacionEntities db = new programacionEntities())
            {

                Lista = db.UserList.ToList();


            }


            return Lista;

        }
        public void SaverDatosUser(UserList user)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {

                    UserList userList = new UserList();


                    userList.NombreUsuario = user.NombreUsuario;
                    userList.Apellido = user.Apellido;
                    userList.Edad = user.Edad;
                    userList.Pass = user.Pass;

                    db.UserList.Add(userList);
                    db.SaveChanges();
                    MessageBox.Show("Save");

                }
            }




            catch(Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        public void deleteuser(int iD)
           
        {
            try 
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int Eliminar = Convert.ToInt32(iD);

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
            }

        private static void updateUser1(UserList user)
        {

            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int update = Convert.ToInt32(user.Id);
                    UserList userList = db.UserList.Where(x => x.Id == update).Select(x => x).FirstOrDefault();

                    //userList user List = new userList();
                    //UserList = db.UserList.Find(16);


                    userList.NombreUsuario = user.NombreUsuario;
                    userList.Apellido = user.Apellido;
                    userList.Edad = user.Edad;
                    userList.Pass = user.Pass;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        internal void updateUser(UserList userList)
        {
            throw new NotImplementedException();
        }
    }
}
//public void SaverDatosUser(String Nombre, String Apellido, int Edad, String Pass)
//{

//    {
//        using (programacionEntities db = new programacionEntities())
//        {

//            UserList userList = new UserList();


//            userList.NombreUsuario = Nombre;
//            userList.Apellido = Apellido;
//            userList.Edad = Edad;
//            userList.Pass = Pass;

//            db.UserList.Add(userList);
//            db.SaveChanges();
//            MessageBox.Show("Save");

//        }




//        }
//}