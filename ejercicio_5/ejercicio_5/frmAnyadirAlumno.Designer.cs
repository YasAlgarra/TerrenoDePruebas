namespace ejercicio_5
{
    partial class frmAnyadirAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnyadirNotas = new System.Windows.Forms.Button();
            this.txtCodigoCurso = new System.Windows.Forms.TextBox();
            this.lblCodigoCurso = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAnyadirAlumno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnyadirNotas
            // 
            this.btnAnyadirNotas.Location = new System.Drawing.Point(152, 391);
            this.btnAnyadirNotas.Name = "btnAnyadirNotas";
            this.btnAnyadirNotas.Size = new System.Drawing.Size(233, 37);
            this.btnAnyadirNotas.TabIndex = 28;
            this.btnAnyadirNotas.Text = "Añadir Notas";
            this.btnAnyadirNotas.UseVisualStyleBackColor = true;
            this.btnAnyadirNotas.Click += new System.EventHandler(this.btnAnyadirNotas_Click);
            // 
            // txtCodigoCurso
            // 
            this.txtCodigoCurso.Location = new System.Drawing.Point(250, 289);
            this.txtCodigoCurso.Name = "txtCodigoCurso";
            this.txtCodigoCurso.Size = new System.Drawing.Size(206, 26);
            this.txtCodigoCurso.TabIndex = 25;
            // 
            // lblCodigoCurso
            // 
            this.lblCodigoCurso.AutoSize = true;
            this.lblCodigoCurso.Location = new System.Drawing.Point(128, 289);
            this.lblCodigoCurso.Name = "lblCodigoCurso";
            this.lblCodigoCurso.Size = new System.Drawing.Size(109, 20);
            this.lblCodigoCurso.TabIndex = 24;
            this.lblCodigoCurso.Text = "Código Curso:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(250, 211);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(206, 26);
            this.txtTelefono.TabIndex = 23;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(103, 211);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(134, 20);
            this.lblTelefono.TabIndex = 22;
            this.lblTelefono.Text = "Insertar Teléfono:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(250, 133);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(206, 26);
            this.txtDNI.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(250, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 26);
            this.txtNombre.TabIndex = 20;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(137, 136);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(100, 20);
            this.lblCodigo.TabIndex = 19;
            this.lblCodigo.Text = "Insertar DNI:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(109, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(128, 20);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Insertar Nombre:";
            // 
            // btnAnyadirAlumno
            // 
            this.btnAnyadirAlumno.Location = new System.Drawing.Point(152, 492);
            this.btnAnyadirAlumno.Name = "btnAnyadirAlumno";
            this.btnAnyadirAlumno.Size = new System.Drawing.Size(233, 89);
            this.btnAnyadirAlumno.TabIndex = 17;
            this.btnAnyadirAlumno.Text = "Añadir Alumno/a";
            this.btnAnyadirAlumno.UseVisualStyleBackColor = true;
            this.btnAnyadirAlumno.Click += new System.EventHandler(this.btnAnyadirAlumno_Click);
            // 
            // frmAnyadirAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 628);
            this.Controls.Add(this.btnAnyadirNotas);
            this.Controls.Add(this.txtCodigoCurso);
            this.Controls.Add(this.lblCodigoCurso);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAnyadirAlumno);
            this.Name = "frmAnyadirAlumno";
            this.Text = "frmAnyadirAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnyadirNotas;
        private System.Windows.Forms.TextBox txtCodigoCurso;
        private System.Windows.Forms.Label lblCodigoCurso;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAnyadirAlumno;
    }
}