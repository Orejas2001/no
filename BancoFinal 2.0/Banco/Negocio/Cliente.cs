using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Negocio
{
    [Serializable]
    public class Cliente : Acceso
    {
        private long id;
        private string nombre;
        private double saldo;
        private Cdt micdt;
        private Ahorro miahorro;
        private Corriente micorriente;
        public Cliente()
        {
            miahorro = new Ahorro();
            micorriente = new Corriente();
            saldo = 0;
            nombre = "";
            id = 0;
        }

        public void crearcdt()
        {
            micdt = new Cdt();
        }
        public void elimarcdt()
        {
            micdt = null;
        }
        public string NO
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public long ID
        {
            set { id= value; }
            get { return id; }
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
        public Ahorro AH
        {
            set { miahorro = value; }
            get { return miahorro; }
        }
        public Corriente CO
        {
            set { micorriente = value; }
            get { return micorriente; }
        }
        public Cdt CD
        {
            set { micdt = value; }
            get { return micdt; }
        }
       

    }
}
