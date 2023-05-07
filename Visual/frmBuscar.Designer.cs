namespace Visual
{
    partial class frmBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscar));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.btnAceptarBuscar = new System.Windows.Forms.Button();
            this.btnCancelarBuscar = new System.Windows.Forms.Button();
            this.nmPrecio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(41, 52);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(41, 93);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(41, 132);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(41, 172);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            // 
            // txbCodigo
            // 
            this.txbCodigo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCodigo.Location = new System.Drawing.Point(147, 52);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(145, 20);
            this.txbCodigo.TabIndex = 0;
            // 
            // txbNombre
            // 
            this.txbNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNombre.Location = new System.Drawing.Point(147, 93);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(145, 20);
            this.txbNombre.TabIndex = 1;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDescripcion.Location = new System.Drawing.Point(147, 132);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(145, 20);
            this.txbDescripcion.TabIndex = 2;
            // 
            // btnAceptarBuscar
            // 
            this.btnAceptarBuscar.Location = new System.Drawing.Point(45, 244);
            this.btnAceptarBuscar.Name = "btnAceptarBuscar";
            this.btnAceptarBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarBuscar.TabIndex = 4;
            this.btnAceptarBuscar.Text = "Buscar";
            this.btnAceptarBuscar.UseVisualStyleBackColor = true;
            this.btnAceptarBuscar.Click += new System.EventHandler(this.btnAceptarBuscar_Click);
            // 
            // btnCancelarBuscar
            // 
            this.btnCancelarBuscar.Location = new System.Drawing.Point(202, 244);
            this.btnCancelarBuscar.Name = "btnCancelarBuscar";
            this.btnCancelarBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarBuscar.TabIndex = 5;
            this.btnCancelarBuscar.Text = "Cancelar";
            this.btnCancelarBuscar.UseVisualStyleBackColor = true;
            this.btnCancelarBuscar.Click += new System.EventHandler(this.btnCancelarBuscar_Click);
            // 
            // nmPrecio
            // 
            this.nmPrecio.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.nmPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmPrecio.Location = new System.Drawing.Point(147, 172);
            this.nmPrecio.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nmPrecio.Name = "nmPrecio";
            this.nmPrecio.Size = new System.Drawing.Size(145, 20);
            this.nmPrecio.TabIndex = 6;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(323, 335);
            this.Controls.Add(this.nmPrecio);
            this.Controls.Add(this.btnCancelarBuscar);
            this.Controls.Add(this.btnAceptarBuscar);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(339, 374);
            this.MinimumSize = new System.Drawing.Size(339, 374);
            this.Name = "frmBuscar";
            this.Text = "frmBuscar";
            ((System.ComponentModel.ISupportInitialize)(this.nmPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Button btnAceptarBuscar;
        private System.Windows.Forms.Button btnCancelarBuscar;
        private System.Windows.Forms.NumericUpDown nmPrecio;
    }
}