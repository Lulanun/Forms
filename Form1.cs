using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Banco banco;
        Log hijoLoguin;
        Menu hijoMain;
        internal string texto;
        string usuario;
        string pass;
        string dni;
     
        public bool touched;
        public Usuario? usuarioActual;

        public Form1()
        {
            InitializeComponent();
            banco = Banco.GetInstancia();
            hijoLoguin = new Log(banco);
            hijoLoguin.logued = false;
            hijoLoguin.MdiParent = this;
            hijoLoguin.TransfEvento += TransfDelegado;
            hijoLoguin.Show();
            touched = false;

        }


        private void TransfDelegado(string Usuario, string Pass)
        {
            this.usuario = Usuario;
            this.pass = Pass;

            if (banco.IniciarSesion(usuario, pass))
            {
                MessageBox.Show("Correcto, Usuario: " + usuario, "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hijoLoguin.Close();
                hijoMain = new Menu();
                hijoMain.usuario = Usuario;
                hijoMain.MdiParent = this;
                hijoMain.TransfEvento += TransfDelegadoMenu;
                usuarioActual = banco.UsuarioActual;
                hijoMain.Show();
            }
            else
            {
                MessageBox.Show("Log in incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hijoLoguin.Show();
            }

        }

        private void TransfDelegadoMenu()

        {
            banco.CerrarSesion();
            MessageBox.Show("Hasta luego", "Adios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            hijoMain.Close();
            hijoLoguin = new Log(banco);
            hijoLoguin.MdiParent = this;
            hijoLoguin.TransfEvento += TransfDelegado;
            hijoLoguin.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
        
        }
    }
}
