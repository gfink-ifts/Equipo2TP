namespace Agencia_de_Viajes
{
    partial class tipoCambio
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
            this.dgTipoCambio = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txt_cotizacion = new System.Windows.Forms.TextBox();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_borrarUltimo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTipoCambio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTipoCambio
            // 
            this.dgTipoCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTipoCambio.Location = new System.Drawing.Point(22, 61);
            this.dgTipoCambio.Name = "dgTipoCambio";
            this.dgTipoCambio.Size = new System.Drawing.Size(420, 230);
            this.dgTipoCambio.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(21, 23);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(85, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txt_cotizacion
            // 
            this.txt_cotizacion.Location = new System.Drawing.Point(294, 24);
            this.txt_cotizacion.Name = "txt_cotizacion";
            this.txt_cotizacion.Size = new System.Drawing.Size(148, 20);
            this.txt_cotizacion.TabIndex = 3;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(201, 23);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(85, 23);
            this.btn_Actualizar.TabIndex = 4;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_borrarUltimo
            // 
            this.btn_borrarUltimo.Location = new System.Drawing.Point(111, 23);
            this.btn_borrarUltimo.Name = "btn_borrarUltimo";
            this.btn_borrarUltimo.Size = new System.Drawing.Size(85, 23);
            this.btn_borrarUltimo.TabIndex = 5;
            this.btn_borrarUltimo.Text = "Borrar Último";
            this.btn_borrarUltimo.UseVisualStyleBackColor = true;
            this.btn_borrarUltimo.Click += new System.EventHandler(this.btn_borrarUltimo_Click);
            // 
            // tipoCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 304);
            this.Controls.Add(this.btn_borrarUltimo);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.txt_cotizacion);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgTipoCambio);
            this.Name = "tipoCambio";
            this.Text = "Tipo de Cambio";
            this.Load += new System.EventHandler(this.tipoCambio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTipoCambio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTipoCambio;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txt_cotizacion;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_borrarUltimo;
    }
}