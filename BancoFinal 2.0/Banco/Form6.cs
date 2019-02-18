using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Negocio;

namespace Banco
{
    public partial class Form6 : Form
    {
        private Negocio.Banco mibanco;
        public Form6(Negocio.Banco aux)
        {
            InitializeComponent();
            mibanco = aux;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)

        {
            double monto = 0; short mes = 0;float interes = 0;
            textBox1.Text = mibanco.SA.ToString();
            for (int i = 0; i < mibanco.MISC.Count; i++)

            {
                if (mibanco.MISC[i].CD == null) {
                    monto = 0;
                    mes = 0;
                    interes = 0;

                }
                else{
                    monto = mibanco.MISC[i].CD.SA;
                    interes = mibanco.MISC[i].CD.IN;
                    mes = mibanco.MISC[i].CD.MI.M;

                }
                    string[] misdatos = new string[] { mibanco.MISC[i].ID.ToString(), mibanco.MISC[i].NO, mibanco.MISC[i].AH.SA.ToString(), mibanco.MISC[i].CO.SA.ToString(), monto.ToString(), interes.ToString(), mes.ToString(), mibanco.MISC[i].CO.SO.ToString(), mibanco.MISC[i].SA.ToString() };
                
                ListViewItem mifila = new ListViewItem(misdatos);
                listView1.Items.Add(mifila);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
