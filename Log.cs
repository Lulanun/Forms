using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Log : Form
    {
        public bool logued;
        public string usuario;
        public string pass;
        public string dni;
        public string mail;
        public string apellido;

        public Banco elBanco;

        public TransfDelegado TransfEvento;

        public Log(Banco b)
        {
            logued = false;
            InitializeComponent();
            elBanco = b;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

        public delegate void TransfDelegado(string usuario, string pass);

        private void button2_Click(object sender, EventArgs e)
        {
            usuario = textBoxLogUser.Text;
            pass = textBoxLogPass.Text;
            if (usuario != null && pass != null)
            {
                this.TransfEvento(usuario, pass);
                logued = true;
            }
            else
            {
                MessageBox.Show("Error al iniciar sesion");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            dni = textBoxDni.Text;
            usuario = textBoxNombre.Text;
            apellido = textBoxApellido.Text;
            mail = textBoxMail.Text;
            pass = textBoxPass.Text;

            if (elBanco.AltaDeUsuario(dni, usuario, apellido, mail, pass))
            {
                MessageBox.Show("Usuario Agregado con éxito");
                this.TransfEvento(usuario, pass);
            }
            else
            {
                MessageBox.Show("Error al agregar el usuario");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
