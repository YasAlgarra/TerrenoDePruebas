﻿namespace Ejercicio24
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.tNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bDarVuelta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tNumero
            // 
            this.tNumero.Location = new System.Drawing.Point(124, 63);
            this.tNumero.Name = "tNumero";
            this.tNumero.Size = new System.Drawing.Size(99, 20);
            this.tNumero.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número:";
            // 
            // bDarVuelta
            // 
            this.bDarVuelta.Location = new System.Drawing.Point(87, 138);
            this.bDarVuelta.Name = "bDarVuelta";
            this.bDarVuelta.Size = new System.Drawing.Size(125, 35);
            this.bDarVuelta.TabIndex = 2;
            this.bDarVuelta.Text = "Dar la Vuelta";
            this.bDarVuelta.UseVisualStyleBackColor = true;
            this.bDarVuelta.Click += new System.EventHandler(this.bDarVuelta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bDarVuelta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bDarVuelta;

    }
}

