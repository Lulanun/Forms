﻿using System;
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

        Banco banco = new Banco();

        public ModificarCaja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dniTitular = txtTitular.Text;
            string cbu = txtCbu.Text;

            if (tabAgregar.Focus())
            {
                banco.ModificarCajaAhorro(cbu, dniTitular, "agregar");
            }else if (tabEliminar.Focus())
            {

            }

        }
    }
}
