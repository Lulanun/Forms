namespace WinFormsApp1
{
    partial class ModificarCaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitular = new System.Windows.Forms.Label();
            this.btnModificarCaja = new System.Windows.Forms.Button();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.tabAgregarTitular = new System.Windows.Forms.TabControl();
            this.tabAgregar = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabEliminar = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabAgregarTitular.SuspendLayout();
            this.tabAgregar.SuspendLayout();
            this.tabEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitular.Location = new System.Drawing.Point(5, 44);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(134, 28);
            this.lblTitular.TabIndex = 0;
            this.lblTitular.Text = "Ingrese su Dni";
            // 
            // btnModificarCaja
            // 
            this.btnModificarCaja.Location = new System.Drawing.Point(7, 219);
            this.btnModificarCaja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificarCaja.Name = "btnModificarCaja";
            this.btnModificarCaja.Size = new System.Drawing.Size(203, 72);
            this.btnModificarCaja.TabIndex = 1;
            this.btnModificarCaja.Text = "Confirmar";
            this.btnModificarCaja.UseVisualStyleBackColor = true;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(138, 44);
            this.txtTitular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(114, 27);
            this.txtTitular.TabIndex = 2;
            // 
            // tabAgregarTitular
            // 
            this.tabAgregarTitular.Controls.Add(this.tabAgregar);
            this.tabAgregarTitular.Controls.Add(this.tabEliminar);
            this.tabAgregarTitular.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabAgregarTitular.Location = new System.Drawing.Point(128, 132);
            this.tabAgregarTitular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAgregarTitular.Name = "tabAgregarTitular";
            this.tabAgregarTitular.SelectedIndex = 0;
            this.tabAgregarTitular.ShowToolTips = true;
            this.tabAgregarTitular.Size = new System.Drawing.Size(687, 336);
            this.tabAgregarTitular.TabIndex = 6;
            // 
            // tabAgregar
            // 
            this.tabAgregar.Controls.Add(this.button2);
            this.tabAgregar.Controls.Add(this.button1);
            this.tabAgregar.Controls.Add(this.txtTitular);
            this.tabAgregar.Controls.Add(this.lblTitular);
            this.tabAgregar.Location = new System.Drawing.Point(4, 29);
            this.tabAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAgregar.Size = new System.Drawing.Size(679, 303);
            this.tabAgregar.TabIndex = 0;
            this.tabAgregar.Text = "Agregar Titular";
            this.tabAgregar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 219);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 72);
            this.button1.TabIndex = 5;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabEliminar
            // 
            this.tabEliminar.Controls.Add(this.textBox1);
            this.tabEliminar.Controls.Add(this.btnModificarCaja);
            this.tabEliminar.Controls.Add(this.label1);
            this.tabEliminar.Location = new System.Drawing.Point(4, 29);
            this.tabEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabEliminar.Name = "tabEliminar";
            this.tabEliminar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabEliminar.Size = new System.Drawing.Size(679, 303);
            this.tabEliminar.TabIndex = 1;
            this.tabEliminar.Text = "Eliminar Titular";
            this.tabEliminar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 27);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese su Dni";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ModificarCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.tabAgregarTitular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModificarCaja";
            this.Text = "Titular";
            this.tabAgregarTitular.ResumeLayout(false);
            this.tabAgregar.ResumeLayout(false);
            this.tabAgregar.PerformLayout();
            this.tabEliminar.ResumeLayout(false);
            this.tabEliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTitular;
        private Button btnModificarCaja;
        private TextBox txtTitular;
        private TabControl tabAgregarTitular;
        private TabPage tabAgregar;
        private TabPage tabEliminar;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
    }
}