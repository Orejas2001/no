using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Negocio
{
    [Serializable]
    public class Mes
    {
        private short numero;
        public Mes()
        {
            numero = 1;
        }
        public short M
        {
            get { return numero; }
        }
        public void aumentar()
        {
            numero++;
        }
    }
}
