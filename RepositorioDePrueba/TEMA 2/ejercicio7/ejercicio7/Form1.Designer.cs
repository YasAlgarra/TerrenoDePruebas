namespace ejercicio7
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
            lblAltura = new Label();
            lblcms = new Label();
            txtAlturacms = new TextBox();
            btnResultado = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.FlatStyle = FlatStyle.System;
            lblAltura.Location = new Point(54, 44);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(63, 25);
            lblAltura.TabIndex = 0;
            lblAltura.Text = "Altura:";
            lblAltura.Click += label1_Click;
            // 
            // lblcms
            // 
            lblcms.AutoSize = true;
            lblcms.Location = new Point(279, 50);
            lblcms.Name = "lblcms";
            lblcms.Size = new Size(44, 25);
            lblcms.TabIndex = 1;
            lblcms.Text = "cms";
            // 
            // txtAlturacms
            // 
            txtAlturacms.Location = new Point(123, 44);
            txtAlturacms.Name = "txtAlturacms";
            txtAlturacms.Size = new Size(150, 31);
            txtAlturacms.TabIndex = 2;
            // 
            // btnResultado
            // 
            btnResultado.BackColor = SystemColors.ButtonHighlight;
            btnResultado.ForeColor = SystemColors.ActiveCaptionText;
            btnResultado.Location = new Point(279, 125);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(112, 34);
            btnResultado.TabIndex = 3;
            btnResultado.Text = "Resultado";
            btnResultado.TextAlign = ContentAlignment.TopCenter;
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(123, 182);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 25);
            lblResultado.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 258);
            Controls.Add(lblResultado);
            Controls.Add(btnResultado);
            Controls.Add(txtAlturacms);
            Controls.Add(lblcms);
            Controls.Add(lblAltura);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAltura;
        private Label lblcms;
        private TextBox txtAlturacms;
        private Button btnResultado;
        private Label lblResultado;
    }
}