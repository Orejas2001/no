using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form4 : Form
    {
        private Negocio.Banco mibanco;
        

        public Form4(Negocio.Banco aux)
        {
            InitializeComponent();
            mibanco = aux;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < mibanco.MISC.Count; i++)
                comboBox1.Items.Add(mibanco.MISC[i].ID.ToString());
           

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            textBox2.Text = mibanco.MISC[comboBox1.SelectedIndex].NO;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (float.Parse(textBox3.Text) <= 0 || float.Parse(textBox5.Text) <= 0 || float.Parse(textBox5.Text) >= 15)
                {
                    MessageBox.Show("El monto y/o el interés deben ser positivo y el interés no superior a 15%. Inténtelo de nuevo.", "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Text = "";
                    textBox5.Text = "";
                }
                else
                {
                    mibanco.MISC[comboBox1.SelectedIndex].crearcdt();
                    mibanco.MISC[comboBox1.SelectedIndex].CD.SA = float.Parse(textBox3.Text);
                    mibanco.MISC[comboBox1.SelectedIndex].CD.IN = (float.Parse(textBox5.Text) / 100);
                    mibanco.actualizar(float.Parse(textBox3.Text));
                    mibanco.MISC[comboBox1.SelectedIndex].actualizar(float.Parse(textBox3.Text));
                    MessageBox.Show("El CDT fue creado satisfactoriamente.", "Mensaje de salida.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose(true);
                }

            }
            catch (SystemException error1){
                MessageBox.Show("Los intereses y el monto deben ser numéricos."+error1.Message, "Mensaje de error");
                textBox3.Text = "";
                textBox5.Text = "";
            }
        }
    }
}
