namespace ejercicio_001
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
            this.components = new System.ComponentModel.Container();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.groupBoxNavegar = new System.Windows.Forms.GroupBox();
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblNumRegistro = new System.Windows.Forms.Label();
            this.btnMostrarListado = new System.Windows.Forms.Button();
            this.btnBuscarPorApellido = new System.Windows.Forms.Button();
            this.groupBoxNavegar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(123, 81);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(205, 26);
            this.txtDNI.TabIndex = 0;
            this.txtDNI.UseWaitCursor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 153);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 26);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.UseWaitCursor = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(123, 228);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(205, 26);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.UseWaitCursor = true;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(521, 153);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(205, 26);
            this.txtApellidos.TabIndex = 4;
            this.txtApellidos.UseWaitCursor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(521, 228);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 26);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.UseWaitCursor = true;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(76, 84);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(41, 20);
            this.lblDNI.TabIndex = 6;
            this.lblDNI.Text = "DNI:";
            this.lblDNI.UseWaitCursor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(48, 153);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.UseWaitCursor = true;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(438, 153);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(77, 20);
            this.lblApellidos.TabIndex = 8;
            this.lblApellidos.Text = "Apellidos:";
            this.lblApellidos.UseWaitCursor = true;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(42, 231);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(75, 20);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "Teléfono:";
            this.lblTelefono.UseWaitCursor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(463, 231);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            this.lblEmail.UseWaitCursor = true;
            // 
            // txtPrimero
            // 
            this.txtPrimero.Location = new System.Drawing.Point(26, 39);
            this.txtPrimero.Name = "txtPrimero";
            this.txtPrimero.Size = new System.Drawing.Size(133, 44);
            this.txtPrimero.TabIndex = 11;
            this.txtPrimero.Text = "Primero";
            this.txtPrimero.UseVisualStyleBackColor = true;
            this.txtPrimero.UseWaitCursor = true;
            this.txtPrimero.Click += new System.EventHandler(this.txtPrimero_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(193, 39);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(133, 44);
            this.btnAnterior.TabIndex = 12;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.UseWaitCursor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(354, 39);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(133, 44);
            this.btnSiguiente.TabIndex = 13;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.UseWaitCursor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(518, 39);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(133, 44);
            this.btnUltimo.TabIndex = 14;
            this.btnUltimo.Text = "Último";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.UseWaitCursor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // groupBoxNavegar
            // 
            this.groupBoxNavegar.Controls.Add(this.btnUltimo);
            this.groupBoxNavegar.Controls.Add(this.btnSiguiente);
            this.groupBoxNavegar.Controls.Add(this.txtPrimero);
            this.groupBoxNavegar.Controls.Add(this.btnAnterior);
            this.groupBoxNavegar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.groupBoxNavegar.Location = new System.Drawing.Point(46, 340);
            this.groupBoxNavegar.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.groupBoxNavegar.Name = "groupBoxNavegar";
            this.groupBoxNavegar.Padding = new System.Windows.Forms.Padding(5, 30, 3, 3);
            this.groupBoxNavegar.Size = new System.Drawing.Size(680, 103);
            this.groupBoxNavegar.TabIndex = 15;
            this.groupBoxNavegar.TabStop = false;
            this.groupBoxNavegar.Text = "Navegar";
            this.groupBoxNavegar.UseWaitCursor = true;
            // 
            // btnAnyadir
            // 
            this.btnAnyadir.Location = new System.Drawing.Point(26, 34);
            this.btnAnyadir.Name = "btnAnyadir";
            this.btnAnyadir.Size = new System.Drawing.Size(133, 44);
            this.btnAnyadir.TabIndex = 15;
            this.btnAnyadir.Text = "Añadir";
            this.btnAnyadir.UseVisualStyleBackColor = true;
            this.btnAnyadir.UseWaitCursor = true;
            this.btnAnyadir.Click += new System.EventHandler(this.btnAnyadir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(193, 34);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(133, 44);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.UseWaitCursor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnAnyadir);
            this.groupBox1.Location = new System.Drawing.Point(46, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(348, 95);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Registro";
            this.groupBox1.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Location = new System.Drawing.Point(400, 467);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 95);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actualizar y Eliminar";
            this.groupBox2.UseWaitCursor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(175, 34);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 44);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.UseWaitCursor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(22, 34);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(133, 44);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.UseWaitCursor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(293, 297);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(104, 30);
            this.lblRegistro.TabIndex = 26;
            this.lblRegistro.Text = "Registro";
            // 
            // lblNumRegistro
            // 
            this.lblNumRegistro.AutoSize = true;
            this.lblNumRegistro.Location = new System.Drawing.Point(375, 297);
            this.lblNumRegistro.Name = "lblNumRegistro";
            this.lblNumRegistro.Size = new System.Drawing.Size(0, 30);
            this.lblNumRegistro.TabIndex = 27;
            // 
            // btnMostrarListado
            // 
            this.btnMostrarListado.Location = new System.Drawing.Point(593, 47);
            this.btnMostrarListado.Name = "btnMostrarListado";
            this.btnMostrarListado.Size = new System.Drawing.Size(133, 44);
            this.btnMostrarListado.TabIndex = 17;
            this.btnMostrarListado.Text = "Mostrar Listado";
            this.btnMostrarListado.UseVisualStyleBackColor = true;
            this.btnMostrarListado.UseWaitCursor = true;
            this.btnMostrarListado.Click += new System.EventHandler(this.btnMostrarListado_Click);
            // 
            // btnBuscarPorApellido
            // 
            this.btnBuscarPorApellido.Location = new System.Drawing.Point(297, 612);
            this.btnBuscarPorApellido.Name = "btnBuscarPorApellido";
            this.btnBuscarPorApellido.Size = new System.Drawing.Size(176, 44);
            this.btnBuscarPorApellido.TabIndex = 28;
            this.btnBuscarPorApellido.Text = "Buscar Por Apellido";
            this.btnBuscarPorApellido.UseVisualStyleBackColor = true;
            this.btnBuscarPorApellido.UseWaitCursor = true;
            this.btnBuscarPorApellido.Click += new System.EventHandler(this.btnBuscarPorApellido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 696);
            this.Controls.Add(this.btnBuscarPorApellido);
            this.Controls.Add(this.btnMostrarListado);
            this.Controls.Add(this.lblNumRegistro);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxNavegar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Name = "Form1";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxNavegar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button txtPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.GroupBox groupBoxNavegar;
        private System.Windows.Forms.Button btnAnyadir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblNumRegistro;
        private System.Windows.Forms.Button btnMostrarListado;
        private System.Windows.Forms.Button btnBuscarPorApellido;
    }
}

