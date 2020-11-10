using System.Reflection.Emit;

namespace IPS_Mejora_tu_Salud.Interfaces
{
    partial class Modulo_Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Str_CerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Str_Buscar_Paciente = new System.Windows.Forms.ToolStripMenuItem();
            this.Str_Registro_Paciente = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDatosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verMultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Str_Buscar_Medico = new System.Windows.Forms.ToolStripMenuItem();
            this.Str_Registro_Medicos = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreYSalarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Str_Buscar_Citas = new System.Windows.Forms.ToolStripMenuItem();
            this.Str_Registro_Cita = new System.Windows.Forms.ToolStripMenuItem();
            this.citasImcumplidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Grupo_Buscar = new System.Windows.Forms.GroupBox();
            this.lbl_Documento = new System.Windows.Forms.Label();
            this.txt_documento = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.Grupo_Registro = new System.Windows.Forms.GroupBox();
            this.btn_RegistroPaciente = new System.Windows.Forms.Button();
            this.txt_FechaRegistro = new System.Windows.Forms.TextBox();
            this.lbl_FechaRegistroPaciente = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_EmailPaciente = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.lbl_TelefonoPaciente = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.lbl_DireccionPaciente = new System.Windows.Forms.Label();
            this.txt_FechaNacimiento = new System.Windows.Forms.TextBox();
            this.lbl_FechaNacimientoPaciente = new System.Windows.Forms.Label();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.lbl_ApellidosPaciente = new System.Windows.Forms.Label();
            this.txt_Nombres = new System.Windows.Forms.TextBox();
            this.lbl_NombresPaciente = new System.Windows.Forms.Label();
            this.txt_Identificacion = new System.Windows.Forms.TextBox();
            this.lbl_IdentificacionPaciente = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Grupo_Buscar.SuspendLayout();
            this.Grupo_Registro.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Str_CerrarSesion,
            this.pacientesToolStripMenuItem,
            this.medicosToolStripMenuItem,
            this.citasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(837, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Str_CerrarSesion
            // 
            this.Str_CerrarSesion.Name = "Str_CerrarSesion";
            this.Str_CerrarSesion.Size = new System.Drawing.Size(88, 22);
            this.Str_CerrarSesion.Text = "Cerrar Sesion";
            this.Str_CerrarSesion.Click += new System.EventHandler(this.Str_CerrarSesion_Click_1);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Str_Buscar_Paciente,
            this.Str_Registro_Paciente,
            this.actualizarDatosToolStripMenuItem1,
            this.verMultasToolStripMenuItem,
            this.verCitasToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // Str_Buscar_Paciente
            // 
            this.Str_Buscar_Paciente.BackColor = System.Drawing.SystemColors.Control;
            this.Str_Buscar_Paciente.Name = "Str_Buscar_Paciente";
            this.Str_Buscar_Paciente.Size = new System.Drawing.Size(159, 22);
            this.Str_Buscar_Paciente.Text = "Buscar";
            this.Str_Buscar_Paciente.Click += new System.EventHandler(this.Str_Buscar_Paciente_Click);
            // 
            // Str_Registro_Paciente
            // 
            this.Str_Registro_Paciente.Name = "Str_Registro_Paciente";
            this.Str_Registro_Paciente.Size = new System.Drawing.Size(159, 22);
            this.Str_Registro_Paciente.Text = "Registar";
            this.Str_Registro_Paciente.Click += new System.EventHandler(this.Str_Registro_Paciente_Click);
            // 
            // actualizarDatosToolStripMenuItem1
            // 
            this.actualizarDatosToolStripMenuItem1.Name = "actualizarDatosToolStripMenuItem1";
            this.actualizarDatosToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.actualizarDatosToolStripMenuItem1.Text = "Actualizar Datos";
            // 
            // verMultasToolStripMenuItem
            // 
            this.verMultasToolStripMenuItem.Name = "verMultasToolStripMenuItem";
            this.verMultasToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.verMultasToolStripMenuItem.Text = "Ver Multas";
            // 
            // verCitasToolStripMenuItem
            // 
            this.verCitasToolStripMenuItem.Name = "verCitasToolStripMenuItem";
            this.verCitasToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.verCitasToolStripMenuItem.Text = "Ver Citas";
            // 
            // medicosToolStripMenuItem
            // 
            this.medicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Str_Buscar_Medico,
            this.Str_Registro_Medicos,
            this.actualizarDatosToolStripMenuItem,
            this.pagosToolStripMenuItem});
            this.medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            this.medicosToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.medicosToolStripMenuItem.Text = "Medicos";
            // 
            // Str_Buscar_Medico
            // 
            this.Str_Buscar_Medico.Name = "Str_Buscar_Medico";
            this.Str_Buscar_Medico.Size = new System.Drawing.Size(129, 22);
            this.Str_Buscar_Medico.Text = "Buscar";
            this.Str_Buscar_Medico.Click += new System.EventHandler(this.Str_Buscar_Medico_Click);
            // 
            // Str_Registro_Medicos
            // 
            this.Str_Registro_Medicos.Name = "Str_Registro_Medicos";
            this.Str_Registro_Medicos.Size = new System.Drawing.Size(129, 22);
            this.Str_Registro_Medicos.Text = "Registro";
            this.Str_Registro_Medicos.Click += new System.EventHandler(this.Str_Registro_Medicos_Click);
            // 
            // actualizarDatosToolStripMenuItem
            // 
            this.actualizarDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosToolStripMenuItem,
            this.nombreYSalarioToolStripMenuItem});
            this.actualizarDatosToolStripMenuItem.Name = "actualizarDatosToolStripMenuItem";
            this.actualizarDatosToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.actualizarDatosToolStripMenuItem.Text = "Actualizar ";
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.datosToolStripMenuItem.Text = "Datos";
            // 
            // nombreYSalarioToolStripMenuItem
            // 
            this.nombreYSalarioToolStripMenuItem.Name = "nombreYSalarioToolStripMenuItem";
            this.nombreYSalarioToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.nombreYSalarioToolStripMenuItem.Text = "Nombre y Salario";
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Str_Buscar_Citas,
            this.Str_Registro_Cita,
            this.citasImcumplidasToolStripMenuItem});
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(45, 22);
            this.citasToolStripMenuItem.Text = "Citas";
            // 
            // Str_Buscar_Citas
            // 
            this.Str_Buscar_Citas.Name = "Str_Buscar_Citas";
            this.Str_Buscar_Citas.Size = new System.Drawing.Size(172, 22);
            this.Str_Buscar_Citas.Text = "Buscar Citas";
            this.Str_Buscar_Citas.Click += new System.EventHandler(this.Str_Buscar_Citas_Click);
            // 
            // Str_Registro_Cita
            // 
            this.Str_Registro_Cita.Name = "Str_Registro_Cita";
            this.Str_Registro_Cita.Size = new System.Drawing.Size(172, 22);
            this.Str_Registro_Cita.Text = "Registar Cita";
            this.Str_Registro_Cita.Click += new System.EventHandler(this.Str_Registro_Cita_Click);
            // 
            // citasImcumplidasToolStripMenuItem
            // 
            this.citasImcumplidasToolStripMenuItem.Name = "citasImcumplidasToolStripMenuItem";
            this.citasImcumplidasToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.citasImcumplidasToolStripMenuItem.Text = "Citas Imcumplidas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(258, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(579, 354);
            this.dataGridView1.TabIndex = 1;
            // 
            // Grupo_Buscar
            // 
            this.Grupo_Buscar.Controls.Add(this.lbl_Documento);
            this.Grupo_Buscar.Controls.Add(this.txt_documento);
            this.Grupo_Buscar.Controls.Add(this.btn_Buscar);
            this.Grupo_Buscar.Location = new System.Drawing.Point(8, 29);
            this.Grupo_Buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Grupo_Buscar.Name = "Grupo_Buscar";
            this.Grupo_Buscar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Grupo_Buscar.Size = new System.Drawing.Size(246, 69);
            this.Grupo_Buscar.TabIndex = 2;
            this.Grupo_Buscar.TabStop = false;
            this.Grupo_Buscar.Text = "Buscar";
            this.Grupo_Buscar.Visible = false;
            // 
            // lbl_Documento
            // 
            this.lbl_Documento.AutoSize = true;
            this.lbl_Documento.Location = new System.Drawing.Point(4, 21);
            this.lbl_Documento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Documento.Name = "lbl_Documento";
            this.lbl_Documento.Size = new System.Drawing.Size(65, 13);
            this.lbl_Documento.TabIndex = 2;
            this.lbl_Documento.Text = "Documento:";
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(72, 21);
            this.txt_documento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(171, 20);
            this.txt_documento.TabIndex = 1;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(176, 42);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(60, 23);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Grupo_Registro
            // 
            this.Grupo_Registro.Controls.Add(this.btn_RegistroPaciente);
            this.Grupo_Registro.Controls.Add(this.txt_FechaRegistro);
            this.Grupo_Registro.Controls.Add(this.lbl_FechaRegistroPaciente);
            this.Grupo_Registro.Controls.Add(this.txt_Email);
            this.Grupo_Registro.Controls.Add(this.lbl_EmailPaciente);
            this.Grupo_Registro.Controls.Add(this.txt_Telefono);
            this.Grupo_Registro.Controls.Add(this.lbl_TelefonoPaciente);
            this.Grupo_Registro.Controls.Add(this.txt_Direccion);
            this.Grupo_Registro.Controls.Add(this.lbl_DireccionPaciente);
            this.Grupo_Registro.Controls.Add(this.txt_FechaNacimiento);
            this.Grupo_Registro.Controls.Add(this.lbl_FechaNacimientoPaciente);
            this.Grupo_Registro.Controls.Add(this.txt_Apellidos);
            this.Grupo_Registro.Controls.Add(this.lbl_ApellidosPaciente);
            this.Grupo_Registro.Controls.Add(this.txt_Nombres);
            this.Grupo_Registro.Controls.Add(this.lbl_NombresPaciente);
            this.Grupo_Registro.Controls.Add(this.txt_Identificacion);
            this.Grupo_Registro.Controls.Add(this.lbl_IdentificacionPaciente);
            this.Grupo_Registro.Location = new System.Drawing.Point(8, 102);
            this.Grupo_Registro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Grupo_Registro.Name = "Grupo_Registro";
            this.Grupo_Registro.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Grupo_Registro.Size = new System.Drawing.Size(246, 269);
            this.Grupo_Registro.TabIndex = 3;
            this.Grupo_Registro.TabStop = false;
            this.Grupo_Registro.Text = "Registro";
            this.Grupo_Registro.Visible = false;
            // 
            // btn_RegistroPaciente
            // 
            this.btn_RegistroPaciente.Location = new System.Drawing.Point(87, 226);
            this.btn_RegistroPaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_RegistroPaciente.Name = "btn_RegistroPaciente";
            this.btn_RegistroPaciente.Size = new System.Drawing.Size(60, 23);
            this.btn_RegistroPaciente.TabIndex = 3;
            this.btn_RegistroPaciente.Text = "Buscar";
            this.btn_RegistroPaciente.UseVisualStyleBackColor = true;
            // 
            // txt_FechaRegistro
            // 
            this.txt_FechaRegistro.Location = new System.Drawing.Point(101, 185);
            this.txt_FechaRegistro.Name = "txt_FechaRegistro";
            this.txt_FechaRegistro.Size = new System.Drawing.Size(143, 20);
            this.txt_FechaRegistro.TabIndex = 17;
            // 
            // lbl_FechaRegistroPaciente
            // 
            this.lbl_FechaRegistroPaciente.AutoSize = true;
            this.lbl_FechaRegistroPaciente.Location = new System.Drawing.Point(4, 187);
            this.lbl_FechaRegistroPaciente.Name = "lbl_FechaRegistroPaciente";
            this.lbl_FechaRegistroPaciente.Size = new System.Drawing.Size(92, 13);
            this.lbl_FechaRegistroPaciente.TabIndex = 16;
            this.lbl_FechaRegistroPaciente.Text = "Fecha de registro:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(77, 158);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(166, 20);
            this.txt_Email.TabIndex = 15;
            // 
            // lbl_EmailPaciente
            // 
            this.lbl_EmailPaciente.AutoSize = true;
            this.lbl_EmailPaciente.Location = new System.Drawing.Point(26, 160);
            this.lbl_EmailPaciente.Name = "lbl_EmailPaciente";
            this.lbl_EmailPaciente.Size = new System.Drawing.Size(35, 13);
            this.lbl_EmailPaciente.TabIndex = 14;
            this.lbl_EmailPaciente.Text = "Email:";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(77, 135);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(166, 20);
            this.txt_Telefono.TabIndex = 13;
            // 
            // lbl_TelefonoPaciente
            // 
            this.lbl_TelefonoPaciente.AutoSize = true;
            this.lbl_TelefonoPaciente.Location = new System.Drawing.Point(11, 136);
            this.lbl_TelefonoPaciente.Name = "lbl_TelefonoPaciente";
            this.lbl_TelefonoPaciente.Size = new System.Drawing.Size(52, 13);
            this.lbl_TelefonoPaciente.TabIndex = 12;
            this.lbl_TelefonoPaciente.Text = "Teléfono:";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(77, 111);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(166, 20);
            this.txt_Direccion.TabIndex = 11;
            // 
            // lbl_DireccionPaciente
            // 
            this.lbl_DireccionPaciente.AutoSize = true;
            this.lbl_DireccionPaciente.Location = new System.Drawing.Point(9, 110);
            this.lbl_DireccionPaciente.Name = "lbl_DireccionPaciente";
            this.lbl_DireccionPaciente.Size = new System.Drawing.Size(55, 13);
            this.lbl_DireccionPaciente.TabIndex = 10;
            this.lbl_DireccionPaciente.Text = "Dirección:";
            // 
            // txt_FechaNacimiento
            // 
            this.txt_FechaNacimiento.Location = new System.Drawing.Point(115, 88);
            this.txt_FechaNacimiento.Name = "txt_FechaNacimiento";
            this.txt_FechaNacimiento.Size = new System.Drawing.Size(128, 20);
            this.txt_FechaNacimiento.TabIndex = 9;
            // 
            // lbl_FechaNacimientoPaciente
            // 
            this.lbl_FechaNacimientoPaciente.AutoSize = true;
            this.lbl_FechaNacimientoPaciente.Location = new System.Drawing.Point(2, 90);
            this.lbl_FechaNacimientoPaciente.Name = "lbl_FechaNacimientoPaciente";
            this.lbl_FechaNacimientoPaciente.Size = new System.Drawing.Size(111, 13);
            this.lbl_FechaNacimientoPaciente.TabIndex = 8;
            this.lbl_FechaNacimientoPaciente.Text = "Fecha de Nacimiento:";
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Location = new System.Drawing.Point(77, 64);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(166, 20);
            this.txt_Apellidos.TabIndex = 7;
            // 
            // lbl_ApellidosPaciente
            // 
            this.lbl_ApellidosPaciente.AutoSize = true;
            this.lbl_ApellidosPaciente.Location = new System.Drawing.Point(11, 66);
            this.lbl_ApellidosPaciente.Name = "lbl_ApellidosPaciente";
            this.lbl_ApellidosPaciente.Size = new System.Drawing.Size(52, 13);
            this.lbl_ApellidosPaciente.TabIndex = 6;
            this.lbl_ApellidosPaciente.Text = "Apellidos:";
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.Location = new System.Drawing.Point(77, 41);
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.Size = new System.Drawing.Size(166, 20);
            this.txt_Nombres.TabIndex = 5;
            // 
            // lbl_NombresPaciente
            // 
            this.lbl_NombresPaciente.AutoSize = true;
            this.lbl_NombresPaciente.Location = new System.Drawing.Point(11, 45);
            this.lbl_NombresPaciente.Name = "lbl_NombresPaciente";
            this.lbl_NombresPaciente.Size = new System.Drawing.Size(52, 13);
            this.lbl_NombresPaciente.TabIndex = 4;
            this.lbl_NombresPaciente.Text = "Nombres:";
            // 
            // txt_Identificacion
            // 
            this.txt_Identificacion.Location = new System.Drawing.Point(77, 18);
            this.txt_Identificacion.Name = "txt_Identificacion";
            this.txt_Identificacion.Size = new System.Drawing.Size(166, 20);
            this.txt_Identificacion.TabIndex = 3;
            // 
            // lbl_IdentificacionPaciente
            // 
            this.lbl_IdentificacionPaciente.AutoSize = true;
            this.lbl_IdentificacionPaciente.Location = new System.Drawing.Point(4, 19);
            this.lbl_IdentificacionPaciente.Name = "lbl_IdentificacionPaciente";
            this.lbl_IdentificacionPaciente.Size = new System.Drawing.Size(73, 13);
            this.lbl_IdentificacionPaciente.TabIndex = 2;
            this.lbl_IdentificacionPaciente.Text = "Identificación:";
            // 
            // Modulo_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 379);
            this.Controls.Add(this.Grupo_Registro);
            this.Controls.Add(this.Grupo_Buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Modulo_Principal";
            this.Text = "Modulo Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Grupo_Buscar.ResumeLayout(false);
            this.Grupo_Buscar.PerformLayout();
            this.Grupo_Registro.ResumeLayout(false);
            this.Grupo_Registro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Str_CerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Str_Buscar_Paciente;
        private System.Windows.Forms.ToolStripMenuItem Str_Registro_Paciente;
        private System.Windows.Forms.ToolStripMenuItem actualizarDatosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verMultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Str_Buscar_Medico;
        private System.Windows.Forms.ToolStripMenuItem actualizarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreYSalarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Str_Registro_Cita;
        private System.Windows.Forms.ToolStripMenuItem citasImcumplidasToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Grupo_Buscar;
        private System.Windows.Forms.Label lbl_Documento;
        private System.Windows.Forms.TextBox txt_documento;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.ToolStripMenuItem Str_Buscar_Citas;
        private System.Windows.Forms.GroupBox Grupo_Registro;
        private System.Windows.Forms.Label lbl_IdentificacionPaciente;
        private System.Windows.Forms.TextBox txt_Identificacion;
        private System.Windows.Forms.Label lbl_NombresPaciente;
        private System.Windows.Forms.TextBox txt_Nombres;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.Label lbl_ApellidosPaciente;
        private System.Windows.Forms.TextBox txt_FechaNacimiento;
        private System.Windows.Forms.Label lbl_FechaNacimientoPaciente;
        private System.Windows.Forms.Label lbl_DireccionPaciente;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label lbl_TelefonoPaciente;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_EmailPaciente;
        private System.Windows.Forms.TextBox txt_FechaRegistro;
        private System.Windows.Forms.Label lbl_FechaRegistroPaciente;
        private System.Windows.Forms.ToolStripMenuItem Str_Registro_Medicos;
        private System.Windows.Forms.Button btn_RegistroPaciente;
    }
}