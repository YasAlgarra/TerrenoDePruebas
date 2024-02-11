namespace ejercicio_11
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
            lblHora = new Label();
            lblMinutos = new Label();
            lblSegundos = new Label();
            txtHora = new TextBox();
            txtMinutos = new TextBox();
            txtSegundos = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(168, 101);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(55, 25);
            lblHora.TabIndex = 0;
            lblHora.Text = "Hora:";
            // 
            // lblMinutos
            // 
            lblMinutos.AutoSize = true;
            lblMinutos.Location = new Point(168, 185);
            lblMinutos.Name = "lblMinutos";
            lblMinutos.Size = new Size(81, 25);
            lblMinutos.TabIndex = 1;
            lblMinutos.Text = "Minutos:";
            // 
            // lblSegundos
            // 
            lblSegundos.AutoSize = true;
            lblSegundos.Location = new Point(168, 257);
            lblSegundos.Name = "lblSegundos";
            lblSegundos.Size = new Size(96, 25);
            lblSegundos.TabIndex = 2;
            lblSegundos.Text = "Segundos:";
            // 
            // txtHora
            // 
            txtHora.Location = new Point(277, 98);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(150, 31);
            txtHora.TabIndex = 3;
            // 
            // txtMinutos
            // 
            txtMinutos.Location = new Point(277, 185);
            txtMinutos.Name = "txtMinutos";
            txtMinutos.Size = new Size(150, 31);
            txtMinutos.TabIndex = 4;
            // 
            // txtSegundos
            // 
            txtSegundos.Location = new Point(277, 257);
            txtSegundos.Name = "txtSegundos";
            txtSegundos.Size = new Size(150, 31);
            txtSegundos.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(267, 372);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtSegundos);
            Controls.Add(txtMinutos);
            Controls.Add(txtHora);
            Controls.Add(lblSegundos);
            Controls.Add(lblMinutos);
            Controls.Add(lblHora);
            Name = "Form1";
            Text = "Calcular la hora siguiente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHora;
        private Label lblMinutos;
        private Label lblSegundos;
        private TextBox txtHora;
        private TextBox txtMinutos;
        private TextBox txtSegundos;
        private Button btnCalcular;
    }
}