namespace Agencia_de_Viajes
{
    partial class ABMDestinos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_abmPais = new System.Windows.Forms.ComboBox();
            this.btn_eliminarPais = new System.Windows.Forms.Button();
            this.btn_modificarPais = new System.Windows.Forms.Button();
            this.btn_agregarPais = new System.Windows.Forms.Button();
            this.cbo_idPais = new System.Windows.Forms.ComboBox();
            this.lbl_idPais = new System.Windows.Forms.Label();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_eliminarCiudad = new System.Windows.Forms.Button();
            this.btn_modificarCiudad = new System.Windows.Forms.Button();
            this.btn_agregarCiudad = new System.Windows.Forms.Button();
            this.cbo_idCiudad = new System.Windows.Forms.ComboBox();
            this.lbl_idCiudad = new System.Windows.Forms.Label();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.cbo_abmCiudad = new System.Windows.Forms.ComboBox();
            this.dgDestinos = new System.Windows.Forms.DataGridView();
            this.btn_mostrarPaises = new System.Windows.Forms.Button();
            this.btn_mostrarCiudades = new System.Windows.Forms.Button();
            this.btn_buscarDestino = new System.Windows.Forms.Button();
            this.txt_buscarDestino = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDestinos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_abmPais);
            this.groupBox1.Controls.Add(this.btn_eliminarPais);
            this.groupBox1.Controls.Add(this.btn_modificarPais);
            this.groupBox1.Controls.Add(this.btn_agregarPais);
            this.groupBox1.Controls.Add(this.cbo_idPais);
            this.groupBox1.Controls.Add(this.lbl_idPais);
            this.groupBox1.Controls.Add(this.lbl_pais);
            this.groupBox1.Controls.Add(this.txt_pais);
            this.groupBox1.Location = new System.Drawing.Point(30, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PAISES";
            // 
            // cbo_abmPais
            // 
            this.cbo_abmPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_abmPais.FormattingEnabled = true;
            this.cbo_abmPais.Items.AddRange(new object[] {
            "Agregar Pais",
            "Modificar Pais",
            "Eliminar Pais"});
            this.cbo_abmPais.Location = new System.Drawing.Point(81, 37);
            this.cbo_abmPais.Name = "cbo_abmPais";
            this.cbo_abmPais.Size = new System.Drawing.Size(114, 21);
            this.cbo_abmPais.TabIndex = 9;
            this.cbo_abmPais.SelectedIndexChanged += new System.EventHandler(this.cbo_abmPais_SelectedIndexChanged);
            // 
            // btn_eliminarPais
            // 
            this.btn_eliminarPais.Location = new System.Drawing.Point(174, 154);
            this.btn_eliminarPais.Name = "btn_eliminarPais";
            this.btn_eliminarPais.Size = new System.Drawing.Size(72, 29);
            this.btn_eliminarPais.TabIndex = 8;
            this.btn_eliminarPais.Text = "Eliminar";
            this.btn_eliminarPais.UseVisualStyleBackColor = true;
            this.btn_eliminarPais.Click += new System.EventHandler(this.btn_eliminarPais_Click);
            // 
            // btn_modificarPais
            // 
            this.btn_modificarPais.Location = new System.Drawing.Point(96, 154);
            this.btn_modificarPais.Name = "btn_modificarPais";
            this.btn_modificarPais.Size = new System.Drawing.Size(72, 29);
            this.btn_modificarPais.TabIndex = 7;
            this.btn_modificarPais.Text = "Modificar";
            this.btn_modificarPais.UseVisualStyleBackColor = true;
            this.btn_modificarPais.Click += new System.EventHandler(this.btn_modificarPais_Click);
            // 
            // btn_agregarPais
            // 
            this.btn_agregarPais.Location = new System.Drawing.Point(18, 154);
            this.btn_agregarPais.Name = "btn_agregarPais";
            this.btn_agregarPais.Size = new System.Drawing.Size(72, 29);
            this.btn_agregarPais.TabIndex = 6;
            this.btn_agregarPais.Text = "Agregar";
            this.btn_agregarPais.UseVisualStyleBackColor = true;
            this.btn_agregarPais.Click += new System.EventHandler(this.btn_agregarPais_Click);
            // 
            // cbo_idPais
            // 
            this.cbo_idPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_idPais.FormattingEnabled = true;
            this.cbo_idPais.Location = new System.Drawing.Point(81, 87);
            this.cbo_idPais.Name = "cbo_idPais";
            this.cbo_idPais.Size = new System.Drawing.Size(142, 21);
            this.cbo_idPais.TabIndex = 5;
            // 
            // lbl_idPais
            // 
            this.lbl_idPais.AutoSize = true;
            this.lbl_idPais.Location = new System.Drawing.Point(17, 91);
            this.lbl_idPais.Name = "lbl_idPais";
            this.lbl_idPais.Size = new System.Drawing.Size(48, 13);
            this.lbl_idPais.TabIndex = 4;
            this.lbl_idPais.Text = "ID PAIS:";
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Location = new System.Drawing.Point(31, 117);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(34, 13);
            this.lbl_pais.TabIndex = 2;
            this.lbl_pais.Text = "PAIS:";
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(81, 114);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(142, 20);
            this.txt_pais.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_eliminarCiudad);
            this.groupBox2.Controls.Add(this.btn_modificarCiudad);
            this.groupBox2.Controls.Add(this.btn_agregarCiudad);
            this.groupBox2.Controls.Add(this.cbo_idCiudad);
            this.groupBox2.Controls.Add(this.lbl_idCiudad);
            this.groupBox2.Controls.Add(this.lbl_ciudad);
            this.groupBox2.Controls.Add(this.txt_ciudad);
            this.groupBox2.Controls.Add(this.cbo_abmCiudad);
            this.groupBox2.Location = new System.Drawing.Point(30, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CIUDADES";
            // 
            // btn_eliminarCiudad
            // 
            this.btn_eliminarCiudad.Location = new System.Drawing.Point(174, 154);
            this.btn_eliminarCiudad.Name = "btn_eliminarCiudad";
            this.btn_eliminarCiudad.Size = new System.Drawing.Size(72, 29);
            this.btn_eliminarCiudad.TabIndex = 15;
            this.btn_eliminarCiudad.Text = "Eliminar";
            this.btn_eliminarCiudad.UseVisualStyleBackColor = true;
            this.btn_eliminarCiudad.Click += new System.EventHandler(this.btn_eliminarCiudad_Click);
            // 
            // btn_modificarCiudad
            // 
            this.btn_modificarCiudad.Location = new System.Drawing.Point(96, 154);
            this.btn_modificarCiudad.Name = "btn_modificarCiudad";
            this.btn_modificarCiudad.Size = new System.Drawing.Size(72, 29);
            this.btn_modificarCiudad.TabIndex = 14;
            this.btn_modificarCiudad.Text = "Modificar";
            this.btn_modificarCiudad.UseVisualStyleBackColor = true;
            this.btn_modificarCiudad.Click += new System.EventHandler(this.btn_modificarCiudad_Click);
            // 
            // btn_agregarCiudad
            // 
            this.btn_agregarCiudad.Location = new System.Drawing.Point(18, 154);
            this.btn_agregarCiudad.Name = "btn_agregarCiudad";
            this.btn_agregarCiudad.Size = new System.Drawing.Size(72, 29);
            this.btn_agregarCiudad.TabIndex = 13;
            this.btn_agregarCiudad.Text = "Agregar";
            this.btn_agregarCiudad.UseVisualStyleBackColor = true;
            this.btn_agregarCiudad.Click += new System.EventHandler(this.btn_agregarCiudad_Click_1);
            // 
            // cbo_idCiudad
            // 
            this.cbo_idCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_idCiudad.FormattingEnabled = true;
            this.cbo_idCiudad.Location = new System.Drawing.Point(91, 87);
            this.cbo_idCiudad.Name = "cbo_idCiudad";
            this.cbo_idCiudad.Size = new System.Drawing.Size(142, 21);
            this.cbo_idCiudad.TabIndex = 12;
            // 
            // lbl_idCiudad
            // 
            this.lbl_idCiudad.AutoSize = true;
            this.lbl_idCiudad.Location = new System.Drawing.Point(16, 91);
            this.lbl_idCiudad.Name = "lbl_idCiudad";
            this.lbl_idCiudad.Size = new System.Drawing.Size(65, 13);
            this.lbl_idCiudad.TabIndex = 11;
            this.lbl_idCiudad.Text = "ID CIUDAD:";
            // 
            // lbl_ciudad
            // 
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.Location = new System.Drawing.Point(30, 117);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(51, 13);
            this.lbl_ciudad.TabIndex = 10;
            this.lbl_ciudad.Text = "CIUDAD:";
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(91, 114);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(142, 20);
            this.txt_ciudad.TabIndex = 9;
            // 
            // cbo_abmCiudad
            // 
            this.cbo_abmCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_abmCiudad.FormattingEnabled = true;
            this.cbo_abmCiudad.Items.AddRange(new object[] {
            "Agregar Ciudad",
            "Modificar Ciudad",
            "Eliminar Ciudad"});
            this.cbo_abmCiudad.Location = new System.Drawing.Point(91, 37);
            this.cbo_abmCiudad.Name = "cbo_abmCiudad";
            this.cbo_abmCiudad.Size = new System.Drawing.Size(113, 21);
            this.cbo_abmCiudad.TabIndex = 0;
            this.cbo_abmCiudad.SelectedIndexChanged += new System.EventHandler(this.cbo_abmCiudad_SelectedIndexChanged);
            // 
            // dgDestinos
            // 
            this.dgDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDestinos.Location = new System.Drawing.Point(306, 65);
            this.dgDestinos.Name = "dgDestinos";
            this.dgDestinos.Size = new System.Drawing.Size(261, 339);
            this.dgDestinos.TabIndex = 2;
            // 
            // btn_mostrarPaises
            // 
            this.btn_mostrarPaises.Location = new System.Drawing.Point(306, 416);
            this.btn_mostrarPaises.Name = "btn_mostrarPaises";
            this.btn_mostrarPaises.Size = new System.Drawing.Size(123, 33);
            this.btn_mostrarPaises.TabIndex = 3;
            this.btn_mostrarPaises.Text = "Mostar Paises";
            this.btn_mostrarPaises.UseVisualStyleBackColor = true;
            this.btn_mostrarPaises.Click += new System.EventHandler(this.btn_mostrarPaises_Click);
            // 
            // btn_mostrarCiudades
            // 
            this.btn_mostrarCiudades.Location = new System.Drawing.Point(444, 416);
            this.btn_mostrarCiudades.Name = "btn_mostrarCiudades";
            this.btn_mostrarCiudades.Size = new System.Drawing.Size(123, 33);
            this.btn_mostrarCiudades.TabIndex = 4;
            this.btn_mostrarCiudades.Text = "Mostar Ciudades";
            this.btn_mostrarCiudades.UseVisualStyleBackColor = true;
            this.btn_mostrarCiudades.Click += new System.EventHandler(this.btn_mostrarCiudades_Click);
            // 
            // btn_buscarDestino
            // 
            this.btn_buscarDestino.Location = new System.Drawing.Point(306, 23);
            this.btn_buscarDestino.Name = "btn_buscarDestino";
            this.btn_buscarDestino.Size = new System.Drawing.Size(111, 36);
            this.btn_buscarDestino.TabIndex = 5;
            this.btn_buscarDestino.Text = "Buscar Pais / Ciudad";
            this.btn_buscarDestino.UseVisualStyleBackColor = true;
            this.btn_buscarDestino.Click += new System.EventHandler(this.btn_buscarDestino_Click);
            // 
            // txt_buscarDestino
            // 
            this.txt_buscarDestino.Location = new System.Drawing.Point(426, 32);
            this.txt_buscarDestino.Name = "txt_buscarDestino";
            this.txt_buscarDestino.Size = new System.Drawing.Size(141, 20);
            this.txt_buscarDestino.TabIndex = 6;
            // 
            // ABMDestinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 457);
            this.Controls.Add(this.txt_buscarDestino);
            this.Controls.Add(this.btn_buscarDestino);
            this.Controls.Add(this.btn_mostrarCiudades);
            this.Controls.Add(this.btn_mostrarPaises);
            this.Controls.Add(this.dgDestinos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ABMDestinos";
            this.Text = "ABMDestinos";
            this.Load += new System.EventHandler(this.ABMDestinos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDestinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_eliminarPais;
        private System.Windows.Forms.Button btn_modificarPais;
        private System.Windows.Forms.Button btn_agregarPais;
        private System.Windows.Forms.ComboBox cbo_idPais;
        private System.Windows.Forms.Label lbl_idPais;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.ComboBox cbo_abmPais;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_eliminarCiudad;
        private System.Windows.Forms.Button btn_modificarCiudad;
        private System.Windows.Forms.Button btn_agregarCiudad;
        private System.Windows.Forms.ComboBox cbo_idCiudad;
        private System.Windows.Forms.Label lbl_idCiudad;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.ComboBox cbo_abmCiudad;
        private System.Windows.Forms.DataGridView dgDestinos;
        private System.Windows.Forms.Button btn_mostrarPaises;
        private System.Windows.Forms.Button btn_mostrarCiudades;
        private System.Windows.Forms.Button btn_buscarDestino;
        private System.Windows.Forms.TextBox txt_buscarDestino;
    }
}