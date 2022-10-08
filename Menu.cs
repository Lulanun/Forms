using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        Pagos hijoPagos;
        //CajaAhorro hijoCajaAhorro;
        //PlazoFijo hijoPlazoFijo;
        //TarjCred hijoTarjCred;

        public object[] argumentos;
        List<List<string>> datos;
        public string usuario;
        public Banco miBanco;


        public Menu(string usuario, Banco b)
        {
            this.miBanco = b;
            this.usuario = usuario;
        }


        public Menu(object[] args)
        {
            hijoPagos.MdiParent = this;
            InitializeComponent();
            miBanco = (Banco)args[1];
            argumentos = args;
            //label2.Text = (string)args[0];
            datos = new List<List<string>>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void refreshData()
        {
            //borro los datos
            dataGridView1.Rows.Clear();
            //agrego lo nuevo
            foreach (Usuario user in miBanco.obtenerUsuarios())
                dataGridView1.Rows.Add(user.toArray());
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPlazoFijo(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabcajaDeAhorro(object sender, EventArgs e)
        {

        }

        private void crearCajaAhorro(object sender, EventArgs e)
        {

        }

        private void depositar(object sender, EventArgs e)
        {

        }

        private void retirar(object sender, EventArgs e)
        {

        }

        private void transferir(object sender, EventArgs e)
        {

        }

        private void verDetalle(object sender, EventArgs e)
        {

        }

        private void darDeBaja(object sender, EventArgs e)
        {

        }

        private void modificar(object sender, EventArgs e)
        {

        }
    }
}

