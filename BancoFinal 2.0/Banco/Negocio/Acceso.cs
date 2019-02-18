using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Negocio
{
    [Serializable]
    public class Acceso
    {
        protected string login;
        protected long password;
        public Acceso()
        {
            login = "";
            password = 0;
        }
        public string lO
        {
            set { login = value; }
            get { return login; }
        }
        public long PA
        {
            set { password = value; }
            get { return password; }
        }
        public void cambiar (string log, long id)
        {
            login = log;
            password = id;
        } 
    }
}
