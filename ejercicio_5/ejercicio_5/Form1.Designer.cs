namespace ejercicio_5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAutorrelleno = new System.Windows.Forms.Button();
            this.btnAnyadirAlumno = new System.Windows.Forms.Button();
            this.btnAnyadirProfesor = new System.Windows.Forms.Button();
            this.btnAnyadirCurso = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.btnVerAlumnos = new System.Windows.Forms.Button();
            this.btnVerProfesores = new System.Windows.Forms.Button();
            this.btnVerCursos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAutorrelleno);
            this.groupBox1.Controls.Add(this.btnAnyadirAlumno);
            this.groupBox1.Controls.Add(this.btnAnyadirProfesor);
            this.groupBox1.Controls.Add(this.btnAnyadirCurso);
            this.groupBox1.Location = new System.Drawing.Point(46, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Añadir";
            // 
            // btnAutorrelleno
            // 
            this.btnAutorrelleno.Location = new System.Drawing.Point(48, 306);
            this.btnAutorrelleno.Name = "btnAutorrelleno";
            this.btnAutorrelleno.Size = new System.Drawing.Size(211, 46);
            this.btnAutorrelleno.TabIndex = 7;
            this.btnAutorrelleno.Text = "Autorrelleno";
            this.btnAutorrelleno.UseVisualStyleBackColor = true;
            this.btnAutorrelleno.Click += new System.EventHandler(this.btnAutorrelleno_Click);
            // 
            // btnAnyadirAlumno
            // 
            this.btnAnyadirAlumno.Location = new System.Drawing.Point(48, 210);
            this.btnAnyadirAlumno.Name = "btnAnyadirAlumno";
            this.btnAnyadirAlumno.Size = new System.Drawing.Size(211, 46);
            this.btnAnyadirAlumno.TabIndex = 6;
            this.btnAnyadirAlumno.Text = "Añadir Alumno/a";
            this.btnAnyadirAlumno.UseVisualStyleBackColor = true;
            this.btnAnyadirAlumno.Click += new System.EventHandler(this.btnAnyadirAlumno_Click);
            // 
            // btnAnyadirProfesor
            // 
            this.btnAnyadirProfesor.Location = new System.Drawing.Point(48, 129);
            this.btnAnyadirProfesor.Name = "btnAnyadirProfesor";
            this.btnAnyadirProfesor.Size = new System.Drawing.Size(211, 46);
            this.btnAnyadirProfesor.TabIndex = 5;
            this.btnAnyadirProfesor.Text = "Añadir Profesor/a";
            this.btnAnyadirProfesor.UseVisualStyleBackColor = true;
            this.btnAnyadirProfesor.Click += new System.EventHandler(this.btnAnyadirProfesor_Click);
            // 
            // btnAnyadirCurso
            // 
            this.btnAnyadirCurso.Location = new System.Drawing.Point(48, 54);
            this.btnAnyadirCurso.Name = "btnAnyadirCurso";
            this.btnAnyadirCurso.Size = new System.Drawing.Size(211, 46);
            this.btnAnyadirCurso.TabIndex = 4;
            this.btnAnyadirCurso.Text = "Añadir Curso";
            this.btnAnyadirCurso.UseVisualStyleBackColor = true;
            this.btnAnyadirCurso.Click += new System.EventHandler(this.btnAnyadirCurso_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVerTodo);
            this.groupBox2.Controls.Add(this.btnVerAlumnos);
            this.groupBox2.Controls.Add(this.btnVerProfesores);
            this.groupBox2.Controls.Add(this.btnVerCursos);
            this.groupBox2.Location = new System.Drawing.Point(435, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 388);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visualizar";
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Location = new System.Drawing.Point(53, 306);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(211, 46);
            this.btnVerTodo.TabIndex = 3;
            this.btnVerTodo.Text = "Ver Todo";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // btnVerAlumnos
            // 
            this.btnVerAlumnos.Location = new System.Drawing.Point(53, 210);
            this.btnVerAlumnos.Name = "btnVerAlumnos";
            this.btnVerAlumnos.Size = new System.Drawing.Size(211, 46);
            this.btnVerAlumnos.TabIndex = 2;
            this.btnVerAlumnos.Text = "Ver Alumnado";
            this.btnVerAlumnos.UseVisualStyleBackColor = true;
            this.btnVerAlumnos.Click += new System.EventHandler(this.btnVerAlumnos_Click);
            // 
            // btnVerProfesores
            // 
            this.btnVerProfesores.Location = new System.Drawing.Point(53, 129);
            this.btnVerProfesores.Name = "btnVerProfesores";
            this.btnVerProfesores.Size = new System.Drawing.Size(211, 46);
            this.btnVerProfesores.TabIndex = 1;
            this.btnVerProfesores.Text = "Ver Profesores/as";
            this.btnVerProfesores.UseVisualStyleBackColor = true;
            this.btnVerProfesores.Click += new System.EventHandler(this.btnVerProfesores_Click);
            // 
            // btnVerCursos
            // 
            this.btnVerCursos.Location = new System.Drawing.Point(53, 54);
            this.btnVerCursos.Name = "btnVerCursos";
            this.btnVerCursos.Size = new System.Drawing.Size(211, 46);
            this.btnVerCursos.TabIndex = 0;
            this.btnVerCursos.Text = "Ver Cursos";
            this.btnVerCursos.UseVisualStyleBackColor = true;
            this.btnVerCursos.Click += new System.EventHandler(this.btnVerCursos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnyadirAlumno;
        private System.Windows.Forms.Button btnAnyadirProfesor;
        private System.Windows.Forms.Button btnAnyadirCurso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.Button btnVerAlumnos;
        private System.Windows.Forms.Button btnVerProfesores;
        private System.Windows.Forms.Button btnVerCursos;
        private System.Windows.Forms.Button btnAutorrelleno;
    }
}

