﻿namespace SeguridadRedInalambrica
{
    partial class VentanaArrisTG862A
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaArrisTG862A));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipoSeguridad = new System.Windows.Forms.ComboBox();
            this.txtContraRed = new System.Windows.Forms.TextBox();
            this.txtNombreRed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(374, 42);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(90, 28);
            this.btnRegresar.TabIndex = 32;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiar.Image")));
            this.btnCambiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambiar.Location = new System.Drawing.Point(191, 267);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(98, 31);
            this.btnCambiar.TabIndex = 31;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tipo de Seguridad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre Red (SSD):";
            // 
            // txtTipoSeguridad
            // 
            this.txtTipoSeguridad.FormattingEnabled = true;
            this.txtTipoSeguridad.Location = new System.Drawing.Point(154, 220);
            this.txtTipoSeguridad.Name = "txtTipoSeguridad";
            this.txtTipoSeguridad.Size = new System.Drawing.Size(169, 21);
            this.txtTipoSeguridad.TabIndex = 27;
            // 
            // txtContraRed
            // 
            this.txtContraRed.Location = new System.Drawing.Point(154, 167);
            this.txtContraRed.Name = "txtContraRed";
            this.txtContraRed.Size = new System.Drawing.Size(169, 20);
            this.txtContraRed.TabIndex = 26;
            // 
            // txtNombreRed
            // 
            this.txtNombreRed.Location = new System.Drawing.Point(154, 108);
            this.txtNombreRed.Name = "txtNombreRed";
            this.txtNombreRed.Size = new System.Drawing.Size(169, 20);
            this.txtNombreRed.TabIndex = 25;
            // 
            // VentanaArrisTG862A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 319);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTipoSeguridad);
            this.Controls.Add(this.txtContraRed);
            this.Controls.Add(this.txtNombreRed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaArrisTG862A";
            this.Text = "VentanaArrisTG862A";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaArrisTG862A_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtTipoSeguridad;
        private System.Windows.Forms.TextBox txtContraRed;
        private System.Windows.Forms.TextBox txtNombreRed;
    }
}