namespace Ejercicio_9
{
    partial class frmCambio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambio));
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.btnNuevoCalculo = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.btnSalir);
            this.pnlOpciones.Controls.Add(this.btnNuevoCalculo);
            this.pnlOpciones.Controls.Add(this.btnCalcular);
            this.pnlOpciones.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlOpciones.Location = new System.Drawing.Point(863, 69);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(274, 544);
            this.pnlOpciones.TabIndex = 0;
            // 
            // btnNuevoCalculo
            // 
            this.btnNuevoCalculo.Location = new System.Drawing.Point(29, 204);
            this.btnNuevoCalculo.Name = "btnNuevoCalculo";
            this.btnNuevoCalculo.Size = new System.Drawing.Size(220, 133);
            this.btnNuevoCalculo.TabIndex = 0;
            this.btnNuevoCalculo.Text = "Calcular nuevo cambio";
            this.btnNuevoCalculo.UseVisualStyleBackColor = true;
            this.btnNuevoCalculo.Click += new System.EventHandler(this.btnNuevoCalculo_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(50, 175);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(310, 24);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Ingrese el monto de la compra";
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoEllipsis = true;
            this.lbSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSaldo.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldo.Location = new System.Drawing.Point(50, 300);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(310, 51);
            this.lbSaldo.TabIndex = 1;
            this.lbSaldo.Text = "Ingrese la cantidad de dinero dada por el cliente";
            // 
            // lblCambio
            // 
            this.lblCambio.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(50, 443);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(290, 24);
            this.lblCambio.TabIndex = 1;
            this.lblCambio.Text = "Cambio a devolver al cliente";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F);
            this.txtMonto.Location = new System.Drawing.Point(392, 176);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(351, 30);
            this.txtMonto.TabIndex = 2;
            // 
            // txtDinero
            // 
            this.txtDinero.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F);
            this.txtDinero.Location = new System.Drawing.Point(392, 316);
            this.txtDinero.Multiline = true;
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(351, 30);
            this.txtDinero.TabIndex = 2;
            // 
            // txtCambio
            // 
            this.txtCambio.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F);
            this.txtCambio.Location = new System.Drawing.Point(392, 443);
            this.txtCambio.Multiline = true;
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(351, 30);
            this.txtCambio.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Ejercicio_9.Properties.Resources.icons8_cerrar_ventana_32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSalir.Location = new System.Drawing.Point(29, 377);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(220, 114);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = global::Ejercicio_9.Properties.Resources.icons8_calculator_32;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCalcular.Location = new System.Drawing.Point(29, 39);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(220, 129);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular Cambio";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblError.Location = new System.Drawing.Point(50, 550);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(657, 24);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "Error";
            // 
            // frmCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1184, 825);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.txtDinero);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.pnlOpciones);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCambio";
            this.Text = "Calcular el cambio de la compra";
            this.Load += new System.EventHandler(this.frmCambio_Load);
            this.pnlOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevoCalculo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label lblError;
    }
}

