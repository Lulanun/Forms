namespace WinFormsApp1
{
    partial class Menu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.UsuarioSesion = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dataGridView1.Location = new System.Drawing.Point(17, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(551, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.tabPage1);
            this.Tab.Controls.Add(this.tabPage2);
            this.Tab.Controls.Add(this.tabPage3);
            this.Tab.Controls.Add(this.tabPage4);
            this.Tab.Location = new System.Drawing.Point(12, 12);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1348, 637);
            this.Tab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1340, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Caja de Ahorro";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(450, 385);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(118, 36);
            this.button10.TabIndex = 7;
            this.button10.Text = "Depositar";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.depositar);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(450, 441);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(118, 36);
            this.button9.TabIndex = 6;
            this.button9.Text = "Retirar";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.retirar);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(450, 497);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(118, 36);
            this.button8.TabIndex = 5;
            this.button8.Text = "Transferir";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.transferir);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(450, 555);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 36);
            this.button7.TabIndex = 4;
            this.button7.Text = "Ver Detalle";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.verDetalle);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(17, 441);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 36);
            this.button6.TabIndex = 3;
            this.button6.Text = "Modificar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.modificar);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(17, 385);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 36);
            this.button5.TabIndex = 2;
            this.button5.Text = "Dar de Baja";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.darDeBaja);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(17, 497);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 63);
            this.button4.TabIndex = 1;
            this.button4.Text = "Crear Caja de Ahorro";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.crearCajaAhorro);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1340, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plazo FIjo";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(748, 395);
            this.dataGridView2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1340, 609);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Tarjeta de Credito";
            this.tabPage3.Click += new System.EventHandler(this.tabcajaDeAhorro);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(669, 395);
            this.dataGridView3.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage4.Controls.Add(this.UsuarioSesion);
            this.tabPage4.Controls.Add(this.button13);
            this.tabPage4.Controls.Add(this.button12);
            this.tabPage4.Controls.Add(this.button11);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.dataGridView5);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1340, 609);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Pago";
            // 
            // UsuarioSesion
            // 
            this.UsuarioSesion.AutoSize = true;
            this.UsuarioSesion.Location = new System.Drawing.Point(1205, 19);
            this.UsuarioSesion.Name = "UsuarioSesion";
            this.UsuarioSesion.Size = new System.Drawing.Size(100, 15);
            this.UsuarioSesion.TabIndex = 10;
            this.UsuarioSesion.Text = "Usuario en Sesion";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button13.Location = new System.Drawing.Point(6, 513);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(167, 34);
            this.button13.TabIndex = 9;
            this.button13.Text = "Pagar";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(673, 513);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(167, 34);
            this.button12.TabIndex = 8;
            this.button12.Text = "Eliminar Pago";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(6, 36);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(232, 53);
            this.button11.TabIndex = 7;
            this.button11.Text = "Crear Nuevo Pago";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "PAGOS PENDIENTES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(673, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "PAGOS REALIZADOS";
            this.label1.Click += new System.EventHandler(this.tabPlazoFijo);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToOrderColumns = true;
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(3, 182);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 25;
            this.dataGridView5.Size = new System.Drawing.Size(646, 309);
            this.dataGridView5.TabIndex = 4;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToOrderColumns = true;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(673, 182);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.Size = new System.Drawing.Size(668, 309);
            this.dataGridView4.TabIndex = 3;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1372, 653);
            this.Controls.Add(this.Tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private TabControl Tab;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private TabPage tabPage3;
        private DataGridView dataGridView3;
        private TabPage tabPage4;
        private DataGridView dataGridView4;
        private Button button4;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private DataGridView dataGridView5;
        private Label label2;
        private Label label1;
        private Button button13;
        private Button button12;
        private Button button11;
        private Label UsuarioSesion;
        private DataGridViewCheckBoxColumn Seleccionar;
    }
}