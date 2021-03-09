using ALEX0_1.DAO;
using ALEX0_1.DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALEX0_1.NEGOCIO
{
    class ClsLoguin
    {
        ClsListaUsuario cls = new ClsListaUsuario(); 
        public int acceso(Login log)
        {
            int estado = 0;
            for (int i = 0; i < cls.User.Length; i++) {
                if (log.User.Equals(cls.User[i]) && log.Password.Equals(cls.Password[i])) {
                    estado = 1;
                }
            }
            return estado ;
        }
    }
}
