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
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        Pagos hijoPagos; 
        ModificarCaja hijoModificar;

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
            hijoPagos = new Pagos();
            hijoModificar = new ModificarCaja();
           // hijoPagos.MdiParent = this;
            InitializeComponent();
            miBanco = (Banco)args[1];
            argumentos = args;
            UsuarioSesion.Text = (string)args[0];
            //UsuarioSesion1.Text = (string)args[0];
          //  UsuarioSesion2.Text = (string)args[0];
           // UsuarioSesion3.Text = (string)args[0];
            datos = new List<List<string>>();
            dataGridView1.DataSource = miBanco.obtenerUsuarios().ToArray();
            dataGridView2.DataSource = miBanco.obtenerUsuarios().ToArray();
            dataGridView3.DataSource = miBanco.obtenerUsuarios().ToArray();
            dataGridView4.DataSource = miBanco.obtenerUsuarios().ToArray();
            dataGridView5.DataSource = miBanco.obtenerUsuarios().ToArray();
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
            {
                dataGridView1.Rows.Add(user.ToString());
            }
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
           
            if (miBanco.CrearCajaAhorro(null))//crarCja()
            {
                MessageBox.Show("Nueva caja creada con exito!!\nTitular: " + "\nCbu: " + "\nSaldo: ");
            }
            else
            {
                MessageBox.Show("No se pudo crear la caja");
            }
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
            if (true)//banco.BajaCaja()
            {

            }
        }

        private void modificar(object sender, EventArgs e)
        {
            hijoModificar.Show();
            if (Seleccionar.Selected)
            {
                
                // if (miBanco.ModificarCajaAhorro(dataGridView1.CurrentCell.RowIndex,)
                if(true)
                {
                    MessageBox.Show("Caja modificada con exito");
                }
                else
                {
                    MessageBox.Show("No se pudo modificar la caja");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UsuarioSesion_Click(object sender, EventArgs e)
        {

        }

        private void hacerpago(object sender, EventArgs e)
        {
            hijoPagos.Show();
        }
    }
}

