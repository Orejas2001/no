using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Negocio
{
    [Serializable]
    public class Cdt:Producto
    {
        private float interes;
        private Mes mimes;
        public Cdt()
        {
            interes = 0;
            mimes = new Mes();
        }
        public float IN
        {
            set { interes = value; }
            get { return interes; }
        }
        public float liquidar()
        {
            return (saldo + saldo * interes * mimes.M);
        }
        public Mes MI
        {
            set { mimes = value; }
            get { return mimes; }
        }
    }

}
