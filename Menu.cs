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
using static Pago;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static WinFormsApp1.Log;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {

        //CajaAhorro hijoCajaAhorro;
        //PlazoFijo hijoPlazoFijo;
        //TarjCred hijoTarjCred;

        public object[] argumentos;

        List<List<string>> datos;
        public string usuario;
        public Banco miBanco = Banco.GetInstancia();
        public string nombre;
        public double monto;
        public string pago;
        public TransfDelegadoMenu? TransfEvento;


        public Menu()
        {

            InitializeComponent();

            datos = new List<List<string>>();
            dataGridView1.DataSource = miBanco.MostrarCajasDeAhorroUsuarioActual().ToArray();
            lblDescrNombre.Text = miBanco.UsuarioActual.nombre;
            lblDescrApell.Text = miBanco.UsuarioActual.apellido;
            lblDescrMail.Text = miBanco.UsuarioActual.mail;
            lblDescrDni.Text = miBanco.UsuarioActual.dni;
            lblDescrPass.Text = miBanco.UsuarioActual.clave;

            lblDescrNombre.Visible = true;
            lblDescrApell.Visible = true;
            lblDescrMail.Visible = true;
            lblDescrDni.Visible = true;
            lblDescrPass.Visible = true;
        }


        private void CrearNuevoPago(object sender, EventArgs e)
        {

            nombre = nombrePago.Text;
            monto = double.Parse(montoPago.Text);

            pago = tipoDePago.SelectedItem.ToString();

            if (miBanco.AltaPago(nombre, monto, pago) != null)
                MessageBox.Show("Pago creado");

            dataGridView4.DataSource = miBanco.MostrarPagosRealizado().ToArray();
            dataGridView5.DataSource = miBanco.MostrarPagosPendiente().ToArray();

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
            /*foreach (Usuario user in miBanco.obtenerUsuarios())
            {
                dataGridView1.Rows.Add(user.ToString());
            }*/
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

            if (miBanco.AltaCajaAhorro())
            {
                MessageBox.Show("Nueva caja creada con exito");
                dataGridView1.DataSource = miBanco.MostrarCajasDeAhorroUsuarioActual().ToArray();
            }
            else
            {
                MessageBox.Show("No se pudo crear la caja");
            }
        }

        private void depositar(object sender, EventArgs e)
        {
            label16.Visible = false;
            label17.Visible = false;
            textBoxtransf.Visible = false;
            textBoxCBU.Visible = false;
            button20.Visible = false;
            label15.Visible = false;
            textBox4.Visible = false;
            button19.Visible = false;

            label14.Visible = true;
            montodep.Visible = true;
            button18.Visible = true;

        }

        private void retirar(object sender, EventArgs e)
        {
            label16.Visible = false;
            label17.Visible = false;
            textBoxtransf.Visible = false;
            textBoxCBU.Visible = false;
            button20.Visible = false;
            label14.Visible = false;
            montodep.Visible = false;
            button18.Visible = false;

            label15.Visible = true;
            textBox4.Visible = true;
            button19.Visible = true;
        }

        private void transferir(object sender, EventArgs e)
        {
            label15.Visible = false;
            textBox4.Visible = false;
            button19.Visible = false;
            label14.Visible = false;
            montodep.Visible = false;
            button18.Visible = false;

            label16.Visible = true;
            label17.Visible = true;
            textBoxtransf.Visible = true;
            textBoxCBU.Visible = true;
            button20.Visible = true;

        }

        private void verDetalle(object sender, EventArgs e)
        {
            string cbu = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            dataGridView8.Visible = true;
            dataGridView8.DataSource = miBanco.MostrarMovimientosUsuarioActual(cbu).ToArray();
        }

        private void darDeBaja(object sender, EventArgs e)
        {
            string cbu = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            if (cbu != null)
            {
                miBanco.BajaCajaAhorroPorCbu(cbu);

                MessageBox.Show("Caja eliminada con exito");

                dataGridView1.DataSource = miBanco.MostrarCajasDeAhorroUsuarioActual().ToArray();
            }
            else
            {
                MessageBox.Show("No se puede eliminar la caja");

            }
        }

        private void modificar(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() != null)
            {
                label4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                label5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tabAgregarTitular.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button5.Visible = true;
            button6.Visible = true;
            button10.Visible = true;
            button9.Visible = true;
            button8.Visible = true;
            button7.Visible = true;


        }

        private void GrillaPagosPendientes(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView6.Visible = true;
            dataGridView7.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

            dataGridView6.DataSource = miBanco.MostrarCajasDeAhorroUsuarioActual();
            dataGridView7.DataSource = miBanco.MostrarTarjetasDeCreditoUsuarioActual();
        }

        private void montoPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarTitular(object sender, EventArgs e)
        {

            string cbu = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string dni = txtTitular.Text;

            miBanco.ModificarCajaAhorro(cbu, dni, "agregar");
        }

        private void EliminarTitular(object sender, EventArgs e)
        {

            string cbu = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string dni = textBox1.Text;

            if (miBanco.ModificarCajaAhorro(cbu, dni, "eliminar"))
            {
                MessageBox.Show("No puede quedar sin titulares la caja de ahorro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabAgregarTitular.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabAgregarTitular.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }

        private void UsuarioSesion_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificarCaja_Click(object sender, EventArgs e)
        {
            tabAgregarTitular.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }
        //agregar titular Cancelar
        private void button2_Click_1(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                string cbu = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string dni = textBox1.Text;

                if (miBanco.ModificarCajaAhorro(cbu, dni, "agregar"))
                {
                    label13.Text = "Titular agregado con exito!";
                    label13.Visible = true;
                }
            }
        }
        //eliminar titular
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                string cbu = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string dni = textBox1.Text;

                if (miBanco.ModificarCajaAhorro(cbu, dni, "eliminar"))
                {
                    label12.Text = "Titular eliminado con exito!";
                    label12.Visible = true;
                }
                else
                {
                    label12.Text = "No se puede dejar una caja sin titular!";
                }
            }

        }
        //Cancelar 
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            tabAgregarTitular.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public delegate void TransfDelegadoMenu();


        private void button3_Click(object sender, EventArgs e)
        {
            this.TransfEvento();
        }

        private void tabAgregar_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            float monto = float.Parse(montodep.Text);
            string cbu = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            if (miBanco.Depositar(cbu, monto))
            {
                dataGridView1.DataSource = miBanco.MostrarCajasDeAhorroUsuarioActual().ToArray();
                MessageBox.Show("El saldo de la caja es: " + miBanco.BuscarCajaPorCbu(cbu).saldo);
            }

        }

        private void montodep_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            float monto = float.Parse(textBox4.Text);
            string cbu = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            if (miBanco.Retirar(cbu, monto))
            {
                dataGridView1.DataSource = miBanco.MostrarCajasDeAhorroUsuarioActual().ToArray();
                MessageBox.Show("El saldo de la caja es: " + miBanco.BuscarCajaPorCbu(cbu).saldo);
            }
            else
            {
                MessageBox.Show("El saldo de la caja no es suficiente");
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBoxtransf_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            float monto = float.Parse(textBoxtransf.Text);
            string cbuOrigen = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string cbuDestino = textBoxCBU.Text;

            if (miBanco.Transferir(cbuOrigen, cbuDestino, monto))
            {
                MessageBox.Show("Transferencia realizada con exito");
                dataGridView1.DataSource = miBanco.MostrarCajasDeAhorroUsuarioActual().ToArray();
            }
            else
            {
                MessageBox.Show("El CBU destino no existe, o no tienes el saldo suficiente");
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (miBanco.AltaTarjetaCredito())
            {
                MessageBox.Show("Nueva tarjeta creada con exito");

                // No aparece en la grilla 
                //         dataGridView3.DataSource = miBanco.AltaTarjetaCredito();
            }
            else
            {
                MessageBox.Show("Error al crear la tarjeta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            lblPass.Visible = false;
            txtPass.Visible = false;
            btnPass.Visible = false;
            btnEliminar.Visible = false;

            lblMail.Visible = true;
            txtMail.Visible = true;
            btnMail.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lblMail.Visible = false;
            txtMail.Visible = false;
            btnMail.Visible = false;
            btnEliminar.Visible = false;

            lblPass.Visible = true;
            txtPass.Visible = true;
            btnPass.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lblMail.Visible = false;
            txtMail.Visible = false;
            btnMail.Visible = false;
            lblPass.Visible = false;
            txtPass.Visible = false;
            btnPass.Visible = false;

            btnEliminar.Visible = true;
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            if (miBanco.ModificarMail(txtMail.Text))
            {
                lblDescrNombre.Text = miBanco.UsuarioActual.nombre;
                lblDescrApell.Text = miBanco.UsuarioActual.apellido;
                lblDescrMail.Text = miBanco.UsuarioActual.mail;
                lblDescrDni.Text = miBanco.UsuarioActual.dni;
                lblDescrPass.Text = miBanco.UsuarioActual.clave;
                MessageBox.Show("Mail cambiado con exito");
            }
            else
            {
                MessageBox.Show("No se ingreso el mail, o el mismo ya existe");
            }
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            if (miBanco.ModificarContrasenia(txtPass.Text))
            {
                lblDescrNombre.Text = miBanco.UsuarioActual.nombre;
                lblDescrApell.Text = miBanco.UsuarioActual.apellido;
                lblDescrMail.Text = miBanco.UsuarioActual.mail;
                lblDescrDni.Text = miBanco.UsuarioActual.dni;
                lblDescrPass.Text = miBanco.UsuarioActual.clave;
                MessageBox.Show("Contraseña cambiada con exito");
            }
            else
            {
                MessageBox.Show("No puedes ingresar una contraseña vacia");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (miBanco.EliminarUsuario())
            {
                this.TransfEvento();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el usuario");
            }
        }
    }
}

