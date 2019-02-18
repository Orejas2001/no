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
    public partial class Form1 : Form
    {
        private Negocio.Banco mibanco;
        private short intentos;
        bool sw;
        public Form1()
        {
            intentos = 1;
            mibanco= new Negocio.Banco();
            InitializeComponent();
            try
            {
                mibanco = ArchivoPlano.read("prueba.dat");
            }
            catch
            {
                mibanco = new Negocio.Banco(); 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArchivoPlano.write("prueba.dat", mibanco);
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             sw = false;
            try
            {
                if (intentos >= 3)
                {
                    MessageBox.Show("Se han agotado su número de intentos. Hasta pronto.", "Mensaje de salida", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }
                else
                {

                    if (long.Parse(textBox2.Text) < 0)
                    {
                        MessageBox.Show("El password no puede ser negativo. Ojo que lleva " + intentos + " intento(s).", "Mensaje de salida.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Text = "";
                        intentos++;
                    }
                    else
                    {
                        if (textBox1.Text == mibanco.MIAD.lO && long.Parse(textBox2.Text) == mibanco.MIAD.PA)
                        {
                            sw = true;
                            intentos = 1;
                            MessageBox.Show("Bienvenido señor administrador.", "Mensaje de bienvenida.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Form mimenu = new Form8(mibanco, -1, this);
                            mimenu.ShowDialog();

                        }
                        else
                        {
                            for (int i = 0; i < mibanco.MISC.Count; i++)
                            {
                                if (textBox1.Text == mibanco.MISC[i].lO && long.Parse(textBox2.Text) == mibanco.MISC[i].PA)
                                {
                                    sw = true;
                                    intentos = 1;
                                    MessageBox.Show("Bienvenido señor/a. " + mibanco.MISC[i].lO, "Mensaje de bienvenida.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();
                                    Form mimenu = new Form8(mibanco, i, this);
                                    mimenu.ShowDialog();

                                }
                            }
                        }
                        if (sw == false)
                        {
                            MessageBox.Show("El login y el password son inválidos, intentelo de nuevo. Ojo que lleva " + intentos + " intento(s).", "Mensaje de salida.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Text = "";
                            textBox2.Text = "";
                            intentos++;
                        }
                    }
                }
            }
            catch (SystemException error1)
            {
                MessageBox.Show("El password no puede ser alfanumérico. Ojo que lleva " + intentos + " intento(s)." + error1.Message, "Mensaje de salida.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBox2.Text = "";
                intentos++;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
