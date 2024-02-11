namespace Ejercicio05
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.bLeer = new System.Windows.Forms.Button();
            this.bMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bLeer
            // 
            this.bLeer.Location = new System.Drawing.Point(78, 58);
            this.bLeer.Name = "bLeer";
            this.bLeer.Size = new System.Drawing.Size(118, 42);
            this.bLeer.TabIndex = 0;
            this.bLeer.Text = "Leer Vectores";
            this.bLeer.UseVisualStyleBackColor = true;
            this.bLeer.Click += new System.EventHandler(this.bLeer_Click);
            // 
            // bMostrar
            // 
            this.bMostrar.Location = new System.Drawing.Point(77, 135);
            this.bMostrar.Name = "bMostrar";
            this.bMostrar.Size = new System.Drawing.Size(118, 44);
            this.bMostrar.TabIndex = 1;
            this.bMostrar.Text = "Sumar y Mostrar";
            this.bMostrar.UseVisualStyleBackColor = true;
            this.bMostrar.Click += new System.EventHandler(this.bMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 379);
            this.Controls.Add(this.bMostrar);
            this.Controls.Add(this.bLeer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bLeer;
        private System.Windows.Forms.Button bMostrar;
    }
}

