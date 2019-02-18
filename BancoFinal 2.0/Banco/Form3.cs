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
    public partial class Form3 : Form
    {


        private Negocio.Banco mibanco;
        private int usuario;
        public Form3(Negocio.Banco aux, int usu)
        {
            InitializeComponent();
            mibanco = aux;
            usuario = usu;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox2.Text) <= 0)
                {
                    MessageBox.Show("El valor a consignar debe ser positivo.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Text = "";
                }
                else if (int.Parse(textBox2.Text) > mibanco.MISC[usuario].AH.SA)
                {
                   
                    MessageBox.Show("Su retiro no se puede realizar por fondos insuficientes, inténtelo de nuevo.", "Mensaje de salida", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    textBox2.Text = "";
                }
                else
                {
                    mibanco.MISC[usuario].AH.retirar(int.Parse(textBox2.Text));
                    mibanco.MISC[usuario].SA -= int.Parse(textBox2.Text);
                    MessageBox.Show("Retiro realizado, vuelva pronto.", "Mensaje de salida.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose(true);
                }

            }
            catch (SystemException error1)
            {
                MessageBox.Show("El valor a retirar debe ser numérico, inténtelo de nuevo." + error1.Message, "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox1.Text) <= 0)
                {
                    MessageBox.Show("El valor a consignar debe ser positivo.", "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = "";
                }
                else
                {
                    mibanco.MISC[usuario].AH.consignar(int.Parse(textBox1.Text));
                    mibanco.MISC[usuario].SA += int.Parse(textBox1.Text);
                    MessageBox.Show("Consignacion realizada, vuelva pronto.", "Mensaje de salida.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose(true);
                }


            }
            catch (SystemException error1)
            {
                MessageBox.Show("El valor a consignar debe ser numérico, inténtelo de nuevo."+error1.Message,"Mensaje de error.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox1.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox4.Text) <= 0)
                {
                    MessageBox.Show("El valor a consignar debe ser positivo.", "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox4.Text = "";
                }
                else
                {
                    mibanco.MISC[usuario].CO.consignar(int.Parse(textBox4.Text));
                    mibanco.MISC[usuario].SA += int.Parse(textBox4.Text);
                    MessageBox.Show("Consignación realizada, vuelva pronto. ", "Mensaje de salida.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose(true);
                }


            }
            catch (SystemException error1)
            {
                MessageBox.Show("El valor a consignar debe ser numérico, inténtelo de nuevo." + error1.Message, "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox3.Text) <= 0)
                {
                    MessageBox.Show("El valor a retirar debe ser positivo.", "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Text = "";
                }
                else
                {
                    mibanco.MISC[usuario].CO.retirar(int.Parse(textBox3.Text));
                    mibanco.MISC[usuario].SA-= int.Parse(textBox3.Text);
                    mibanco.SA -= int.Parse(textBox3.Text);
                    MessageBox.Show("Retiro realizado, vuelva pronto.", "Mensaje de salida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose(true);
                }


            }
            catch (SystemException error1)
            {
                MessageBox.Show("El valor a retirar debe ser numérico, inténtelo de nuevo." + error1.Message, "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Text = "";
            }
        
    }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult mires = new DialogResult();
                mires=MessageBox.Show("Señor cliente, ¿está seguro de cerrar el CDT?", "Mensaje de confirmación.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == mires)
            {
                if(mibanco.MISC[usuario].CD == null)
                {
                    MessageBox.Show("Estimado usuario, el CDT no existe, por favor no insista.", "Mensaje de salida.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Dispose(true);
                }
                else
                {
                   
                    float intereses = mibanco.MISC[usuario].CD.liquidar() - mibanco.MISC[usuario].CD.SA;
                    mibanco.MISC[usuario].CO.actualizar(mibanco.MISC[usuario].CD.liquidar());
                    mibanco.MISC[usuario].SA += intereses;
                    mibanco.actualizar(-intereses);
                    MessageBox.Show("Estimado usuario; los intereses ganados por su CDT son de "+intereses.ToString()+" de pesos, además al saldo de su cuenta corriente se le sumaron un total de "+ mibanco.MISC[usuario].CD.liquidar().ToString()+" de pesos. Usted ha cerrado CDT", "Mensaje de salida.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mibanco.MISC[usuario].elimarcdt();
                    this.Dispose(true);
                }

            }

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox5.Text) <= 0)
                {
                    MessageBox.Show("Por favor el valor a sobregirar debe ser mayor a cero.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox5.Text = "";
                }
                else if (int.Parse(textBox5.Text)- (mibanco.MISC[usuario].CO.SO) > 600000) 
                    {

                    MessageBox.Show("Su retiro no se puede realizar, fondos insuficientes, Inténtelo de nuevo", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox5.Text = "";
                }                   
                   


                else
                {
                    mibanco.MISC[usuario].CO.sobregirar(int.Parse(textBox5.Text));
                    mibanco.SA -= int.Parse(textBox5.Text);
                    mibanco.MISC[usuario].SA -= int.Parse(textBox5.Text);
                    MessageBox.Show("Sobregiro realizado. Vuelva pronto.", "Mensaje de salida.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose(true);
                }


            }
            catch (SystemException error1)
            {
                MessageBox.Show("El valor a consignar debe ser numérico, inténtelo de nuevo." + error1.Message, "Mensaje de error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Text = "";
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
