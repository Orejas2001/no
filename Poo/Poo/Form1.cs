using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poo
{
    public partial class Form1 : Form
    {
        Form2 frm2;
        public Form1()
        {
            InitializeComponent();
        }
        string BdD = @" Provider.Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=|Data Directory|\\Vendedor.mdb;" + "Jet OleDb:Database Password=; Persist Security Info=False;";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cartel = 0;
            try
            {
                OleDbConnection connection = new OleDbConnection(BdD);
                OleDbCommand selectName = new OleDbCommand("SELECT Usuario, Contraseña From Vendedores", connection);
                try
                {
                    connection.Open();
                    OleDbDataReader LectorRegistros = selectName.ExecuteReader();

                    if ((textBox1.Text != "") && (textBox2.Text != ""))
                    {
                        cartel = 9;
                        while (LectorRegistros.Read())
                        {
                            if ((textBox1.Text == LectorRegistros.GetValue(0).ToString()) && (textBox2.Text == LectorRegistros.GetValue(1).ToString()))
                            {
                                cartel =1;
                                frm2 = new Form2();
                                frm2.Show();
                                this.Hide();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debes completar los campos de usuario y contraseña", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                catch
                {

                }
            }
            catch
            {

            }
            if (cartel == 9)
            {
                MessageBox.Show("El usuario o/y la contraseña es/son incorrecto(s)", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

