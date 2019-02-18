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
    public partial class Form5 : Form
    {
        private Negocio.Banco mibanco; 
        public Form5(Negocio.Banco aux)
        {
            InitializeComponent();
            mibanco = aux;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose(true);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente micliente = new Cliente();
            micliente.ID = long.Parse(textBox1.Text);
            if (textBox2.Text == "")
            {
                MessageBox.Show("El nombre del cliente no puede quedar vacio. ", "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                micliente.NO = textBox2.Text;
                micliente.cambiar(textBox2.Text, long.Parse(textBox1.Text));
                mibanco.MISC.Add(micliente);
                MessageBox.Show("Cliente registrado en el Banco. ", "Mensaje de confirmación.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose(true);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool sw = false;
            try
            {
                if (long.Parse(textBox1.Text) < 100000)
                {
                    MessageBox.Show("La identificación no puede ser negativa ni menor a 6 digitos. ", "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBox1.Text = "";
                }
                else
                {
                    for (int i = 0; i < mibanco.MISC.Count; i++)
                    {
                        if (mibanco.MISC[i].ID == long.Parse(textBox1.Text))
                        {
                            sw = true;
                            MessageBox.Show("El cliente ya se encuentra regitrado en el sistema. Inténtelo de nuevo.", "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBox1.Text = "";
                            break;
                        }
                    }

                    if (sw == false)
                    {
                        MessageBox.Show("El cliente es nuevo, por favor registre los demás datos. ", "Mensaje de salida.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        button4.Enabled = false;
                        button1.Enabled = false;
                        button2.Enabled = true;
                    }
                }
            }
            catch (SystemException error1)
            {
                MessageBox.Show("La identificación no puede ser alfanumérico." + error1.Message, "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBox1.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool sw = false;
            try
            {
                if (long.Parse(textBox1.Text) < 100000)
                {
                    MessageBox.Show("La identificación no puede ser negativa ni menor a 6 digitos. ", "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBox1.Text = "";
                }
                else
                {
                    for (int i = 0; i < mibanco.MISC.Count; i++)
                    {
                        if (mibanco.MISC[i].ID == long.Parse(textBox1.Text))
                        {
                            sw = true;
                            MessageBox.Show("El cliente ya se encuentra registrado en el sistema. Inténtelo de nuevo.", "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBox1.Text = "";
                            break;
                        }
                    }

                    if (sw == false)
                    {
                        MessageBox.Show("El cliente es nuevo, por favor registre los demás datos. ", "Mensaje de salida.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Enabled = false;
                        button4.Enabled = false;
                
                        button2.Enabled = true;
                        textBox2.Enabled = true;
                    }
                }
            }
            catch (SystemException error1)
            {
                MessageBox.Show("La identificación no puede ser alfanumérico." + error1.Message, "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
