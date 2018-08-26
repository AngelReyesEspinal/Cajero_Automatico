using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero_Automático
{
    public partial class frmCA : Form
    {
        public string usuario;
        public string balanceActual;
        public double cantidadAEnviar;

        public frmCA()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //aqui se asigna que el input tendra lo que diga el boton seleccionado
        private void btn0_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "0";
            txtCantidadARetirar.Text += "0";
            txtCantidadATransferir.Text += "0";
            txtNumeroDeCuenta.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "1";
            txtCantidadARetirar.Text += "1";
            txtCantidadATransferir.Text += "1";
            txtNumeroDeCuenta.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "2";
            txtCantidadARetirar.Text += "2";
            txtCantidadATransferir.Text += "2";
            txtNumeroDeCuenta.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "3";
            txtCantidadARetirar.Text += "3";
            txtCantidadATransferir.Text += "3";
            txtNumeroDeCuenta.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "4";
            txtCantidadARetirar.Text += "4";
            txtCantidadATransferir.Text += "4";
            txtNumeroDeCuenta.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "5";
            txtCantidadARetirar.Text += "5";
            txtCantidadATransferir.Text += "5";
            txtNumeroDeCuenta.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "6";
            txtCantidadARetirar.Text += "6";
            txtCantidadATransferir.Text += "6";
            txtNumeroDeCuenta.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "7";
            txtCantidadARetirar.Text += "7";
            txtCantidadATransferir.Text += "7";
            txtNumeroDeCuenta.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "8";
            txtCantidadARetirar.Text += "8";
            txtCantidadATransferir.Text += "8";
            txtNumeroDeCuenta.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "9";
            txtCantidadARetirar.Text += "9";
            txtCantidadATransferir.Text += "9";
            txtNumeroDeCuenta.Text += "9";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Para que no explote con < 0
            string nuevaCadena = "";
            string cadenaRetiro = "";
            string cadenaTransferencia = "";
            string cadenaNumeroDeCuenta = "";

            if (txtPassword.Text.Length > 0)
            {
                nuevaCadena = txtPassword.Text.Substring(0, txtPassword.Text.Length - 1);
                txtPassword.Text = nuevaCadena;
            }
            else
            {
                txtPassword.Text = nuevaCadena;
            }

            if (txtCantidadARetirar.Text.Length > 0)
            {
                cadenaRetiro = txtCantidadARetirar.Text.Substring(0, txtCantidadARetirar.Text.Length - 1);
                txtCantidadARetirar.Text = cadenaRetiro;
            }
            else
            {
                txtCantidadARetirar.Text = cadenaRetiro;
            }

            if (txtCantidadATransferir.Text.Length > 0)
            {
                cadenaTransferencia = txtCantidadATransferir.Text.Substring(0, txtCantidadATransferir.Text.Length - 1);
                txtCantidadATransferir.Text = cadenaTransferencia;
            }
            else
            {
                txtCantidadATransferir.Text = cadenaTransferencia;
            }

            if (txtNumeroDeCuenta.Text.Length > 0)
            {
                cadenaNumeroDeCuenta = txtNumeroDeCuenta.Text.Substring(0, txtNumeroDeCuenta.Text.Length - 1);
                txtNumeroDeCuenta.Text = cadenaNumeroDeCuenta;
            }
            else
            {
                txtNumeroDeCuenta.Text = cadenaNumeroDeCuenta;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //validacion password
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Boolean verificador = false;
            string nombre;

            if (txtPassword.Text != "")
            {
                if (txtPassword.Text == Properties.Settings.Default.PIN)
                {
                    nombre = Properties.Settings.Default.Nombre;
                    MessageBox.Show("¡Bienvenido " + nombre + "!", "Notificación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usuario = txtPassword.Text;
                    tabControl.SelectTab(1);
                    verificador = true;
                }

                if (txtPassword.Text == Properties.Settings.Default.PIN2)
                {
                    nombre = Properties.Settings.Default.Nombre2;
                    MessageBox.Show("¡Bienvenido " + nombre + "!", "Notificación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usuario = txtPassword.Text;
                    tabControl.SelectTab(1);
                    verificador = true;
                }
                
                if (!verificador)
                {
                    MessageBox.Show("Disculpe, por favor verifique que haya escrito el PIN correctamente", "Notificación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Disculpe, no ha ingresado ningun caracter", "Notificación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //Obtener el balance del usuario actual
        private void btnBalance_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(2);
            
            if (usuario == Properties.Settings.Default.PIN)
            {
                lblBalance.Text = Properties.Settings.Default.Balance;
                balanceActual = lblBalance.Text;
            }

            if (usuario == Properties.Settings.Default.PIN2)
            {
                lblBalance.Text = Properties.Settings.Default.Balance2;
                balanceActual = lblBalance.Text;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(0);
            txtPassword.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(0);
            txtPassword.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(0);
            txtPassword.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(3);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            retirar(2000);
        }

        private void retirar(double cantidadARetiro)
        {
            //Por si acaso:
            if (balanceActual == null)
            {
                if (usuario == Properties.Settings.Default.PIN)
                {
                    balanceActual = Properties.Settings.Default.Balance;
                }

                if (usuario == Properties.Settings.Default.PIN2)
                {
                    balanceActual = Properties.Settings.Default.Balance2;
                }
            }

            double balance = double.Parse(balanceActual);

            if (balance >= cantidadARetiro)
            {
                double creditoRestante = balance - cantidadARetiro;
                
                if (balanceActual == Properties.Settings.Default.Balance)
                {
                    if (MessageBox.Show("¿Desea completar la transacción?", "Atención",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        Properties.Settings.Default.Balance = Convert.ToString(creditoRestante);
                        Properties.Settings.Default.Save();

                        MessageBox.Show("Su retiro de: $" + cantidadARetiro + " se realizó correctamente, gracias por preferirnos.", "Notificación",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        tabControl.SelectTab(3);
                    }
                }

                if (balanceActual == Properties.Settings.Default.Balance2)
                {
                    if (MessageBox.Show("¿Desea completar la transacción?", "Atención",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        Properties.Settings.Default.Balance2 = Convert.ToString(creditoRestante);
                        Properties.Settings.Default.Save();

                        MessageBox.Show("Su retiro de: $" + cantidadARetiro + " se realizó correctamente, gracias por preferirnos.", "Notificación",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        tabControl.SelectTab(3);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lo sentimos, no cuenta con balance suficiente para realizar ésta operación.", "Advertencia");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            retirar(1000);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            retirar(500);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(4);
            txtCantidadARetirar.Text = "";
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(0);
            txtPassword.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double cantidadARetirar = double.Parse(txtCantidadARetirar.Text);

            retirar(cantidadARetirar);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(0);
            txtPassword.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(1);
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(5);
            txtCantidadATransferir.Clear();
            txtNumeroDeCuenta.Clear();
            MessageBox.Show("El $: hace referencia a la cantidad de dinero que deseas enviar", "Notificación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
            //Por si acaso:
            if (balanceActual == null)
            {
                if (usuario == Properties.Settings.Default.PIN)
                {
                    balanceActual = Properties.Settings.Default.Balance;
                }

                if (usuario == Properties.Settings.Default.PIN2)
                {
                    balanceActual = Properties.Settings.Default.Balance2;
                }
            }

            double balance = double.Parse(balanceActual);
            cantidadAEnviar = double.Parse(txtCantidadATransferir.Text);

            if (balance >= cantidadAEnviar)
            {
                double creditoRestante = balance - cantidadAEnviar;

                if (MessageBox.Show("Posee la cantidad a transaccionar, ¿desea continuar?", "Atención",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    tabControl.SelectTab(6);
                    txtNumeroDeCuenta.Clear();
                    MessageBox.Show("El -> hace referencia al número de cuenta al que enviaras el dinero", "Notificación",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tabControl.SelectTab(5);
                }
   
            }
            else
            {
                MessageBox.Show("Lo sentimos, no cuenta con balance suficiente para realizar ésta operación.", "Advertencia");
            }
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            tabControl.SelectTab(0);
            txtPassword.Clear();
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            tabControl.SelectTab(1);

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(0);
            txtPassword.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(1);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string receptor = txtNumeroDeCuenta.Text;
            double resultado;
            double balanceAct = double.Parse(balanceActual);
            double aux;
            double ultima;

            if (receptor == Properties.Settings.Default.PIN)
            {
                if (usuario == Properties.Settings.Default.PIN)
                {
                    resultado = balanceAct - cantidadAEnviar;
                    Properties.Settings.Default.Balance = Convert.ToString(resultado);
                    Properties.Settings.Default.Save();
                }

                if (usuario == Properties.Settings.Default.PIN2)
                {
                    resultado = balanceAct - cantidadAEnviar;
                    Properties.Settings.Default.Balance2 = Convert.ToString(resultado);
                    Properties.Settings.Default.Save();
                }

                aux = 0;
                ultima = 0;

                aux = double.Parse(Properties.Settings.Default.Balance);
                ultima = aux + cantidadAEnviar;

                Properties.Settings.Default.Balance = Convert.ToString(ultima);
                Properties.Settings.Default.Save();

                MessageBox.Show("¡Transacción exitosa!", "Notificación",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (receptor == Properties.Settings.Default.PIN2)
            {
                if (usuario == Properties.Settings.Default.PIN)
                {
                    resultado = balanceAct - cantidadAEnviar;
                    Properties.Settings.Default.Balance = Convert.ToString(resultado);
                    Properties.Settings.Default.Save();
                }

                if (usuario == Properties.Settings.Default.PIN2)
                {
                    resultado = balanceAct - cantidadAEnviar;
                    Properties.Settings.Default.Balance2 = Convert.ToString(resultado);
                    Properties.Settings.Default.Save();
                }

                aux = 0;
                ultima = 0;

                aux = double.Parse(Properties.Settings.Default.Balance2);
                ultima = aux + cantidadAEnviar;

                Properties.Settings.Default.Balance2 = Convert.ToString(ultima);
                Properties.Settings.Default.Save();

                MessageBox.Show("¡Transacción exitosa!", "Notificación",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}