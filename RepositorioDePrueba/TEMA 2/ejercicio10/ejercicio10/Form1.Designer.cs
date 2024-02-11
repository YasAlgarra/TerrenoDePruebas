namespace ejercicio10
{
    partial class Conversor
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
            lblEuros = new Label();
            lblPesetas = new Label();
            txtEuros = new TextBox();
            txtPesetas = new TextBox();
            btnAPesetas = new Button();
            btnAEuros = new Button();
            SuspendLayout();
            // 
            // lblEuros
            // 
            lblEuros.AutoSize = true;
            lblEuros.Location = new Point(64, 75);
            lblEuros.Name = "lblEuros";
            lblEuros.Size = new Size(56, 25);
            lblEuros.TabIndex = 0;
            lblEuros.Text = "Euros";
            // 
            // lblPesetas
            // 
            lblPesetas.AutoSize = true;
            lblPesetas.Location = new Point(64, 173);
            lblPesetas.Name = "lblPesetas";
            lblPesetas.Size = new Size(70, 25);
            lblPesetas.TabIndex = 1;
            lblPesetas.Text = "Pesetas";
            // 
            // txtEuros
            // 
            txtEuros.Location = new Point(155, 75);
            txtEuros.Name = "txtEuros";
            txtEuros.Size = new Size(154, 31);
            txtEuros.TabIndex = 2;
            // 
            // txtPesetas
            // 
            txtPesetas.Location = new Point(155, 173);
            txtPesetas.Name = "txtPesetas";
            txtPesetas.Size = new Size(150, 31);
            txtPesetas.TabIndex = 3;
            // 
            // btnAPesetas
            // 
            btnAPesetas.Location = new Point(155, 273);
            btnAPesetas.Name = "btnAPesetas";
            btnAPesetas.Size = new Size(143, 34);
            btnAPesetas.TabIndex = 4;
            btnAPesetas.Text = "Pasar a Pesetas";
            btnAPesetas.UseVisualStyleBackColor = true;
            btnAPesetas.Click += btnAPesetas_Click;
            // 
            // btnAEuros
            // 
            btnAEuros.Location = new Point(155, 348);
            btnAEuros.Name = "btnAEuros";
            btnAEuros.Size = new Size(143, 34);
            btnAEuros.TabIndex = 5;
            btnAEuros.Text = "Pasar a Euros";
            btnAEuros.UseVisualStyleBackColor = true;
            btnAEuros.Click += btnAEuros_Click;
            // 
            // Conversor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 431);
            Controls.Add(btnAEuros);
            Controls.Add(btnAPesetas);
            Controls.Add(txtPesetas);
            Controls.Add(txtEuros);
            Controls.Add(lblPesetas);
            Controls.Add(lblEuros);
            Name = "Conversor";
            Text = "Conversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEuros;
        private Label lblPesetas;
        private TextBox txtEuros;
        private TextBox txtPesetas;
        private Button btnAPesetas;
        private Button btnAEuros;
    }
}