namespace ejercicio14
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
            lblNum1 = new Label();
            lblNum2 = new Label();
            label3 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            btnMayor = new Button();
            btnMenor = new Button();
            bntIgual = new Button();
            btnDistinto = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(181, 69);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(96, 25);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Número 1:";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(181, 231);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(96, 25);
            lblNum2.TabIndex = 1;
            lblNum2.Text = "Número 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 299);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 2;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(313, 69);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(150, 31);
            txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(313, 231);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(150, 31);
            txtNum2.TabIndex = 4;
            // 
            // btnMayor
            // 
            btnMayor.Location = new Point(106, 143);
            btnMayor.Name = "btnMayor";
            btnMayor.Size = new Size(114, 44);
            btnMayor.TabIndex = 5;
            btnMayor.Text = ">";
            btnMayor.UseVisualStyleBackColor = true;
            btnMayor.Click += button1_Click;
            // 
            // btnMenor
            // 
            btnMenor.Location = new Point(258, 143);
            btnMenor.Name = "btnMenor";
            btnMenor.Size = new Size(121, 44);
            btnMenor.TabIndex = 6;
            btnMenor.Text = "<";
            btnMenor.UseVisualStyleBackColor = true;
            btnMenor.Click += btnMenor_Click;
            // 
            // bntIgual
            // 
            bntIgual.Location = new Point(415, 143);
            bntIgual.Name = "bntIgual";
            bntIgual.Size = new Size(121, 44);
            bntIgual.TabIndex = 7;
            bntIgual.Text = "==";
            bntIgual.UseVisualStyleBackColor = true;
            bntIgual.Click += bntIgual_Click;
            // 
            // btnDistinto
            // 
            btnDistinto.Location = new Point(564, 143);
            btnDistinto.Name = "btnDistinto";
            btnDistinto.Size = new Size(121, 44);
            btnDistinto.TabIndex = 8;
            btnDistinto.Text = "!=";
            btnDistinto.UseVisualStyleBackColor = true;
            btnDistinto.Click += btnDistinto_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(343, 344);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 25);
            lblResultado.TabIndex = 9;
            lblResultado.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnDistinto);
            Controls.Add(bntIgual);
            Controls.Add(btnMenor);
            Controls.Add(btnMayor);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label3);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "Form1";
            Text = "Ejercicio 14";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private Label lblNum2;
        private Label label3;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btnMayor;
        private Button btnMenor;
        private Button bntIgual;
        private Button btnDistinto;
        private Label lblResultado;
    }
}