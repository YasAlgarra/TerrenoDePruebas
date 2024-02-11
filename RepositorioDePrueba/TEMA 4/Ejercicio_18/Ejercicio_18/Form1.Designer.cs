namespace Ejercicio_18
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
            btnCalcular = new Button();
            lblValor1 = new Label();
            lblValor2 = new Label();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            lblRespuesta = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(316, 236);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(156, 58);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblValor1
            // 
            lblValor1.AutoSize = true;
            lblValor1.Location = new Point(245, 51);
            lblValor1.Name = "lblValor1";
            lblValor1.Size = new Size(171, 25);
            lblValor1.TabIndex = 1;
            lblValor1.Text = "Ingrese primer valor";
            // 
            // lblValor2
            // 
            lblValor2.AutoSize = true;
            lblValor2.Location = new Point(227, 112);
            lblValor2.Name = "lblValor2";
            lblValor2.Size = new Size(189, 25);
            lblValor2.TabIndex = 2;
            lblValor2.Text = "Ingrese segundo valor";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(450, 51);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(160, 31);
            txtValor1.TabIndex = 3;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(450, 112);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(160, 31);
            txtValor2.TabIndex = 4;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Location = new Point(104, 376);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(0, 25);
            lblRespuesta.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 468);
            Controls.Add(lblRespuesta);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(lblValor2);
            Controls.Add(lblValor1);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblValor1;
        private Label lblValor2;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Label lblRespuesta;
    }
}