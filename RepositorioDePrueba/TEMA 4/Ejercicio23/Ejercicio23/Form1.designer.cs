namespace Ejercicio23
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
            this.tDividendo = new System.Windows.Forms.TextBox();
            this.tDivisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bDIterativa = new System.Windows.Forms.Button();
            this.bDRecursiva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tDividendo
            // 
            this.tDividendo.Location = new System.Drawing.Point(121, 43);
            this.tDividendo.Name = "tDividendo";
            this.tDividendo.Size = new System.Drawing.Size(115, 20);
            this.tDividendo.TabIndex = 0;
            // 
            // tDivisor
            // 
            this.tDivisor.Location = new System.Drawing.Point(122, 97);
            this.tDivisor.Name = "tDivisor";
            this.tDivisor.Size = new System.Drawing.Size(113, 20);
            this.tDivisor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dividendo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Divisor:";
            // 
            // bDIterativa
            // 
            this.bDIterativa.Location = new System.Drawing.Point(105, 172);
            this.bDIterativa.Name = "bDIterativa";
            this.bDIterativa.Size = new System.Drawing.Size(130, 35);
            this.bDIterativa.TabIndex = 4;
            this.bDIterativa.Text = "División Iterativa";
            this.bDIterativa.UseVisualStyleBackColor = true;
            this.bDIterativa.Click += new System.EventHandler(this.bDIterativa_Click);
            // 
            // bDRecursiva
            // 
            this.bDRecursiva.Location = new System.Drawing.Point(104, 247);
            this.bDRecursiva.Name = "bDRecursiva";
            this.bDRecursiva.Size = new System.Drawing.Size(130, 31);
            this.bDRecursiva.TabIndex = 5;
            this.bDRecursiva.Text = "División Recursiva";
            this.bDRecursiva.UseVisualStyleBackColor = true;
            this.bDRecursiva.Click += new System.EventHandler(this.bDRecursiva_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 326);
            this.Controls.Add(this.bDRecursiva);
            this.Controls.Add(this.bDIterativa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tDivisor);
            this.Controls.Add(this.tDividendo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tDividendo;
        private System.Windows.Forms.TextBox tDivisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bDIterativa;
        private System.Windows.Forms.Button bDRecursiva;
    }
}

