namespace ejercicio13
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
            lblHrsNormales = new Label();
            lblHrsExtra = new Label();
            lblPrecioHrNormal = new Label();
            txtHorasNormal = new TextBox();
            txtHorasExtra = new TextBox();
            txtPrecioHora = new TextBox();
            btnResultado = new Button();
            SuspendLayout();
            // 
            // lblHrsNormales
            // 
            lblHrsNormales.AutoSize = true;
            lblHrsNormales.ImageAlign = ContentAlignment.MiddleRight;
            lblHrsNormales.Location = new Point(84, 94);
            lblHrsNormales.Name = "lblHrsNormales";
            lblHrsNormales.Size = new Size(140, 25);
            lblHrsNormales.TabIndex = 0;
            lblHrsNormales.Text = "Horas Normales";
            lblHrsNormales.TextAlign = ContentAlignment.BottomRight;
            // 
            // lblHrsExtra
            // 
            lblHrsExtra.AutoSize = true;
            lblHrsExtra.Location = new Point(84, 154);
            lblHrsExtra.Name = "lblHrsExtra";
            lblHrsExtra.Size = new Size(102, 25);
            lblHrsExtra.TabIndex = 1;
            lblHrsExtra.Text = "Horas Extra";
            lblHrsExtra.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPrecioHrNormal
            // 
            lblPrecioHrNormal.AutoSize = true;
            lblPrecioHrNormal.Location = new Point(84, 227);
            lblPrecioHrNormal.Name = "lblPrecioHrNormal";
            lblPrecioHrNormal.Size = new Size(163, 25);
            lblPrecioHrNormal.TabIndex = 2;
            lblPrecioHrNormal.Text = "Precio/h normal (€)";
            // 
            // txtHorasNormal
            // 
            txtHorasNormal.Location = new Point(277, 88);
            txtHorasNormal.Name = "txtHorasNormal";
            txtHorasNormal.Size = new Size(150, 31);
            txtHorasNormal.TabIndex = 3;
            // 
            // txtHorasExtra
            // 
            txtHorasExtra.Location = new Point(277, 151);
            txtHorasExtra.Name = "txtHorasExtra";
            txtHorasExtra.Size = new Size(150, 31);
            txtHorasExtra.TabIndex = 4;
            // 
            // txtPrecioHora
            // 
            txtPrecioHora.Location = new Point(277, 221);
            txtPrecioHora.Name = "txtPrecioHora";
            txtPrecioHora.Size = new Size(150, 31);
            txtPrecioHora.TabIndex = 5;
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(167, 329);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(167, 34);
            btnResultado.TabIndex = 6;
            btnResultado.Text = "Calcular Salario";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 450);
            Controls.Add(btnResultado);
            Controls.Add(txtPrecioHora);
            Controls.Add(txtHorasExtra);
            Controls.Add(txtHorasNormal);
            Controls.Add(lblPrecioHrNormal);
            Controls.Add(lblHrsExtra);
            Controls.Add(lblHrsNormales);
            Name = "Form1";
            Text = "Conversor Salario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHrsNormales;
        private Label lblHrsExtra;
        private Label lblPrecioHrNormal;
        private TextBox txtHorasNormal;
        private TextBox txtHorasExtra;
        private TextBox txtPrecioHora;
        private Button btnResultado;
    }
}