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
            this.lblCbu = new System.Windows.Forms.Label();
            this.txtCbu = new System.Windows.Forms.TextBox();
            this.tabAgregarTitular = new System.Windows.Forms.TabControl();
            this.tabAgregar = new System.Windows.Forms.TabPage();
            this.tabEliminar = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabAgregarTitular.SuspendLayout();
            this.tabAgregar.SuspendLayout();
            this.tabEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitular.Location = new System.Drawing.Point(4, 33);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(109, 21);
            this.lblTitular.TabIndex = 0;
            this.lblTitular.Text = "Ingrese su Dni";
            // 
            // btnModificarCaja
            // 
            this.btnModificarCaja.Location = new System.Drawing.Point(6, 164);
            this.btnModificarCaja.Name = "btnModificarCaja";
            this.btnModificarCaja.Size = new System.Drawing.Size(178, 54);
            this.btnModificarCaja.TabIndex = 1;
            this.btnModificarCaja.Text = "Confirmar";
            this.btnModificarCaja.UseVisualStyleBackColor = true;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(121, 33);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(100, 23);
            this.txtTitular.TabIndex = 2;
            // 
            // lblCbu
            // 
            this.lblCbu.AutoSize = true;
            this.lblCbu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCbu.Location = new System.Drawing.Point(4, 59);
            this.lblCbu.Name = "lblCbu";
            this.lblCbu.Size = new System.Drawing.Size(113, 21);
            this.lblCbu.TabIndex = 3;
            this.lblCbu.Text = "Ingresa tu CBU";
            // 
            // txtCbu
            // 
            this.txtCbu.Location = new System.Drawing.Point(121, 62);
            this.txtCbu.Name = "txtCbu";
            this.txtCbu.Size = new System.Drawing.Size(100, 23);
            this.txtCbu.TabIndex = 4;
            // 
            // tabAgregarTitular
            // 
            this.tabAgregarTitular.Controls.Add(this.tabAgregar);
            this.tabAgregarTitular.Controls.Add(this.tabEliminar);
            this.tabAgregarTitular.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabAgregarTitular.Location = new System.Drawing.Point(112, 99);
            this.tabAgregarTitular.Name = "tabAgregarTitular";
            this.tabAgregarTitular.SelectedIndex = 0;
            this.tabAgregarTitular.ShowToolTips = true;
            this.tabAgregarTitular.Size = new System.Drawing.Size(601, 252);
            this.tabAgregarTitular.TabIndex = 6;
            // 
            // tabAgregar
            // 
            this.tabAgregar.Controls.Add(this.button1);
            this.tabAgregar.Controls.Add(this.txtTitular);
            this.tabAgregar.Controls.Add(this.txtCbu);
            this.tabAgregar.Controls.Add(this.lblTitular);
            this.tabAgregar.Controls.Add(this.lblCbu);
            this.tabAgregar.Location = new System.Drawing.Point(4, 24);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgregar.Size = new System.Drawing.Size(593, 224);
            this.tabAgregar.TabIndex = 0;
            this.tabAgregar.Text = "Agregar Titular";
            this.tabAgregar.UseVisualStyleBackColor = true;
            // 
            // tabEliminar
            // 
            this.tabEliminar.Controls.Add(this.textBox1);
            this.tabEliminar.Controls.Add(this.btnModificarCaja);
            this.tabEliminar.Controls.Add(this.textBox2);
            this.tabEliminar.Controls.Add(this.label1);
            this.tabEliminar.Controls.Add(this.label2);
            this.tabEliminar.Location = new System.Drawing.Point(4, 24);
            this.tabEliminar.Name = "tabEliminar";
            this.tabEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminar.Size = new System.Drawing.Size(593, 224);
            this.tabEliminar.TabIndex = 1;
            this.tabEliminar.Text = "Eliminar Titular";
            this.tabEliminar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese su Dni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingresa tu CBU";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModificarCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabAgregarTitular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private Label lblCbu;
        private TextBox txtCbu;
        private TabControl tabAgregarTitular;
        private TabPage tabAgregar;
        private TabPage tabEliminar;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}