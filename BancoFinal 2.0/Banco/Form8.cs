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
    public partial class Form8 : Form
    {
        private Negocio.Banco mibanco;
        private int usuario;
        private Form1 mimenu;
        public Form8(Negocio.Banco aux, int usua, Form1 menu)
        {

            InitializeComponent();
            button1.Visible = false; 
            mibanco = aux;
            usuario = usua;
            mimenu = menu;
            label3.Text = mibanco.NOM + "\n" + mibanco.NI;
            textBox2.Text = mibanco.MS.M.ToString();
            if (usuario == -1)
                administradorToolStripMenuItem.Enabled = true;
            else
            {
                clienteBancoToolStripMenuItem.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form miregistro = new Form5(mibanco);
            miregistro.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mimenu.Show();
            this.Dispose(true);
            mimenu.textBox1.Clear();
            mimenu.textBox2.Clear();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void zonaTransaccionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mistransacciones = new Form3(mibanco, usuario);
            mistransacciones.ShowDialog();
        }

        private void crearCDTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form micdt = new Form4(mibanco);
            micdt.ShowDialog();
        }

        private void avanzar1MesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mibanco.MS.aumentar();
            textBox2.Text = mibanco.MS.M.ToString();
            for (int i = 0; i < mibanco.MISC.Count; i++)
            {
                if (mibanco.MISC[i].CD != null)
                    mibanco.MISC[i].CD.MI.aumentar();
                float intereses = mibanco.MISC[i].AH.SA;
                mibanco.MISC[i].AH.pagarinter();
                intereses = mibanco.MISC[i].AH.SA - intereses;
                mibanco.actualizar(-intereses);


            }
        }

        /*private void button3_Click(object sender, EventArgs e)
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
                            if (mibanco.MISC[i].AH.SA == 0 && mibanco.MISC[i].CO.SA == 0 && mibanco.MISC[i].CO.SO == 0 && mibanco.MISC[i].CD == null)
                            {
                                DialogResult res = MessageBox.Show("El cliente existe en el banco y se puede eliminar. ¿Desea eliminarlo? (SI/NO)", "Mensaje de confirmación.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (DialogResult.Yes == res)
                                {
                                    mibanco.MISC.Remove(mibanco.MISC[i]);
                                    textBox1.Visible = false;
                                    button1.Visible = false;
                                    label1.Visible = false;
                                    break;
                                }

                            }
                        }

                    }
               
                    if (sw == false)
                    {
                        MessageBox.Show("El cliente no existe en el banco, inténtelo de nuevo.", "Mensaje de salida.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Visible = false;
                        button1.Visible = false;
                        label1.Visible = false;
                    }
                }
               
            }
            catch (SystemException error1)
            {
                MessageBox.Show("La identificación no puede ser alfanumérico." + error1.Message, "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBox1.Text = "";
               
            }
        }
        */

        private void reporteClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form reporcli = new Form7(mibanco,usuario);
            reporcli.ShowDialog();
        }

        private void reporteGeneralDelBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mireporte= new Form6(mibanco);
            mireporte.ShowDialog();
        }

        private void actualizarPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form micambio=new Form2(mibanco, -1);
            micambio.ShowDialog();
        }

        private void actualizarPasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form micambio = new Form2(mibanco, usuario);
            micambio.ShowDialog();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            button1.Visible = true;
            textBox1.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool sw = false;
            try
            {
                if (long.Parse(textBox1.Text) < 100000)
                {
                    MessageBox.Show("La identificación no puede ser negativa ni menor a 6 digitos. ", "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBox1.Visible = false;
                    button1.Visible = false;
                    label1.Visible = false;
                }
                else
                {
                    for (int i = 0; i < mibanco.MISC.Count; i++)
                    {
                        if (mibanco.MISC[i].ID == long.Parse(textBox1.Text))
                        {
                            sw = true;

                            if (mibanco.MISC[i].CO.SO * (-1) == mibanco.MISC[i].CO.SA)
                            {

                                 if (mibanco.MISC[i].AH.SA == 0 && mibanco.MISC[i].CO.SA == 0 && mibanco.MISC[i].CO.SO == 0 && mibanco.MISC[i].CD == null)
                                {
                                    DialogResult res = MessageBox.Show("El cliente existe en el banco y se puede eliminar. ¿Desea eliminarlo? (SI/NO)", "Mensaje de confirmación.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (DialogResult.Yes == res)
                                    {
                                        mibanco.MISC.Remove(mibanco.MISC[i]);
                                        textBox1.Visible = false;
                                        button1.Visible = false;
                                        label1.Visible = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El cliente no se puede elimnar, inténtelo de nuevo.", "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    textBox1.Visible = false;
                                    button1.Visible = false;
                                    label1.Visible = false;
                                }
                            }

                            else
                            {
                                MessageBox.Show("Tiene que pagar el saldo del sobregiro, por favor realice una consignación en la cuenta corriente.", "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                textBox1.Visible = false;
                                button1.Visible = false;
                                label1.Visible = false;
                            }
                        }
                        sw = false;
                        if (sw ==false)
                        {
                            MessageBox.Show("El cliente no existe en el banco, inténtelo de nuevo.", "Mensaje de salida.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Visible = false;
                            button1.Visible = false;
                            label1.Visible = false;
                            textBox1.Text = " ";
                        }
                    }
                }

            }

            catch (SystemException error1)
            {
                MessageBox.Show("La identificación no puede ser alfanumérico." + error1.Message, "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBox1.Text = "";

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool sw = false;
            try
            {
                if (long.Parse(textBox1.Text) < 100000)
                {
                    MessageBox.Show("La identificación no puede ser negativa ni menor a 6 digitos. ", "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBox1.Visible = false;
                    button1.Visible = false;
                    label1.Visible = false;
                }
                else
                {
                    for (int i = 0; i < mibanco.MISC.Count; i++)
                    {
                        if (mibanco.MISC[i].ID == long.Parse(textBox1.Text))
                        {
                            sw = true;

                            if (mibanco.MISC[i].CO.SO * (-1) == mibanco.MISC[i].CO.SA)
                            {

                                if (mibanco.MISC[i].AH.SA == 0 && mibanco.MISC[i].CO.SA == 0 && mibanco.MISC[i].CO.SO == 0 && mibanco.MISC[i].CD == null)
                                {
                                    DialogResult res = MessageBox.Show("El cliente existe en el banco y se puede eliminar. ¿Desea eliminarlo? (SI/NO)", "Mensaje de confirmación.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (DialogResult.Yes == res)
                                    {
                                        mibanco.MISC.Remove(mibanco.MISC[i]);
                                        textBox1.Visible = false;
                                        button1.Visible = false;
                                        label1.Visible = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El cliente no se puede elimnar, inténtelo de nuevo.", "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    textBox1.Visible = false;
                                    button1.Visible = false;
                                    label1.Visible = false;
                                }
                            }

                            else
                            {
                                MessageBox.Show("Tiene que pagar el saldo del sobregiro, por favor realice una consignación en la cuenta corriente.", "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                textBox1.Visible = false;
                                button1.Visible = false;
                                label1.Visible = false;
                            }
                        }
                        sw = false;
                        if (sw = false)
                        {
                            MessageBox.Show("El cliente no existe en el banco, inténtelo de nuevo.", "Mensaje de salida.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Visible = false;
                            button1.Visible = false;
                            label1.Visible = false;
                            textBox1.Text = " ";
                        }
                    }
                }

            }

            catch (SystemException error1)
            {
                MessageBox.Show("La identificación no puede ser alfanumérico." + error1.Message, "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBox1.Text = "";

            }
        }
    }
    }


