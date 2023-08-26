namespace Validacion
{
    partial class Form1
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
            this.lblDniResultado = new System.Windows.Forms.Label();
            this.lblDniFinal = new System.Windows.Forms.Label();
            this.lblCuitResultado = new System.Windows.Forms.Label();
            this.lblCuitFinal = new System.Windows.Forms.Label();
            this.lblPatenteResultado = new System.Windows.Forms.Label();
            this.lblPatenteFinal = new System.Windows.Forms.Label();
            this.gbxCuit = new System.Windows.Forms.GroupBox();
            this.btnIngresarCuit = new System.Windows.Forms.Button();
            this.mtbCuit = new System.Windows.Forms.MaskedTextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.gbxPatente = new System.Windows.Forms.GroupBox();
            this.btnIngresarPatente = new System.Windows.Forms.Button();
            this.rbtFormatoNuevo = new System.Windows.Forms.RadioButton();
            this.rbtFormatoViejo = new System.Windows.Forms.RadioButton();
            this.lblPatente = new System.Windows.Forms.Label();
            this.mtbPatenteNueva = new System.Windows.Forms.MaskedTextBox();
            this.mtbPatenteVieja = new System.Windows.Forms.MaskedTextBox();
            this.gbxCuit.SuspendLayout();
            this.gbxPatente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDniResultado
            // 
            this.lblDniResultado.AutoSize = true;
            this.lblDniResultado.Location = new System.Drawing.Point(369, 238);
            this.lblDniResultado.Name = "lblDniResultado";
            this.lblDniResultado.Size = new System.Drawing.Size(0, 13);
            this.lblDniResultado.TabIndex = 16;
            // 
            // lblDniFinal
            // 
            this.lblDniFinal.AutoSize = true;
            this.lblDniFinal.Location = new System.Drawing.Point(302, 238);
            this.lblDniFinal.Name = "lblDniFinal";
            this.lblDniFinal.Size = new System.Drawing.Size(29, 13);
            this.lblDniFinal.TabIndex = 15;
            this.lblDniFinal.Text = "DNI:";
            // 
            // lblCuitResultado
            // 
            this.lblCuitResultado.AutoSize = true;
            this.lblCuitResultado.Location = new System.Drawing.Point(369, 212);
            this.lblCuitResultado.Name = "lblCuitResultado";
            this.lblCuitResultado.Size = new System.Drawing.Size(0, 13);
            this.lblCuitResultado.TabIndex = 14;
            // 
            // lblCuitFinal
            // 
            this.lblCuitFinal.AutoSize = true;
            this.lblCuitFinal.Location = new System.Drawing.Point(302, 212);
            this.lblCuitFinal.Name = "lblCuitFinal";
            this.lblCuitFinal.Size = new System.Drawing.Size(35, 13);
            this.lblCuitFinal.TabIndex = 13;
            this.lblCuitFinal.Text = "CUIT:";
            // 
            // lblPatenteResultado
            // 
            this.lblPatenteResultado.AutoSize = true;
            this.lblPatenteResultado.Location = new System.Drawing.Point(85, 212);
            this.lblPatenteResultado.Name = "lblPatenteResultado";
            this.lblPatenteResultado.Size = new System.Drawing.Size(0, 13);
            this.lblPatenteResultado.TabIndex = 12;
            // 
            // lblPatenteFinal
            // 
            this.lblPatenteFinal.AutoSize = true;
            this.lblPatenteFinal.Location = new System.Drawing.Point(19, 212);
            this.lblPatenteFinal.Name = "lblPatenteFinal";
            this.lblPatenteFinal.Size = new System.Drawing.Size(47, 13);
            this.lblPatenteFinal.TabIndex = 11;
            this.lblPatenteFinal.Text = "Patente:";
            // 
            // gbxCuit
            // 
            this.gbxCuit.Controls.Add(this.btnIngresarCuit);
            this.gbxCuit.Controls.Add(this.mtbCuit);
            this.gbxCuit.Controls.Add(this.lblCuit);
            this.gbxCuit.Location = new System.Drawing.Point(296, 12);
            this.gbxCuit.Name = "gbxCuit";
            this.gbxCuit.Size = new System.Drawing.Size(271, 177);
            this.gbxCuit.TabIndex = 10;
            this.gbxCuit.TabStop = false;
            this.gbxCuit.Text = "CUIT";
            // 
            // btnIngresarCuit
            // 
            this.btnIngresarCuit.Location = new System.Drawing.Point(6, 145);
            this.btnIngresarCuit.Name = "btnIngresarCuit";
            this.btnIngresarCuit.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarCuit.TabIndex = 2;
            this.btnIngresarCuit.Text = "Ingresar";
            this.btnIngresarCuit.UseVisualStyleBackColor = true;
            this.btnIngresarCuit.Click += new System.EventHandler(this.btnIngresarCuit_Click);
            // 
            // mtbCuit
            // 
            this.mtbCuit.Location = new System.Drawing.Point(7, 67);
            this.mtbCuit.Mask = "00000000000";
            this.mtbCuit.Name = "mtbCuit";
            this.mtbCuit.Size = new System.Drawing.Size(118, 20);
            this.mtbCuit.TabIndex = 1;
            this.mtbCuit.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCuit_MaskInputRejected);
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(6, 26);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(172, 13);
            this.lblCuit.TabIndex = 0;
            this.lblCuit.Text = "Ingrese su CUIT sin \"-\" ni espacios";
            // 
            // gbxPatente
            // 
            this.gbxPatente.Controls.Add(this.btnIngresarPatente);
            this.gbxPatente.Controls.Add(this.rbtFormatoNuevo);
            this.gbxPatente.Controls.Add(this.rbtFormatoViejo);
            this.gbxPatente.Controls.Add(this.lblPatente);
            this.gbxPatente.Controls.Add(this.mtbPatenteNueva);
            this.gbxPatente.Controls.Add(this.mtbPatenteVieja);
            this.gbxPatente.Location = new System.Drawing.Point(13, 12);
            this.gbxPatente.Name = "gbxPatente";
            this.gbxPatente.Size = new System.Drawing.Size(277, 177);
            this.gbxPatente.TabIndex = 9;
            this.gbxPatente.TabStop = false;
            this.gbxPatente.Text = "Patente";
            // 
            // btnIngresarPatente
            // 
            this.btnIngresarPatente.Location = new System.Drawing.Point(9, 145);
            this.btnIngresarPatente.Name = "btnIngresarPatente";
            this.btnIngresarPatente.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarPatente.TabIndex = 7;
            this.btnIngresarPatente.Text = "Ingresar";
            this.btnIngresarPatente.UseVisualStyleBackColor = true;
            this.btnIngresarPatente.Click += new System.EventHandler(this.btnIngresarPatente_Click);
            // 
            // rbtFormatoNuevo
            // 
            this.rbtFormatoNuevo.AutoSize = true;
            this.rbtFormatoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFormatoNuevo.Location = new System.Drawing.Point(9, 109);
            this.rbtFormatoNuevo.Name = "rbtFormatoNuevo";
            this.rbtFormatoNuevo.Size = new System.Drawing.Size(154, 17);
            this.rbtFormatoNuevo.TabIndex = 6;
            this.rbtFormatoNuevo.Text = "Formato nuevo (AA123AA):";
            this.rbtFormatoNuevo.UseVisualStyleBackColor = true;
            this.rbtFormatoNuevo.CheckedChanged += new System.EventHandler(this.rbtFormatoNuevo_CheckedChanged);
            // 
            // rbtFormatoViejo
            // 
            this.rbtFormatoViejo.AutoSize = true;
            this.rbtFormatoViejo.Checked = true;
            this.rbtFormatoViejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFormatoViejo.Location = new System.Drawing.Point(9, 70);
            this.rbtFormatoViejo.Name = "rbtFormatoViejo";
            this.rbtFormatoViejo.Size = new System.Drawing.Size(139, 17);
            this.rbtFormatoViejo.TabIndex = 5;
            this.rbtFormatoViejo.TabStop = true;
            this.rbtFormatoViejo.Text = "Formato viejo (AAA123):";
            this.rbtFormatoViejo.UseVisualStyleBackColor = true;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(6, 26);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(197, 13);
            this.lblPatente.TabIndex = 2;
            this.lblPatente.Text = "Seleccione formato e ingrese su patente";
            // 
            // mtbPatenteNueva
            // 
            this.mtbPatenteNueva.Location = new System.Drawing.Point(171, 108);
            this.mtbPatenteNueva.Mask = "LL000LL";
            this.mtbPatenteNueva.Name = "mtbPatenteNueva";
            this.mtbPatenteNueva.Size = new System.Drawing.Size(100, 20);
            this.mtbPatenteNueva.TabIndex = 4;
            this.mtbPatenteNueva.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbPatenteNueva_MaskInputRejected);
            // 
            // mtbPatenteVieja
            // 
            this.mtbPatenteVieja.Location = new System.Drawing.Point(171, 67);
            this.mtbPatenteVieja.Mask = "LLL000";
            this.mtbPatenteVieja.Name = "mtbPatenteVieja";
            this.mtbPatenteVieja.Size = new System.Drawing.Size(100, 20);
            this.mtbPatenteVieja.TabIndex = 3;
            this.mtbPatenteVieja.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbPatenteVieja_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 318);
            this.Controls.Add(this.lblDniResultado);
            this.Controls.Add(this.lblDniFinal);
            this.Controls.Add(this.lblCuitResultado);
            this.Controls.Add(this.lblCuitFinal);
            this.Controls.Add(this.lblPatenteResultado);
            this.Controls.Add(this.lblPatenteFinal);
            this.Controls.Add(this.gbxCuit);
            this.Controls.Add(this.gbxPatente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxCuit.ResumeLayout(false);
            this.gbxCuit.PerformLayout();
            this.gbxPatente.ResumeLayout(false);
            this.gbxPatente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDniResultado;
        private System.Windows.Forms.Label lblDniFinal;
        private System.Windows.Forms.Label lblCuitResultado;
        private System.Windows.Forms.Label lblCuitFinal;
        private System.Windows.Forms.Label lblPatenteResultado;
        private System.Windows.Forms.Label lblPatenteFinal;
        private System.Windows.Forms.GroupBox gbxCuit;
        private System.Windows.Forms.Button btnIngresarCuit;
        private System.Windows.Forms.MaskedTextBox mtbCuit;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.GroupBox gbxPatente;
        private System.Windows.Forms.Button btnIngresarPatente;
        private System.Windows.Forms.RadioButton rbtFormatoNuevo;
        private System.Windows.Forms.RadioButton rbtFormatoViejo;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.MaskedTextBox mtbPatenteNueva;
        private System.Windows.Forms.MaskedTextBox mtbPatenteVieja;
    }
}

