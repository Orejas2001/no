using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Negocio
{
    [Serializable]
    public class Corriente:Producto
    {
        private float sobregiro;
        public Corriente()
        {
            sobregiro = 0;
        }
        public float SO
        {
            set { sobregiro = value; }
            get { return sobregiro; }
        }
        public void sobregirar (float monto)
        {
            sobregiro -= monto;

        }
        public void actualizar(float valor)
        {
            saldo += valor;
        }
    }
}
