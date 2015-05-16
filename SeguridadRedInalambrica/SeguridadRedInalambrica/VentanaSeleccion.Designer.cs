namespace SeguridadRedInalambrica
{
    partial class VentanaSeleccion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaSeleccion));
            this.txtSeleccion = new System.Windows.Forms.ComboBox();
            this.ImagenSeleccion = new System.Windows.Forms.PictureBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenSeleccion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSeleccion
            // 
            this.txtSeleccion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeleccion.FormattingEnabled = true;
            this.txtSeleccion.Items.AddRange(new object[] {
            "ARRIS TG862A",
            "CISCO DPC2420",
            "HUAWEI WS319"});
            this.txtSeleccion.Location = new System.Drawing.Point(124, 61);
            this.txtSeleccion.Name = "txtSeleccion";
            this.txtSeleccion.Size = new System.Drawing.Size(253, 22);
            this.txtSeleccion.TabIndex = 0;
            this.txtSeleccion.SelectedIndexChanged += new System.EventHandler(this.txtSeleccion_SelectedIndexChanged);
            // 
            // ImagenSeleccion
            // 
            this.ImagenSeleccion.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ImagenSeleccion.Image = ((System.Drawing.Image)(resources.GetObject("ImagenSeleccion.Image")));
            this.ImagenSeleccion.Location = new System.Drawing.Point(184, 111);
            this.ImagenSeleccion.Name = "ImagenSeleccion";
            this.ImagenSeleccion.Size = new System.Drawing.Size(128, 128);
            this.ImagenSeleccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImagenSeleccion.TabIndex = 1;
            this.ImagenSeleccion.TabStop = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiguiente.Location = new System.Drawing.Point(396, 312);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(89, 29);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccióne su dispositivo:";
            // 
            // VentanaSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.ImagenSeleccion);
            this.Controls.Add(this.txtSeleccion);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaSeleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección del Router";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaSeleccion_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenSeleccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtSeleccion;
        private System.Windows.Forms.PictureBox ImagenSeleccion;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label1;
    }
}

