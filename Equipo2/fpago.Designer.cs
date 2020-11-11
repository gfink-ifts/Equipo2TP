namespace Agencia_de_Viajes
{
    partial class fpago
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
            this.dgFormasDePago = new System.Windows.Forms.DataGridView();
            this.txt_formaDePago = new System.Windows.Forms.TextBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnMostar = new System.Windows.Forms.Button();
            this.rbAgregar = new System.Windows.Forms.RadioButton();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.cbo_formaDePago = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgFormasDePago)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFormasDePago
            // 
            this.dgFormasDePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFormasDePago.Location = new System.Drawing.Point(12, 94);
            this.dgFormasDePago.Name = "dgFormasDePago";
            this.dgFormasDePago.RowHeadersWidth = 5;
            this.dgFormasDePago.Size = new System.Drawing.Size(489, 279);
            this.dgFormasDePago.TabIndex = 0;
            // 
            // txt_formaDePago
            // 
            this.txt_formaDePago.Location = new System.Drawing.Point(235, 50);
            this.txt_formaDePago.Name = "txt_formaDePago";
            this.txt_formaDePago.Size = new System.Drawing.Size(181, 20);
            this.txt_formaDePago.TabIndex = 1;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(117, 12);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(99, 32);
            this.btnEjecutar.TabIndex = 2;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnMostar
            // 
            this.btnMostar.Location = new System.Drawing.Point(117, 50);
            this.btnMostar.Name = "btnMostar";
            this.btnMostar.Size = new System.Drawing.Size(99, 32);
            this.btnMostar.TabIndex = 3;
            this.btnMostar.Text = "Mostrar";
            this.btnMostar.UseVisualStyleBackColor = true;
            this.btnMostar.Click += new System.EventHandler(this.btnMostar_Click);
            // 
            // rbAgregar
            // 
            this.rbAgregar.AutoSize = true;
            this.rbAgregar.Checked = true;
            this.rbAgregar.Location = new System.Drawing.Point(22, 12);
            this.rbAgregar.Name = "rbAgregar";
            this.rbAgregar.Size = new System.Drawing.Size(62, 17);
            this.rbAgregar.TabIndex = 4;
            this.rbAgregar.TabStop = true;
            this.rbAgregar.Text = "Agregar";
            this.rbAgregar.UseVisualStyleBackColor = true;
            this.rbAgregar.CheckedChanged += new System.EventHandler(this.rbAgregar_CheckedChanged);
            // 
            // rbModificar
            // 
            this.rbModificar.AutoSize = true;
            this.rbModificar.Location = new System.Drawing.Point(23, 35);
            this.rbModificar.Name = "rbModificar";
            this.rbModificar.Size = new System.Drawing.Size(68, 17);
            this.rbModificar.TabIndex = 5;
            this.rbModificar.Text = "Modificar";
            this.rbModificar.UseVisualStyleBackColor = true;
            this.rbModificar.CheckedChanged += new System.EventHandler(this.rbModificar_CheckedChanged);
            // 
            // rbEliminar
            // 
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.Location = new System.Drawing.Point(23, 58);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(61, 17);
            this.rbEliminar.TabIndex = 6;
            this.rbEliminar.Text = "Eliminar";
            this.rbEliminar.UseVisualStyleBackColor = true;
            this.rbEliminar.CheckedChanged += new System.EventHandler(this.rbEliminar_CheckedChanged);
            // 
            // cbo_formaDePago
            // 
            this.cbo_formaDePago.Enabled = false;
            this.cbo_formaDePago.FormattingEnabled = true;
            this.cbo_formaDePago.Location = new System.Drawing.Point(235, 23);
            this.cbo_formaDePago.Name = "cbo_formaDePago";
            this.cbo_formaDePago.Size = new System.Drawing.Size(181, 21);
            this.cbo_formaDePago.TabIndex = 7;
            // 
            // fpago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 385);
            this.Controls.Add(this.cbo_formaDePago);
            this.Controls.Add(this.rbEliminar);
            this.Controls.Add(this.rbModificar);
            this.Controls.Add(this.rbAgregar);
            this.Controls.Add(this.btnMostar);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.txt_formaDePago);
            this.Controls.Add(this.dgFormasDePago);
            this.Name = "fpago";
            this.Text = "FormasDePago";
            this.Load += new System.EventHandler(this.FormasDePago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFormasDePago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFormasDePago;
        private System.Windows.Forms.TextBox txt_formaDePago;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnMostar;
        private System.Windows.Forms.RadioButton rbAgregar;
        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.ComboBox cbo_formaDePago;
    }
}