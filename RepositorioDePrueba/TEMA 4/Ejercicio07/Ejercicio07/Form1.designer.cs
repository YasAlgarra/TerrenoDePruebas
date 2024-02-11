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
            this.bMCD = new System.Windows.Forms.Button();
            this.tNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bMCD
            // 
            this.bMCD.Location = new System.Drawing.Point(122, 212);
            this.bMCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bMCD.Name = "bMCD";
            this.bMCD.Size = new System.Drawing.Size(182, 60);
            this.bMCD.TabIndex = 0;
            this.bMCD.Text = "Obtener MCD (Versión1)";
            this.bMCD.UseVisualStyleBackColor = true;
            this.bMCD.Click += new System.EventHandler(this.bMCD1_Click);
            // 
            // tNum1
            // 
            this.tNum1.Location = new System.Drawing.Point(124, 78);
            this.tNum1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tNum1.Name = "tNum1";
            this.tNum1.Size = new System.Drawing.Size(180, 26);
            this.tNum1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número 1:";
            // 
            // tNum2
            // 
            this.tNum2.Location = new System.Drawing.Point(124, 142);
            this.tNum2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tNum2.Name = "tNum2";
            this.tNum2.Size = new System.Drawing.Size(178, 26);
            this.tNum2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número 2:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 309);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Obtener MCD   (Versión 2)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tNum2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tNum1);
            this.Controls.Add(this.bMCD);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bMCD;
        private System.Windows.Forms.TextBox tNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

