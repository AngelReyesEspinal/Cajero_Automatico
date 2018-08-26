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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            txtNombre.Text = Properties.Settings.Default.Nombre2;
            txtApellidos.Text = Properties.Settings.Default.Apellido2;
            txtPin.Text = Properties.Settings.Default.PIN2;
            txtBalance.Text = Properties.Settings.Default.Balance2;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("El campo nombre esta vacio");
            }
            else if (txtApellidos.Text == "")
            {
                MessageBox.Show("El campo apellidos esta vacio");
            }
            else if (txtPin.Text == "")
            {
                MessageBox.Show("El campo pin esta vacio");
            }
            else if (txtBalance.Text == "")
            {
                MessageBox.Show("El campo balance esta vacio");
            }
            else
            {
                //try
                //{
                //    //Mi usuario
                //    Properties.Settings.Default.Nombre = txtNombre.Text;
                //    Properties.Settings.Default.Apellido = txtApellidos.Text;
                //    Properties.Settings.Default.PIN = txtPin.Text;
                //    Properties.Settings.Default.Balance = txtBalance.Text;
                //    Properties.Settings.Default.Save();
                //    MessageBox.Show("Cliente registrado exitosamente");
                //}
                //catch (Exception)
                //{
                //    throw;
                //}

                //try
                //{
                //    El usuario de Alejandro
                //    Properties.Settings.Default.Nombre2 = txtNombre.Text;
                //    Properties.Settings.Default.Apellido2 = txtApellidos.Text;
                //    Properties.Settings.Default.PIN2 = txtPin.Text;
                //    Properties.Settings.Default.Balance2 = txtBalance.Text;
                //    Properties.Settings.Default.Save();
                //    MessageBox.Show("Cliente registrado exitosamente");
                //}
                //catch (Exception)
                //{
                //    throw;
                //}
            }
            
        }
    }
}
