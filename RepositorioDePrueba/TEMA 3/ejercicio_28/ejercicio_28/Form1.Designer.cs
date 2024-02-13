namespace ejercicio_28
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
            txtMultiplicando = new TextBox();
            btnSolucion = new Button();
            txtMultiplicador = new TextBox();
            lblMultiplicando = new Label();
            lblMultiplicador = new Label();
            lblTitulo = new Label();
            lblSolucion = new Label();
            SuspendLayout();
            // 
            // txtMultiplicando
            // 
            txtMultiplicando.Location = new Point(178, 132);
            txtMultiplicando.Name = "txtMultiplicando";
            txtMultiplicando.Size = new Size(134, 31);
            txtMultiplicando.TabIndex = 0;
            // 
            // btnSolucion
            // 
            btnSolucion.Location = new Point(241, 234);
            btnSolucion.Name = "btnSolucion";
            btnSolucion.Size = new Size(203, 61);
            btnSolucion.TabIndex = 1;
            btnSolucion.Text = "Solución";
            btnSolucion.UseVisualStyleBackColor = true;
            btnSolucion.Click += btnSolucion_Click;
            // 
            // txtMultiplicador
            // 
            txtMultiplicador.Location = new Point(505, 132);
            txtMultiplicador.Name = "txtMultiplicador";
            txtMultiplicador.Size = new Size(134, 31);
            txtMultiplicador.TabIndex = 2;
            // 
            // lblMultiplicando
            // 
            lblMultiplicando.AutoSize = true;
            lblMultiplicando.Location = new Point(52, 132);
            lblMultiplicando.Name = "lblMultiplicando";
            lblMultiplicando.Size = new Size(120, 25);
            lblMultiplicando.TabIndex = 3;
            lblMultiplicando.Text = "Multiplicando";
            // 
            // lblMultiplicador
            // 
            lblMultiplicador.AutoSize = true;
            lblMultiplicador.Location = new Point(383, 132);
            lblMultiplicador.Name = "lblMultiplicador";
            lblMultiplicador.Size = new Size(116, 25);
            lblMultiplicador.TabIndex = 4;
            lblMultiplicador.Text = "Multiplicador";
            lblMultiplicador.Click += label2_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(187, 56);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(344, 25);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Introduzca números que desea multiplicar";
            // 
            // lblSolucion
            // 
            lblSolucion.AutoSize = true;
            lblSolucion.Location = new Point(318, 363);
            lblSolucion.Name = "lblSolucion";
            lblSolucion.Size = new Size(0, 25);
            lblSolucion.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 450);
            Controls.Add(lblSolucion);
            Controls.Add(lblTitulo);
            Controls.Add(lblMultiplicador);
            Controls.Add(lblMultiplicando);
            Controls.Add(txtMultiplicador);
            Controls.Add(btnSolucion);
            Controls.Add(txtMultiplicando);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMultiplicando;
        private Button btnSolucion;
        private TextBox txtMultiplicador;
        private Label lblMultiplicando;
        private Label lblMultiplicador;
        private Label lblTitulo;
        private Label lblSolucion;
    }
}