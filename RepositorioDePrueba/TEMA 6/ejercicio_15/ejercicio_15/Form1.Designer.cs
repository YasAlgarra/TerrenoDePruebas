namespace ejercicio_15
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
            btnMayor = new Button();
            btnMenor = new Button();
            SuspendLayout();
            // 
            // btnIntroducir
            // 
            btnIntroducir.Location = new Point(176, 121);
            btnIntroducir.Name = "btnIntroducir";
            btnIntroducir.Size = new Size(220, 72);
            btnIntroducir.TabIndex = 0;
            btnIntroducir.Text = "Introducir números";
            btnIntroducir.UseVisualStyleBackColor = true;
            btnIntroducir.Click += btnIntroducir_Click;
            // 
            // btnMayor
            // 
            btnMayor.Location = new Point(176, 223);
            btnMayor.Name = "btnMayor";
            btnMayor.Size = new Size(220, 72);
            btnMayor.TabIndex = 1;
            btnMayor.Text = "¿Cuál es el mayor?";
            btnMayor.UseVisualStyleBackColor = true;
            btnMayor.Click += btnMayor_Click;
            // 
            // btnMenor
            // 
            btnMenor.Location = new Point(176, 324);
            btnMenor.Name = "btnMenor";
            btnMenor.Size = new Size(220, 72);
            btnMenor.TabIndex = 2;
            btnMenor.Text = "¿Cuál es el menor?";
            btnMenor.UseVisualStyleBackColor = true;
            btnMenor.Click += btnMenor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 474);
            Controls.Add(btnMenor);
            Controls.Add(btnMayor);
            Controls.Add(btnIntroducir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIntroducir;
        private Button btnMayor;
        private Button btnMenor;
    }
}