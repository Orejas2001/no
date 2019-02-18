using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Negocio
{
    [Serializable]
    public class Ahorro:Producto
    {
        private float interes;
        public Ahorro()
        {
            interes = (float) 0.006;
        }

        public void pagarinter()
        {
           saldo+= saldo* interes ;
        }

    }
}
