namespace ejercicio_03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLectura = new Button();
            btnCopiar = new Button();
            btnMostrar = new Button();
            btnMover = new Button();
            SuspendLayout();
            // 
            // btnLectura
            // 
            btnLectura.Location = new Point(105, 60);
            btnLectura.Name = "btnLectura";
            btnLectura.Size = new Size(182, 88);
            btnLectura.TabIndex = 0;
            btnLectura.Text = "Lectura de la lista";
            btnLectura.UseVisualStyleBackColor = true;
            btnLectura.Click += btnLectura_Click;
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(502, 60);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(182, 88);
            btnCopiar.TabIndex = 1;
            btnCopiar.Text = "Copiar en la otra lista";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(105, 246);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(182, 88);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar listas";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnMover
            // 
            btnMover.Location = new Point(502, 246);
            btnMover.Name = "btnMover";
            btnMover.Size = new Size(182, 88);
            btnMover.TabIndex = 3;
            btnMover.Text = "Mover núm. primos a la otra lista";
            btnMover.UseVisualStyleBackColor = true;
            btnMover.Click += btnMover_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMover);
            Controls.Add(btnMostrar);
            Controls.Add(btnCopiar);
            Controls.Add(btnLectura);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLectura;
        private Button btnCopiar;
        private Button btnMostrar;
        private Button btnMover;
    }
}