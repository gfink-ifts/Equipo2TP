namespace Agencia_de_Viajes
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_tipoDeCambio = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_formasDePago = new System.Windows.Forms.Button();
            this.Paquetes = new System.Windows.Forms.Button();
            this.Clientes = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_destinos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(304, 274);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(251, 45);
            this.btn_salir.TabIndex = 16;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_tipoDeCambio
            // 
            this.btn_tipoDeCambio.Location = new System.Drawing.Point(27, 274);
            this.btn_tipoDeCambio.Name = "btn_tipoDeCambio";
            this.btn_tipoDeCambio.Size = new System.Drawing.Size(251, 45);
            this.btn_tipoDeCambio.TabIndex = 11;
            this.btn_tipoDeCambio.Text = "Tipo de Cambio";
            this.btn_tipoDeCambio.UseVisualStyleBackColor = true;
            this.btn_tipoDeCambio.Click += new System.EventHandler(this.btn_tipoDeCambio_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(400, 63);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 111);
            this.button6.TabIndex = 15;
            this.button6.Text = "Ventas";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_formasDePago
            // 
            this.btn_formasDePago.Location = new System.Drawing.Point(304, 214);
            this.btn_formasDePago.Name = "btn_formasDePago";
            this.btn_formasDePago.Size = new System.Drawing.Size(251, 45);
            this.btn_formasDePago.TabIndex = 14;
            this.btn_formasDePago.Text = "Formas de Pago";
            this.btn_formasDePago.UseVisualStyleBackColor = true;
            this.btn_formasDePago.Click += new System.EventHandler(this.btn_formasDePago_Click);
            // 
            // Paquetes
            // 
            this.Paquetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paquetes.Location = new System.Drawing.Point(214, 63);
            this.Paquetes.Name = "Paquetes";
            this.Paquetes.Size = new System.Drawing.Size(155, 111);
            this.Paquetes.TabIndex = 13;
            this.Paquetes.Text = "Paquetes";
            this.Paquetes.UseVisualStyleBackColor = true;
            this.Paquetes.Click += new System.EventHandler(this.Paquetes_Click);
            // 
            // Clientes
            // 
            this.Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.Location = new System.Drawing.Point(27, 63);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(155, 111);
            this.Clientes.TabIndex = 12;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = true;
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(49, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(476, 25);
            this.lbl_titulo.TabIndex = 10;
            this.lbl_titulo.Text = "SISTEMA DE VENTAS AGENCIA DE VIAJES";
            // 
            // btn_destinos
            // 
            this.btn_destinos.Location = new System.Drawing.Point(27, 214);
            this.btn_destinos.Name = "btn_destinos";
            this.btn_destinos.Size = new System.Drawing.Size(251, 45);
            this.btn_destinos.TabIndex = 17;
            this.btn_destinos.Text = "Destinos";
            this.btn_destinos.UseVisualStyleBackColor = true;
            this.btn_destinos.Click += new System.EventHandler(this.btn_destinos_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 340);
            this.Controls.Add(this.btn_destinos);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_tipoDeCambio);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_formasDePago);
            this.Controls.Add(this.Paquetes);
            this.Controls.Add(this.Clientes);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frmMenu";
            this.Text = "MENU PRINCIPAL";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_tipoDeCambio;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_formasDePago;
        private System.Windows.Forms.Button Paquetes;
        private System.Windows.Forms.Button Clientes;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_destinos;
    }
}

