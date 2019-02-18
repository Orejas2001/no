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
    public partial class Form2 : Form
    {
        private Negocio.Banco mibanco;
        private int usuario;
        public Form2(Negocio.Banco aux, int usu)
        {
            InitializeComponent();
            mibanco = aux;
            usuario = usu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usuario == -1)
            {
                try
                {
                    if (long.Parse(textBox1.Text) == mibanco.MIAD.PA && long.Parse(textBox2.Text) == long.Parse(textBox3.Text) && long.Parse(textBox1.Text) != long.Parse(textBox3.Text))
                    {
                        mibanco.MIAD.PA = long.Parse(textBox2.Text);
                        MessageBox.Show("El password ha sido actualizado.", "Mensaje de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose(true);
                    }
                    else
                    {
                        MessageBox.Show("El dato o alguno de los datos no son compatibles, vuelva a intentarlo.", "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Dispose(true);
                    }
                }
                catch (SystemException e1)
        
                {
                    MessageBox.Show("El password no puede ser alfanumérico." + e1.Message, " Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";


                }
            }
            else
            {
                try
                {
                    if (long.Parse(textBox1.Text) == mibanco.MISC[usuario].PA && long.Parse(textBox2.Text) == long.Parse(textBox3.Text) && long.Parse(textBox1.Text) != long.Parse(textBox3.Text))
                    {
                        mibanco.MISC[usuario].PA = long.Parse(textBox2.Text);
                        MessageBox.Show("El password ha sido actualizado.", "Mensaje de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose(true);
                    }
                    else
                    {
                        MessageBox.Show("El dato o alguno de los datos no son compatibles, vuelva a intentarlo.", "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Dispose(true);
                    }
                }

                catch (SystemException e1)

                {
                    MessageBox.Show("El password no puede ser alfanumérico " + e1.Message, " Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";

                }
            }
            }
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
        }
        
        }
   
}
