namespace ejercicio_17
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
            btnIntroducir = new Button();
            btnBuscar = new Button();
            btnOrdenar = new Button();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // btnIntroducir
            // 
            btnIntroducir.Location = new Point(134, 66);
            btnIntroducir.Name = "btnIntroducir";
            btnIntroducir.Size = new Size(180, 58);
            btnIntroducir.TabIndex = 0;
            btnIntroducir.Text = "Introducir Vector";
            btnIntroducir.UseVisualStyleBackColor = true;
            btnIntroducir.Click += btnIntroducir_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(134, 143);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(180, 58);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar Elemento";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(134, 221);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(180, 58);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar Vector";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(134, 301);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(180, 58);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar Vector";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 450);
            Controls.Add(btnMostrar);
            Controls.Add(btnOrdenar);
            Controls.Add(btnBuscar);
            Controls.Add(btnIntroducir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIntroducir;
        private Button btnBuscar;
        private Button btnOrdenar;
        private Button btnMostrar;
    }
}