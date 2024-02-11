namespace ejercicio_25
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
            lblTablas = new Label();
            btnEmpezar = new Button();
            SuspendLayout();
            // 
            // lblTablas
            // 
            lblTablas.AutoSize = true;
            lblTablas.Location = new Point(105, 84);
            lblTablas.Name = "lblTablas";
            lblTablas.Size = new Size(259, 25);
            lblTablas.TabIndex = 0;
            lblTablas.Text = "Tablas de multiplicar del 1 al 10";
            // 
            // btnEmpezar
            // 
            btnEmpezar.BackColor = SystemColors.GradientInactiveCaption;
            btnEmpezar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmpezar.ForeColor = SystemColors.ActiveCaptionText;
            btnEmpezar.Location = new Point(170, 143);
            btnEmpezar.Name = "btnEmpezar";
            btnEmpezar.Size = new Size(112, 34);
            btnEmpezar.TabIndex = 1;
            btnEmpezar.Text = "Empezar";
            btnEmpezar.UseVisualStyleBackColor = false;
            btnEmpezar.Click += btnEmpezar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 280);
            Controls.Add(btnEmpezar);
            Controls.Add(lblTablas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTablas;
        private Button btnEmpezar;
    }
}