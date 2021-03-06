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
    
        public int acceso(Login log)
        {
            int estado = 0;
            if (log.User.Equals("Alex")&& log.Password.Equals("123")) {
                estado = 1;
            }
            return estado ;
        }
    }
}
