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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNuevoCalculo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.pnlOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.btnSalir);
            this.pnlOpciones.Controls.Add(this.btnNuevoCalculo);
            this.pnlOpciones.Controls.Add(this.btnCalcular);
            this.pnlOpciones.Location = new System.Drawing.Point(863, 69);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(274, 544);
            this.pnlOpciones.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(29, 39);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(220, 129);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular Cambio";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
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
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(29, 377);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(220, 114);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(57, 85);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(149, 13);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Ingrese el monto de la compra";
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Location = new System.Drawing.Point(57, 210);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(256, 13);
            this.lbSaldo.TabIndex = 1;
            this.lbSaldo.Text = "Ingrese la cantidad de dinero ingresada por el cliente";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(57, 333);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(140, 13);
            this.lblCambio.TabIndex = 1;
            this.lblCambio.Text = "Cambio a devolver al cliente";
            // 
            // frmCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1184, 825);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.pnlOpciones);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCambio";
            this.Text = "Calcular el cambio de la compra";
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
    }
}

