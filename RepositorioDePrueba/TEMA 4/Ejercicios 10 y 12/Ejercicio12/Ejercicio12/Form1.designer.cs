namespace Ejercicio12
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
            this.bCorrecta = new System.Windows.Forms.Button();
            this.TDia = new System.Windows.Forms.TextBox();
            this.TMes = new System.Windows.Forms.TextBox();
            this.TAnyo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCorrecta
            // 
            this.bCorrecta.Location = new System.Drawing.Point(79, 166);
            this.bCorrecta.Name = "bCorrecta";
            this.bCorrecta.Size = new System.Drawing.Size(141, 53);
            this.bCorrecta.TabIndex = 0;
            this.bCorrecta.Text = "¿Fecha Correcta?";
            this.bCorrecta.UseVisualStyleBackColor = true;
            this.bCorrecta.Click += new System.EventHandler(this.bCorrecta_Click);
            // 
            // TDia
            // 
            this.TDia.Location = new System.Drawing.Point(116, 31);
            this.TDia.Name = "TDia";
            this.TDia.Size = new System.Drawing.Size(106, 20);
            this.TDia.TabIndex = 1;
            // 
            // TMes
            // 
            this.TMes.Location = new System.Drawing.Point(117, 72);
            this.TMes.Name = "TMes";
            this.TMes.Size = new System.Drawing.Size(104, 20);
            this.TMes.TabIndex = 2;
            // 
            // TAnyo
            // 
            this.TAnyo.Location = new System.Drawing.Point(116, 112);
            this.TAnyo.Name = "TAnyo";
            this.TAnyo.Size = new System.Drawing.Size(104, 20);
            this.TAnyo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Día:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TAnyo);
            this.Controls.Add(this.TMes);
            this.Controls.Add(this.TDia);
            this.Controls.Add(this.bCorrecta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCorrecta;
        private System.Windows.Forms.TextBox TDia;
        private System.Windows.Forms.TextBox TMes;
        private System.Windows.Forms.TextBox TAnyo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

