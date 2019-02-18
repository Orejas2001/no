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
    public partial class Form7 : Form
    {
        private Banco.Negocio.Banco mibanco;
        private int miusuario;
        public Form7(Banco.Negocio.Banco aux, int miusu)
        {
            InitializeComponent();
            mibanco = aux;
            miusuario = miusu;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            textBox1.Text = mibanco.MISC[miusuario].NO;
            textBox2.Text = mibanco.MISC[miusuario].ID.ToString();
            textBox3.Text = mibanco.MISC[miusuario].AH.SA.ToString();
            textBox4.Text = mibanco.MISC[miusuario].CO.SA.ToString();
            if (mibanco.MISC[miusuario].CD == null)
            {
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
            }
            else
            {
                textBox5.Text = mibanco.MISC[miusuario].CD.SA.ToString();
                textBox6.Text = mibanco.MISC[miusuario].CD.MI.M.ToString();
                textBox7.Text = mibanco.MISC[miusuario].CD.IN.ToString();
            }
            textBox9.Text = mibanco.MISC[miusuario].SA.ToString();
            textBox8.Text = mibanco.MISC[miusuario].CO.SO.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
