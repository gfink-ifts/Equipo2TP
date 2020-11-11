namespace Agencia_de_Viajes
{
    partial class Clientes
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rb_Ord_Apellido = new System.Windows.Forms.RadioButton();
            this.rb_Ord_fecha = new System.Windows.Forms.RadioButton();
            this.cmb_sexo = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_Sexo = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_dni_alta = new System.Windows.Forms.TextBox();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.rb_cliente = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dni_busqueda = new System.Windows.Forms.TextBox();
            this.btn_confirmarCliente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dg_Clientes = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dg_historial = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_baja = new System.Windows.Forms.RadioButton();
            this.rb_modificar = new System.Windows.Forms.RadioButton();
            this.rb_alta = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Clientes)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_historial)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rb_Ord_Apellido);
            this.groupBox5.Controls.Add(this.rb_Ord_fecha);
            this.groupBox5.Location = new System.Drawing.Point(139, 100);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(153, 80);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ordenar clientes por:";
            // 
            // rb_Ord_Apellido
            // 
            this.rb_Ord_Apellido.AutoSize = true;
            this.rb_Ord_Apellido.Location = new System.Drawing.Point(30, 43);
            this.rb_Ord_Apellido.Name = "rb_Ord_Apellido";
            this.rb_Ord_Apellido.Size = new System.Drawing.Size(62, 17);
            this.rb_Ord_Apellido.TabIndex = 1;
            this.rb_Ord_Apellido.Text = "Apellido";
            this.rb_Ord_Apellido.UseVisualStyleBackColor = true;
            // 
            // rb_Ord_fecha
            // 
            this.rb_Ord_fecha.AutoSize = true;
            this.rb_Ord_fecha.Checked = true;
            this.rb_Ord_fecha.Location = new System.Drawing.Point(30, 20);
            this.rb_Ord_fecha.Name = "rb_Ord_fecha";
            this.rb_Ord_fecha.Size = new System.Drawing.Size(90, 17);
            this.rb_Ord_fecha.TabIndex = 0;
            this.rb_Ord_fecha.TabStop = true;
            this.rb_Ord_fecha.Text = "Fecha de alta";
            this.rb_Ord_fecha.UseVisualStyleBackColor = true;
            // 
            // cmb_sexo
            // 
            this.cmb_sexo.AutoCompleteCustomSource.AddRange(new string[] {
            "M",
            "F",
            "NC"});
            this.cmb_sexo.FormattingEnabled = true;
            this.cmb_sexo.Items.AddRange(new object[] {
            "M",
            "F",
            "N"});
            this.cmb_sexo.Location = new System.Drawing.Point(177, 146);
            this.cmb_sexo.Name = "cmb_sexo";
            this.cmb_sexo.Size = new System.Drawing.Size(37, 21);
            this.cmb_sexo.TabIndex = 20;
            this.cmb_sexo.SelectedIndexChanged += new System.EventHandler(this.cmb_sexo_SelectedIndexChanged_1);
            this.cmb_sexo.Click += new System.EventHandler(this.cmb_sexo_SelectedIndexChanged);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(81, 215);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(176, 20);
            this.txt_email.TabIndex = 19;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(81, 193);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(133, 20);
            this.txt_telefono.TabIndex = 18;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(81, 170);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(133, 20);
            this.txt_direccion.TabIndex = 17;
            // 
            // txt_Sexo
            // 
            this.txt_Sexo.Enabled = false;
            this.txt_Sexo.Location = new System.Drawing.Point(81, 146);
            this.txt_Sexo.Name = "txt_Sexo";
            this.txt_Sexo.Size = new System.Drawing.Size(43, 20);
            this.txt_Sexo.TabIndex = 16;
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(81, 124);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(133, 20);
            this.txt_edad.TabIndex = 15;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(81, 99);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(133, 20);
            this.txt_apellido.TabIndex = 14;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(81, 77);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(133, 20);
            this.txt_nombre.TabIndex = 13;
            // 
            // txt_dni_alta
            // 
            this.txt_dni_alta.Location = new System.Drawing.Point(81, 55);
            this.txt_dni_alta.Name = "txt_dni_alta";
            this.txt_dni_alta.Size = new System.Drawing.Size(133, 20);
            this.txt_dni_alta.TabIndex = 12;
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Checked = true;
            this.rb_todos.Location = new System.Drawing.Point(158, 31);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(55, 17);
            this.rb_todos.TabIndex = 6;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos";
            this.rb_todos.UseVisualStyleBackColor = true;
            this.rb_todos.CheckedChanged += new System.EventHandler(this.rb_todos_CheckedChanged_1);
            this.rb_todos.Click += new System.EventHandler(this.rb_todos_CheckedChanged);
            // 
            // rb_cliente
            // 
            this.rb_cliente.AutoSize = true;
            this.rb_cliente.Location = new System.Drawing.Point(20, 31);
            this.rb_cliente.Name = "rb_cliente";
            this.rb_cliente.Size = new System.Drawing.Size(57, 17);
            this.rb_cliente.TabIndex = 5;
            this.rb_cliente.Text = "Cliente";
            this.rb_cliente.UseVisualStyleBackColor = true;
            this.rb_cliente.CheckedChanged += new System.EventHandler(this.rb_cliente_CheckedChanged_1);
            this.rb_cliente.Click += new System.EventHandler(this.rb_cliente_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DNI Cliente:";
            // 
            // txt_dni_busqueda
            // 
            this.txt_dni_busqueda.Enabled = false;
            this.txt_dni_busqueda.Location = new System.Drawing.Point(125, 74);
            this.txt_dni_busqueda.Name = "txt_dni_busqueda";
            this.txt_dni_busqueda.Size = new System.Drawing.Size(131, 20);
            this.txt_dni_busqueda.TabIndex = 3;
            // 
            // btn_confirmarCliente
            // 
            this.btn_confirmarCliente.Location = new System.Drawing.Point(48, 240);
            this.btn_confirmarCliente.Name = "btn_confirmarCliente";
            this.btn_confirmarCliente.Size = new System.Drawing.Size(211, 29);
            this.btn_confirmarCliente.TabIndex = 11;
            this.btn_confirmarCliente.Text = "CONFIRMAR";
            this.btn_confirmarCliente.UseVisualStyleBackColor = true;
            this.btn_confirmarCliente.Click += new System.EventHandler(this.btn_confirmarCliente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Direeción:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dg_Clientes);
            this.groupBox3.Location = new System.Drawing.Point(343, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(692, 275);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CLIENTES";
            // 
            // dg_Clientes
            // 
            this.dg_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Clientes.Location = new System.Drawing.Point(33, 19);
            this.dg_Clientes.Name = "dg_Clientes";
            this.dg_Clientes.Size = new System.Drawing.Size(627, 242);
            this.dg_Clientes.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Edad:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnMostrar);
            this.groupBox4.Controls.Add(this.dg_historial);
            this.groupBox4.Location = new System.Drawing.Point(342, 313);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(693, 190);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "HISTORIAL DE VENTAS";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(35, 161);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(103, 23);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dg_historial
            // 
            this.dg_historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_historial.Location = new System.Drawing.Point(35, 31);
            this.dg_historial.Name = "dg_historial";
            this.dg_historial.Size = new System.Drawing.Size(626, 121);
            this.dg_historial.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(20, 129);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(103, 23);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // rb_baja
            // 
            this.rb_baja.AutoSize = true;
            this.rb_baja.Enabled = false;
            this.rb_baja.Location = new System.Drawing.Point(213, 28);
            this.rb_baja.Name = "rb_baja";
            this.rb_baja.Size = new System.Drawing.Size(46, 17);
            this.rb_baja.TabIndex = 2;
            this.rb_baja.Text = "Baja";
            this.rb_baja.UseVisualStyleBackColor = true;
            // 
            // rb_modificar
            // 
            this.rb_modificar.AutoSize = true;
            this.rb_modificar.Enabled = false;
            this.rb_modificar.Location = new System.Drawing.Point(102, 28);
            this.rb_modificar.Name = "rb_modificar";
            this.rb_modificar.Size = new System.Drawing.Size(68, 17);
            this.rb_modificar.TabIndex = 1;
            this.rb_modificar.Text = "Modificar";
            this.rb_modificar.UseVisualStyleBackColor = true;
            // 
            // rb_alta
            // 
            this.rb_alta.AutoSize = true;
            this.rb_alta.Checked = true;
            this.rb_alta.Location = new System.Drawing.Point(16, 28);
            this.rb_alta.Name = "rb_alta";
            this.rb_alta.Size = new System.Drawing.Size(43, 17);
            this.rb_alta.TabIndex = 0;
            this.rb_alta.TabStop = true;
            this.rb_alta.Text = "Alta";
            this.rb_alta.UseVisualStyleBackColor = true;
            this.rb_alta.Click += new System.EventHandler(this.rb_alta_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.rb_todos);
            this.groupBox2.Controls.Add(this.rb_cliente);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_dni_busqueda);
            this.groupBox2.Controls.Add(this.btn_buscar);
            this.groupBox2.Location = new System.Drawing.Point(13, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 190);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSQUEDA DE CLIENTES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_sexo);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_telefono);
            this.groupBox1.Controls.Add(this.txt_direccion);
            this.groupBox1.Controls.Add(this.txt_Sexo);
            this.groupBox1.Controls.Add(this.txt_edad);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_dni_alta);
            this.groupBox1.Controls.Add(this.btn_confirmarCliente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rb_baja);
            this.groupBox1.Controls.Add(this.rb_modificar);
            this.groupBox1.Controls.Add(this.rb_alta);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 275);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ALTA DE CLIENTES";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 521);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Clientes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_historial)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rb_Ord_Apellido;
        private System.Windows.Forms.RadioButton rb_Ord_fecha;
        private System.Windows.Forms.ComboBox cmb_sexo;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_Sexo;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_dni_alta;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.RadioButton rb_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dni_busqueda;
        private System.Windows.Forms.Button btn_confirmarCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dg_Clientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dg_historial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_baja;
        private System.Windows.Forms.RadioButton rb_modificar;
        private System.Windows.Forms.RadioButton rb_alta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrar;
    }
}