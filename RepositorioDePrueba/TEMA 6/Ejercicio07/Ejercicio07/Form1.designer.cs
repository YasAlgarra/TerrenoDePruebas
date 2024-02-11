namespace Ejercicio07
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
            this.bLeer1 = new System.Windows.Forms.Button();
            this.bLeerVersion2 = new System.Windows.Forms.Button();
            this.bMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bLeer1
            // 
            this.bLeer1.Location = new System.Drawing.Point(59, 40);
            this.bLeer1.Name = "bLeer1";
            this.bLeer1.Size = new System.Drawing.Size(164, 47);
            this.bLeer1.TabIndex = 0;
            this.bLeer1.Text = "Leer Version 1";
            this.bLeer1.UseVisualStyleBackColor = true;
            this.bLeer1.Click += new System.EventHandler(this.bLeer1_Click);
            // 
            // bLeerVersion2
            // 
            this.bLeerVersion2.Location = new System.Drawing.Point(60, 112);
            this.bLeerVersion2.Name = "bLeerVersion2";
            this.bLeerVersion2.Size = new System.Drawing.Size(164, 41);
            this.bLeerVersion2.TabIndex = 1;
            this.bLeerVersion2.Text = "Leer Version 2";
            this.bLeerVersion2.UseVisualStyleBackColor = true;
            this.bLeerVersion2.Click += new System.EventHandler(this.bLeerVersion2_Click);
            // 
            // bMostrar
            // 
            this.bMostrar.Location = new System.Drawing.Point(64, 182);
            this.bMostrar.Name = "bMostrar";
            this.bMostrar.Size = new System.Drawing.Size(159, 42);
            this.bMostrar.TabIndex = 2;
            this.bMostrar.Text = "Mostrar Vector";
            this.bMostrar.UseVisualStyleBackColor = true;
            this.bMostrar.Click += new System.EventHandler(this.bMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.bMostrar);
            this.Controls.Add(this.bLeerVersion2);
            this.Controls.Add(this.bLeer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bLeer1;
        private System.Windows.Forms.Button bLeerVersion2;
        private System.Windows.Forms.Button bMostrar;
    }
}

