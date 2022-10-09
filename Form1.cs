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
        bool logued;
        public bool touched;


        public Form1()
        {
            InitializeComponent();
            banco = new Banco();
            logued = false;
            hijoLoguin = new Log(banco);
            hijoLoguin.logued = false;
            hijoLoguin.MdiParent = this;
            hijoLoguin.TransfEvento += TransfDelegado;
            hijoLoguin.Show();
            touched = false;    

        }

        private void TransfDelegado(string Usuario, string Pass/*, string Dni*/) 
        {
            this.usuario = Usuario;
            this.pass = Pass;
            //this.dni = Dni;

            if (banco.iniciarSesion(usuario, pass/*, dni*/))
            {
                MessageBox.Show("Correcto, Usuario: " + usuario, "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hijoLoguin.Close();
                hijoMain = new Menu(new object[] { usuario, banco });
                hijoMain.usuario = Usuario;
                hijoMain.MdiParent = this;
                hijoMain.Show();
            }
            else
            {
                MessageBox.Show("Log in incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hijoLoguin.Show();
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
