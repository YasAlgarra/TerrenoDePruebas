namespace ejercicio_27
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
            lblNum = new Label();
            txtNum = new TextBox();
            btnSolucion = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Location = new Point(60, 128);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(163, 25);
            lblNum.TabIndex = 0;
            lblNum.Text = "Introduzca número";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(258, 128);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(149, 31);
            txtNum.TabIndex = 1;
            // 
            // btnSolucion
            // 
            btnSolucion.Location = new Point(191, 271);
            btnSolucion.Name = "btnSolucion";
            btnSolucion.Size = new Size(164, 47);
            btnSolucion.TabIndex = 2;
            btnSolucion.Text = "Solución";
            btnSolucion.UseVisualStyleBackColor = true;
            btnSolucion.Click += btnSolucion_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(165, 51);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(190, 25);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "¿Es un número primo?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 450);
            Controls.Add(lblTitulo);
            Controls.Add(btnSolucion);
            Controls.Add(txtNum);
            Controls.Add(lblNum);
            Name = "Form1";
            Text = "Números primos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum;
        private TextBox txtNum;
        private Button btnSolucion;
        private Label lblTitulo;
    }
}