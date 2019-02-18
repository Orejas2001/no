using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Negocio
{
    [Serializable]
    public class Producto
    {
        protected float saldo;
        public Producto()
        {
            saldo = 0;
        }
        public void consignar(int consignacion)
        {
            saldo += consignacion;
        }
        public void retirar(int retiro)
        {
            saldo -= retiro;
        }
        public float SA
        {
            set { saldo = value; }
            get { return saldo; }
        }

    }
}
