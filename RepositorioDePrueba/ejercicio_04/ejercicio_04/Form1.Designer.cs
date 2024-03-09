namespace ejercicio_04
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
            groupBox1 = new GroupBox();
            btnMostrarDatos = new Button();
            btnOrdenarEmpleadosAlfabetico = new Button();
            btnMostrarListaEmpleado = new Button();
            btnEliminarEmpleado = new Button();
            btnIntroducirEmpleado = new Button();
            groupBox2 = new GroupBox();
            btnOrdenarEmpleadosVentas = new Button();
            btnEliminarVentasEmpleado = new Button();
            btnMotrarEmpleadoMayoresVentas = new Button();
            btnAnyadirVentas = new Button();
            btnMostrarDatosEmpVentas = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMostrarDatos);
            groupBox1.Controls.Add(btnOrdenarEmpleadosAlfabetico);
            groupBox1.Controls.Add(btnMostrarListaEmpleado);
            groupBox1.Controls.Add(btnEliminarEmpleado);
            groupBox1.Controls.Add(btnIntroducirEmpleado);
            groupBox1.Location = new Point(47, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(901, 259);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Empleados";
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(556, 176);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(258, 35);
            btnMostrarDatos.TabIndex = 4;
            btnMostrarDatos.Text = "Mostrar Datos Empleado";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // btnOrdenarEmpleadosAlfabetico
            // 
            btnOrdenarEmpleadosAlfabetico.Location = new Point(48, 176);
            btnOrdenarEmpleadosAlfabetico.Name = "btnOrdenarEmpleadosAlfabetico";
            btnOrdenarEmpleadosAlfabetico.Size = new Size(383, 35);
            btnOrdenarEmpleadosAlfabetico.TabIndex = 3;
            btnOrdenarEmpleadosAlfabetico.Text = "Ordenar Empleados por Orden Alfabético";
            btnOrdenarEmpleadosAlfabetico.UseVisualStyleBackColor = true;
            btnOrdenarEmpleadosAlfabetico.Click += btnOrdenarEmpleadosAlfabetico_Click;
            // 
            // btnMostrarListaEmpleado
            // 
            btnMostrarListaEmpleado.Location = new Point(635, 56);
            btnMostrarListaEmpleado.Name = "btnMostrarListaEmpleado";
            btnMostrarListaEmpleado.Size = new Size(223, 34);
            btnMostrarListaEmpleado.TabIndex = 2;
            btnMostrarListaEmpleado.Text = "Mostrar Lista Empleado";
            btnMostrarListaEmpleado.UseVisualStyleBackColor = true;
            btnMostrarListaEmpleado.Click += btnMostrarListaEmpleado_Click;
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.Location = new Point(343, 56);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(185, 34);
            btnEliminarEmpleado.TabIndex = 1;
            btnEliminarEmpleado.Text = "Eliminar Empleado";
            btnEliminarEmpleado.UseVisualStyleBackColor = true;
            btnEliminarEmpleado.Click += btnEliminarEmpleado_Click;
            // 
            // btnIntroducirEmpleado
            // 
            btnIntroducirEmpleado.Location = new Point(48, 56);
            btnIntroducirEmpleado.Name = "btnIntroducirEmpleado";
            btnIntroducirEmpleado.Size = new Size(196, 34);
            btnIntroducirEmpleado.TabIndex = 0;
            btnIntroducirEmpleado.Text = "Introducir Empleado";
            btnIntroducirEmpleado.UseVisualStyleBackColor = true;
            btnIntroducirEmpleado.Click += btnIntroducirEmpleado_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnMostrarDatosEmpVentas);
            groupBox2.Controls.Add(btnOrdenarEmpleadosVentas);
            groupBox2.Controls.Add(btnEliminarVentasEmpleado);
            groupBox2.Controls.Add(btnMotrarEmpleadoMayoresVentas);
            groupBox2.Controls.Add(btnAnyadirVentas);
            groupBox2.Location = new Point(47, 322);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(901, 280);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ventas";
            // 
            // btnOrdenarEmpleadosVentas
            // 
            btnOrdenarEmpleadosVentas.Location = new Point(509, 173);
            btnOrdenarEmpleadosVentas.Name = "btnOrdenarEmpleadosVentas";
            btnOrdenarEmpleadosVentas.Size = new Size(331, 38);
            btnOrdenarEmpleadosVentas.TabIndex = 3;
            btnOrdenarEmpleadosVentas.Text = "Ordenar Emplados por Ventas";
            btnOrdenarEmpleadosVentas.UseVisualStyleBackColor = true;
            btnOrdenarEmpleadosVentas.Click += btnOrdenarEmpleadosVentas_Click;
            // 
            // btnEliminarVentasEmpleado
            // 
            btnEliminarVentasEmpleado.Location = new Point(48, 173);
            btnEliminarVentasEmpleado.Name = "btnEliminarVentasEmpleado";
            btnEliminarVentasEmpleado.Size = new Size(311, 38);
            btnEliminarVentasEmpleado.TabIndex = 2;
            btnEliminarVentasEmpleado.Text = "Eliminar las Ventas de un Empleado";
            btnEliminarVentasEmpleado.UseVisualStyleBackColor = true;
            btnEliminarVentasEmpleado.Click += btnEliminarVentasEmpleado_Click;
            // 
            // btnMotrarEmpleadoMayoresVentas
            // 
            btnMotrarEmpleadoMayoresVentas.Location = new Point(509, 57);
            btnMotrarEmpleadoMayoresVentas.Name = "btnMotrarEmpleadoMayoresVentas";
            btnMotrarEmpleadoMayoresVentas.Size = new Size(331, 35);
            btnMotrarEmpleadoMayoresVentas.TabIndex = 1;
            btnMotrarEmpleadoMayoresVentas.Text = "Mostrar Emplado con Mayores Ventas";
            btnMotrarEmpleadoMayoresVentas.UseVisualStyleBackColor = true;
            btnMotrarEmpleadoMayoresVentas.Click += btnMotrarEmpleadoMayoresVentas_Click;
            // 
            // btnAnyadirVentas
            // 
            btnAnyadirVentas.Location = new Point(48, 57);
            btnAnyadirVentas.Name = "btnAnyadirVentas";
            btnAnyadirVentas.Size = new Size(311, 35);
            btnAnyadirVentas.TabIndex = 0;
            btnAnyadirVentas.Text = "Añadir Ventas a Empleado";
            btnAnyadirVentas.UseVisualStyleBackColor = true;
            btnAnyadirVentas.Click += btnAnyadirVentas_Click;
            // 
            // btnMostrarDatosEmpVentas
            // 
            btnMostrarDatosEmpVentas.Location = new Point(284, 228);
            btnMostrarDatosEmpVentas.Name = "btnMostrarDatosEmpVentas";
            btnMostrarDatosEmpVentas.Size = new Size(275, 34);
            btnMostrarDatosEmpVentas.TabIndex = 4;
            btnMostrarDatosEmpVentas.Text = "Mostrar Datos Empleado";
            btnMostrarDatosEmpVentas.UseVisualStyleBackColor = true;
            btnMostrarDatosEmpVentas.Click += btnMostrarDatosEmpVentas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 627);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Empleados y Sus Ventas";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnMostrarDatos;
        private Button btnOrdenarEmpleadosAlfabetico;
        private Button btnMostrarListaEmpleado;
        private Button btnEliminarEmpleado;
        private Button btnIntroducirEmpleado;
        private Button btnOrdenarEmpleadosVentas;
        private Button btnEliminarVentasEmpleado;
        private Button btnMotrarEmpleadoMayoresVentas;
        private Button btnAnyadirVentas;
        private Button btnMostrarDatosEmpVentas;
    }
}