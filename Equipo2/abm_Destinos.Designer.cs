namespace Agencia_de_Viajes
{
    partial class abm_Destinos
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.txt_buscarDestino = new System.Windows.Forms.TextBox();
            this.btn_buscarDestino = new System.Windows.Forms.Button();
            this.btn_mostrarCiudades = new System.Windows.Forms.Button();
            this.btn_mostrarPaises = new System.Windows.Forms.Button();
            this.dgDestinos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_id_pais = new System.Windows.Forms.Label();
            this.rbAltaPais = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbModPais = new System.Windows.Forms.RadioButton();
            this.rbBajaPais = new System.Windows.Forms.RadioButton();
            this.btn_confirmarPais = new System.Windows.Forms.Button();
            this.cbo_pais = new System.Windows.Forms.ComboBox();
            this.lbl_idPais = new System.Windows.Forms.Label();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_id_ciudad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbModCiudad = new System.Windows.Forms.RadioButton();
            this.rbBajaCiudad = new System.Windows.Forms.RadioButton();
            this.rbAltaCiudad = new System.Windows.Forms.RadioButton();
            this.btn_confirmarCiudad = new System.Windows.Forms.Button();
            this.cbo_ciudad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDestinos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(529, 405);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(95, 33);
            this.btn_Salir.TabIndex = 15;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // txt_buscarDestino
            // 
            this.txt_buscarDestino.Location = new System.Drawing.Point(449, 21);
            this.txt_buscarDestino.Name = "txt_buscarDestino";
            this.txt_buscarDestino.Size = new System.Drawing.Size(175, 20);
            this.txt_buscarDestino.TabIndex = 14;
            // 
            // btn_buscarDestino
            // 
            this.btn_buscarDestino.Location = new System.Drawing.Point(300, 20);
            this.btn_buscarDestino.Name = "btn_buscarDestino";
            this.btn_buscarDestino.Size = new System.Drawing.Size(143, 21);
            this.btn_buscarDestino.TabIndex = 13;
            this.btn_buscarDestino.Text = "Buscar Pais / Ciudad";
            this.btn_buscarDestino.UseVisualStyleBackColor = true;
            this.btn_buscarDestino.Click += new System.EventHandler(this.btn_buscarDestino_Click);
            // 
            // btn_mostrarCiudades
            // 
            this.btn_mostrarCiudades.Location = new System.Drawing.Point(414, 405);
            this.btn_mostrarCiudades.Name = "btn_mostrarCiudades";
            this.btn_mostrarCiudades.Size = new System.Drawing.Size(95, 33);
            this.btn_mostrarCiudades.TabIndex = 12;
            this.btn_mostrarCiudades.Text = "Mostar Ciudades";
            this.btn_mostrarCiudades.UseVisualStyleBackColor = true;
            this.btn_mostrarCiudades.Click += new System.EventHandler(this.btn_mostrarCiudades_Click);
            // 
            // btn_mostrarPaises
            // 
            this.btn_mostrarPaises.Location = new System.Drawing.Point(300, 405);
            this.btn_mostrarPaises.Name = "btn_mostrarPaises";
            this.btn_mostrarPaises.Size = new System.Drawing.Size(95, 33);
            this.btn_mostrarPaises.TabIndex = 11;
            this.btn_mostrarPaises.Text = "Mostar Paises";
            this.btn_mostrarPaises.UseVisualStyleBackColor = true;
            this.btn_mostrarPaises.Click += new System.EventHandler(this.btn_mostrarPaises_Click);
            // 
            // dgDestinos
            // 
            this.dgDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDestinos.Location = new System.Drawing.Point(300, 54);
            this.dgDestinos.Name = "dgDestinos";
            this.dgDestinos.Size = new System.Drawing.Size(324, 336);
            this.dgDestinos.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_id_pais);
            this.groupBox1.Controls.Add(this.rbAltaPais);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbModPais);
            this.groupBox1.Controls.Add(this.rbBajaPais);
            this.groupBox1.Controls.Add(this.btn_confirmarPais);
            this.groupBox1.Controls.Add(this.cbo_pais);
            this.groupBox1.Controls.Add(this.lbl_idPais);
            this.groupBox1.Controls.Add(this.lbl_pais);
            this.groupBox1.Controls.Add(this.txt_pais);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 202);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PAISES";
            // 
            // lbl_id_pais
            // 
            this.lbl_id_pais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_id_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_pais.Location = new System.Drawing.Point(72, 89);
            this.lbl_id_pais.Name = "lbl_id_pais";
            this.lbl_id_pais.Size = new System.Drawing.Size(146, 19);
            this.lbl_id_pais.TabIndex = 13;
            this.lbl_id_pais.Text = "     ";
            // 
            // rbAltaPais
            // 
            this.rbAltaPais.AutoSize = true;
            this.rbAltaPais.Checked = true;
            this.rbAltaPais.Location = new System.Drawing.Point(35, 19);
            this.rbAltaPais.Name = "rbAltaPais";
            this.rbAltaPais.Size = new System.Drawing.Size(43, 17);
            this.rbAltaPais.TabIndex = 12;
            this.rbAltaPais.TabStop = true;
            this.rbAltaPais.Text = "Alta";
            this.rbAltaPais.UseVisualStyleBackColor = true;
            this.rbAltaPais.CheckedChanged += new System.EventHandler(this.rbAltaPais_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID:";
            // 
            // rbModPais
            // 
            this.rbModPais.AutoSize = true;
            this.rbModPais.Location = new System.Drawing.Point(96, 19);
            this.rbModPais.Name = "rbModPais";
            this.rbModPais.Size = new System.Drawing.Size(85, 17);
            this.rbModPais.TabIndex = 9;
            this.rbModPais.Text = "Modificación";
            this.rbModPais.UseVisualStyleBackColor = true;
            this.rbModPais.CheckedChanged += new System.EventHandler(this.rbModPais_CheckedChanged);
            // 
            // rbBajaPais
            // 
            this.rbBajaPais.AutoSize = true;
            this.rbBajaPais.Location = new System.Drawing.Point(199, 19);
            this.rbBajaPais.Name = "rbBajaPais";
            this.rbBajaPais.Size = new System.Drawing.Size(46, 17);
            this.rbBajaPais.TabIndex = 8;
            this.rbBajaPais.Text = "Baja";
            this.rbBajaPais.UseVisualStyleBackColor = true;
            this.rbBajaPais.CheckedChanged += new System.EventHandler(this.rbBajaPais_CheckedChanged);
            // 
            // btn_confirmarPais
            // 
            this.btn_confirmarPais.Location = new System.Drawing.Point(18, 156);
            this.btn_confirmarPais.Name = "btn_confirmarPais";
            this.btn_confirmarPais.Size = new System.Drawing.Size(211, 29);
            this.btn_confirmarPais.TabIndex = 6;
            this.btn_confirmarPais.Text = "CONFIRMAR";
            this.btn_confirmarPais.UseVisualStyleBackColor = true;
            this.btn_confirmarPais.Click += new System.EventHandler(this.btn_confirmarPais_Click);
            // 
            // cbo_pais
            // 
            this.cbo_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_pais.Enabled = false;
            this.cbo_pais.FormattingEnabled = true;
            this.cbo_pais.Location = new System.Drawing.Point(97, 50);
            this.cbo_pais.Name = "cbo_pais";
            this.cbo_pais.Size = new System.Drawing.Size(132, 21);
            this.cbo_pais.TabIndex = 5;
            this.cbo_pais.SelectedIndexChanged += new System.EventHandler(this.cbo_pais_SelectedIndexChanged);
            // 
            // lbl_idPais
            // 
            this.lbl_idPais.AutoSize = true;
            this.lbl_idPais.Location = new System.Drawing.Point(15, 53);
            this.lbl_idPais.Name = "lbl_idPais";
            this.lbl_idPais.Size = new System.Drawing.Size(76, 13);
            this.lbl_idPais.TabIndex = 4;
            this.lbl_idPais.Text = "ELEGIR PAIS:";
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Location = new System.Drawing.Point(32, 118);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(34, 13);
            this.lbl_pais.TabIndex = 2;
            this.lbl_pais.Text = "PAIS:";
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(72, 115);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(146, 20);
            this.txt_pais.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_id_ciudad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rbModCiudad);
            this.groupBox2.Controls.Add(this.rbBajaCiudad);
            this.groupBox2.Controls.Add(this.rbAltaCiudad);
            this.groupBox2.Controls.Add(this.btn_confirmarCiudad);
            this.groupBox2.Controls.Add(this.cbo_ciudad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_ciudad);
            this.groupBox2.Location = new System.Drawing.Point(24, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 202);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CIUDADES";
            // 
            // lbl_id_ciudad
            // 
            this.lbl_id_ciudad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_id_ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_ciudad.Location = new System.Drawing.Point(72, 89);
            this.lbl_id_ciudad.Name = "lbl_id_ciudad";
            this.lbl_id_ciudad.Size = new System.Drawing.Size(146, 19);
            this.lbl_id_ciudad.TabIndex = 14;
            this.lbl_id_ciudad.Text = "     ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID:";
            // 
            // rbModCiudad
            // 
            this.rbModCiudad.AutoSize = true;
            this.rbModCiudad.Location = new System.Drawing.Point(96, 19);
            this.rbModCiudad.Name = "rbModCiudad";
            this.rbModCiudad.Size = new System.Drawing.Size(85, 17);
            this.rbModCiudad.TabIndex = 9;
            this.rbModCiudad.Text = "Modificación";
            this.rbModCiudad.UseVisualStyleBackColor = true;
            this.rbModCiudad.CheckedChanged += new System.EventHandler(this.rbModCiudad_CheckedChanged);
            // 
            // rbBajaCiudad
            // 
            this.rbBajaCiudad.AutoSize = true;
            this.rbBajaCiudad.Location = new System.Drawing.Point(199, 19);
            this.rbBajaCiudad.Name = "rbBajaCiudad";
            this.rbBajaCiudad.Size = new System.Drawing.Size(46, 17);
            this.rbBajaCiudad.TabIndex = 8;
            this.rbBajaCiudad.Text = "Baja";
            this.rbBajaCiudad.UseVisualStyleBackColor = true;
            this.rbBajaCiudad.CheckedChanged += new System.EventHandler(this.rbBajaCiudad_CheckedChanged);
            // 
            // rbAltaCiudad
            // 
            this.rbAltaCiudad.AutoSize = true;
            this.rbAltaCiudad.Checked = true;
            this.rbAltaCiudad.Location = new System.Drawing.Point(35, 19);
            this.rbAltaCiudad.Name = "rbAltaCiudad";
            this.rbAltaCiudad.Size = new System.Drawing.Size(43, 17);
            this.rbAltaCiudad.TabIndex = 7;
            this.rbAltaCiudad.TabStop = true;
            this.rbAltaCiudad.Text = "Alta";
            this.rbAltaCiudad.UseVisualStyleBackColor = true;
            this.rbAltaCiudad.CheckedChanged += new System.EventHandler(this.rbAltaCiudad_CheckedChanged);
            // 
            // btn_confirmarCiudad
            // 
            this.btn_confirmarCiudad.Location = new System.Drawing.Point(18, 156);
            this.btn_confirmarCiudad.Name = "btn_confirmarCiudad";
            this.btn_confirmarCiudad.Size = new System.Drawing.Size(211, 29);
            this.btn_confirmarCiudad.TabIndex = 6;
            this.btn_confirmarCiudad.Text = "CONFIRMAR";
            this.btn_confirmarCiudad.UseVisualStyleBackColor = true;
            this.btn_confirmarCiudad.Click += new System.EventHandler(this.btn_confirmarCiudad_Click);
            // 
            // cbo_ciudad
            // 
            this.cbo_ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ciudad.Enabled = false;
            this.cbo_ciudad.FormattingEnabled = true;
            this.cbo_ciudad.Location = new System.Drawing.Point(97, 50);
            this.cbo_ciudad.Name = "cbo_ciudad";
            this.cbo_ciudad.Size = new System.Drawing.Size(132, 21);
            this.cbo_ciudad.TabIndex = 5;
            this.cbo_ciudad.SelectedIndexChanged += new System.EventHandler(this.cbo_ciudad_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ELEGIR CIUDAD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CIUDAD:";
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(72, 115);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(146, 20);
            this.txt_ciudad.TabIndex = 1;
            // 
            // abm_Destinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 459);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.txt_buscarDestino);
            this.Controls.Add(this.btn_buscarDestino);
            this.Controls.Add(this.btn_mostrarCiudades);
            this.Controls.Add(this.btn_mostrarPaises);
            this.Controls.Add(this.dgDestinos);
            this.Controls.Add(this.groupBox1);
            this.Name = "abm_Destinos";
            this.Text = "ABM DESTINOS";
            this.Load += new System.EventHandler(this.abm_Destinos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDestinos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.TextBox txt_buscarDestino;
        private System.Windows.Forms.Button btn_buscarDestino;
        private System.Windows.Forms.Button btn_mostrarCiudades;
        private System.Windows.Forms.Button btn_mostrarPaises;
        private System.Windows.Forms.DataGridView dgDestinos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_confirmarPais;
        private System.Windows.Forms.ComboBox cbo_pais;
        private System.Windows.Forms.Label lbl_idPais;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.RadioButton rbModPais;
        private System.Windows.Forms.RadioButton rbBajaPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbModCiudad;
        private System.Windows.Forms.RadioButton rbBajaCiudad;
        private System.Windows.Forms.RadioButton rbAltaCiudad;
        private System.Windows.Forms.Button btn_confirmarCiudad;
        private System.Windows.Forms.ComboBox cbo_ciudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.RadioButton rbAltaPais;
        private System.Windows.Forms.Label lbl_id_pais;
        private System.Windows.Forms.Label lbl_id_ciudad;
    }
}