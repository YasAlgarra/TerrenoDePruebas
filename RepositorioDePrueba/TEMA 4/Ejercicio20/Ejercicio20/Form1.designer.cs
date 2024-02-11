namespace Ejercicio20
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
            this.tBase = new System.Windows.Forms.TextBox();
            this.tExponente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bIterativa = new System.Windows.Forms.Button();
            this.bRecursiva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBase
            // 
            this.tBase.Location = new System.Drawing.Point(98, 44);
            this.tBase.Name = "tBase";
            this.tBase.Size = new System.Drawing.Size(107, 20);
            this.tBase.TabIndex = 0;
            // 
            // tExponente
            // 
            this.tExponente.Location = new System.Drawing.Point(99, 95);
            this.tExponente.Name = "tExponente";
            this.tExponente.Size = new System.Drawing.Size(105, 20);
            this.tExponente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Exponente:";
            // 
            // bIterativa
            // 
            this.bIterativa.Location = new System.Drawing.Point(100, 151);
            this.bIterativa.Name = "bIterativa";
            this.bIterativa.Size = new System.Drawing.Size(104, 33);
            this.bIterativa.TabIndex = 4;
            this.bIterativa.Text = "Iterativa";
            this.bIterativa.UseVisualStyleBackColor = true;
            this.bIterativa.Click += new System.EventHandler(this.bIterativa_Click);
            // 
            // bRecursiva
            // 
            this.bRecursiva.Location = new System.Drawing.Point(100, 207);
            this.bRecursiva.Name = "bRecursiva";
            this.bRecursiva.Size = new System.Drawing.Size(103, 32);
            this.bRecursiva.TabIndex = 5;
            this.bRecursiva.Text = "Recursiva";
            this.bRecursiva.UseVisualStyleBackColor = true;
            this.bRecursiva.Click += new System.EventHandler(this.bRecursiva_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 292);
            this.Controls.Add(this.bRecursiva);
            this.Controls.Add(this.bIterativa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tExponente);
            this.Controls.Add(this.tBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBase;
        private System.Windows.Forms.TextBox tExponente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bIterativa;
        private System.Windows.Forms.Button bRecursiva;
    }
}

