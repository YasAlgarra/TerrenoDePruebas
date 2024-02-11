namespace Ejercicio_13
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
            btnCalcularFecha = new Button();
            lblTitulo = new Label();
            lblDia = new Label();
            lblMes = new Label();
            lblAnyo = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAnyo = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnCalcularFecha
            // 
            btnCalcularFecha.Location = new Point(192, 276);
            btnCalcularFecha.Name = "btnCalcularFecha";
            btnCalcularFecha.Size = new Size(205, 34);
            btnCalcularFecha.TabIndex = 0;
            btnCalcularFecha.Text = "Calcular Día Siguiente";
            btnCalcularFecha.UseVisualStyleBackColor = true;
            btnCalcularFecha.Click += btnCalcularFecha_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(221, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(146, 25);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Introduzca Fecha";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(174, 89);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(42, 25);
            lblDia.TabIndex = 2;
            lblDia.Text = "Día:";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(174, 140);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(49, 25);
            lblMes.TabIndex = 3;
            lblMes.Text = "Mes:";
            // 
            // lblAnyo
            // 
            lblAnyo.AutoSize = true;
            lblAnyo.Location = new Point(174, 204);
            lblAnyo.Name = "lblAnyo";
            lblAnyo.Size = new Size(49, 25);
            lblAnyo.TabIndex = 4;
            lblAnyo.Text = "Año:";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(288, 83);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(150, 31);
            txtDia.TabIndex = 5;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(288, 140);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(150, 31);
            txtMes.TabIndex = 6;
            // 
            // txtAnyo
            // 
            txtAnyo.Location = new Point(288, 198);
            txtAnyo.Name = "txtAnyo";
            txtAnyo.Size = new Size(150, 31);
            txtAnyo.TabIndex = 7;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(223, 364);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 25);
            lblResultado.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 450);
            Controls.Add(lblResultado);
            Controls.Add(txtAnyo);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(lblAnyo);
            Controls.Add(lblMes);
            Controls.Add(lblDia);
            Controls.Add(lblTitulo);
            Controls.Add(btnCalcularFecha);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcularFecha;
        private Label lblTitulo;
        private Label lblDia;
        private Label lblMes;
        private Label lblAnyo;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnyo;
        private Label lblResultado;
    }
}