using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ModificarCaja : Form
    {

        Banco banco = Banco.GetInstancia();

        public ModificarCaja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dniTitular = txtTitular.Text;
           // string cbu = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            MessageBox.Show("Estoy en el metodo");

            if (tabAgregar.Focus())
            {
                MessageBox.Show("Estoy en el if");
               // banco.ModificarCajaAhorro(cbu, dniTitular, "agregar");
            }
            else if (tabEliminar.Focus())
            {
                MessageBox.Show("Estoy en el else");
             //   banco.ModificarCajaAhorro(cbu, dniTitular, "eliminar");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
