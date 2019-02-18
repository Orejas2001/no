using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Negocio
{
    [Serializable]
    public class Banco
    {
       private const long NIT = 666333999;
       private const string NOMBRE = "Banco Distrital";
       private double saldo;
       private List<Cliente> misclientes;
       private Mes misimulacion;
       private Administrador miadmin;
       public Banco()

        {
            miadmin = new Administrador();
            miadmin.cambiar("JulianEscamilla", 1015480605);
            misimulacion = new Mes();
            misclientes = new List<Cliente>();
            saldo = 500000000;
        }
        public Administrador MIAD
        {
            set { miadmin = value; }
            get { return miadmin; }
        }
        public Mes MS
        {
            get { return misimulacion; }
        }
        public List<Cliente> MISC
        {
            set { misclientes = value; }
            get { return misclientes; }
        }
        public long NI
        {
            get { return NIT; }
        }
        public string NOM
        {
            get { return NOMBRE; }
        }

        public double SA
        {
            set { saldo = value; }
           get { return saldo; }
        }
        public void actualizar(float valor)
        {
           saldo += valor;
        }
    }
}
