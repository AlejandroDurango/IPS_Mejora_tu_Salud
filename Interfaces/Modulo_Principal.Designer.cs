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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modulo_Principal));
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
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Grupo_Registro = new System.Windows.Forms.GroupBox();
            this.DatoFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.DatoFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.Btn_Registro = new System.Windows.Forms.Button();
            this.lbl_FechaRegistroPaciente = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_EmailPaciente = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.lbl_Telefono_Salario = new System.Windows.Forms.Label();
            this.lbl_Direccion_AñosExp = new System.Windows.Forms.Label();
            this.lbl_FechaNa_Especialidad = new System.Windows.Forms.Label();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.txt_Nombres = new System.Windows.Forms.TextBox();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.txt_Identificacion = new System.Windows.Forms.TextBox();
            this.lbl_Identificacion = new System.Windows.Forms.Label();
            this.ComboEspecialidades = new System.Windows.Forms.ComboBox();
            this.txt_Salario = new System.Windows.Forms.TextBox();
            this.Txt_Años = new System.Windows.Forms.NumericUpDown();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.lblResultados = new System.Windows.Forms.Label();
            this.Logoup = new System.Windows.Forms.PictureBox();
            this.Logodown = new System.Windows.Forms.PictureBox();
            this.Grupo_Actualizar = new System.Windows.Forms.GroupBox();
            this.txt_up_email_nombre = new System.Windows.Forms.TextBox();
            this.lbl_up_identificacion = new System.Windows.Forms.Label();
            this.lbl_up_email_nombre = new System.Windows.Forms.Label();
            this.txt_up_identificacion = new System.Windows.Forms.TextBox();
            this.btn_up_buscar = new System.Windows.Forms.Button();
            this.lbl_up_direccion_salario = new System.Windows.Forms.Label();
            this.txt_up_direccion_salario = new System.Windows.Forms.TextBox();
            this.lbl_up_telefono = new System.Windows.Forms.Label();
            this.txt_up_telefono = new System.Windows.Forms.TextBox();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.LogoDown_Mini = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Grupo_Buscar.SuspendLayout();
            this.Grupo_Registro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Años)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logoup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logodown)).BeginInit();
            this.Grupo_Actualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoDown_Mini)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Str_CerrarSesion,
            this.pacientesToolStripMenuItem,
            this.medicosToolStripMenuItem,
            this.citasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1255, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Str_CerrarSesion
            // 
            this.Str_CerrarSesion.Name = "Str_CerrarSesion";
            this.Str_CerrarSesion.Size = new System.Drawing.Size(132, 32);
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
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // Str_Buscar_Paciente
            // 
            this.Str_Buscar_Paciente.BackColor = System.Drawing.SystemColors.Control;
            this.Str_Buscar_Paciente.Name = "Str_Buscar_Paciente";
            this.Str_Buscar_Paciente.Size = new System.Drawing.Size(270, 34);
            this.Str_Buscar_Paciente.Text = "Buscar";
            this.Str_Buscar_Paciente.Click += new System.EventHandler(this.Str_Buscar_Paciente_Click);
            // 
            // Str_Registro_Paciente
            // 
            this.Str_Registro_Paciente.Name = "Str_Registro_Paciente";
            this.Str_Registro_Paciente.Size = new System.Drawing.Size(270, 34);
            this.Str_Registro_Paciente.Text = "Registar";
            this.Str_Registro_Paciente.Click += new System.EventHandler(this.Str_Registro_Paciente_Click);
            // 
            // actualizarDatosToolStripMenuItem1
            // 
            this.actualizarDatosToolStripMenuItem1.Name = "actualizarDatosToolStripMenuItem1";
            this.actualizarDatosToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.actualizarDatosToolStripMenuItem1.Text = "Actualizar Datos";
            this.actualizarDatosToolStripMenuItem1.Click += new System.EventHandler(this.actualizarDatosToolStripMenuItem1_Click);
            // 
            // verMultasToolStripMenuItem
            // 
            this.verMultasToolStripMenuItem.Name = "verMultasToolStripMenuItem";
            this.verMultasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verMultasToolStripMenuItem.Text = "Ver Multas";
            // 
            // verCitasToolStripMenuItem
            // 
            this.verCitasToolStripMenuItem.Name = "verCitasToolStripMenuItem";
            this.verCitasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
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
            this.medicosToolStripMenuItem.Size = new System.Drawing.Size(95, 32);
            this.medicosToolStripMenuItem.Text = "Medicos";
            // 
            // Str_Buscar_Medico
            // 
            this.Str_Buscar_Medico.Name = "Str_Buscar_Medico";
            this.Str_Buscar_Medico.Size = new System.Drawing.Size(270, 34);
            this.Str_Buscar_Medico.Text = "Buscar";
            this.Str_Buscar_Medico.Click += new System.EventHandler(this.Str_Buscar_Medico_Click);
            // 
            // Str_Registro_Medicos
            // 
            this.Str_Registro_Medicos.Name = "Str_Registro_Medicos";
            this.Str_Registro_Medicos.Size = new System.Drawing.Size(270, 34);
            this.Str_Registro_Medicos.Text = "Registro";
            this.Str_Registro_Medicos.Click += new System.EventHandler(this.Str_Registro_Medicos_Click);
            // 
            // actualizarDatosToolStripMenuItem
            // 
            this.actualizarDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreYSalarioToolStripMenuItem});
            this.actualizarDatosToolStripMenuItem.Name = "actualizarDatosToolStripMenuItem";
            this.actualizarDatosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.actualizarDatosToolStripMenuItem.Text = "Actualizar Datos";
            this.actualizarDatosToolStripMenuItem.Click += new System.EventHandler(this.actualizarDatosToolStripMenuItem_Click);
            // 
            // nombreYSalarioToolStripMenuItem
            // 
            this.nombreYSalarioToolStripMenuItem.Name = "nombreYSalarioToolStripMenuItem";
            this.nombreYSalarioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.nombreYSalarioToolStripMenuItem.Text = "Nombre y Salario";
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Str_Buscar_Citas,
            this.Str_Registro_Cita,
            this.citasImcumplidasToolStripMenuItem});
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(66, 32);
            this.citasToolStripMenuItem.Text = "Citas";
            // 
            // Str_Buscar_Citas
            // 
            this.Str_Buscar_Citas.Name = "Str_Buscar_Citas";
            this.Str_Buscar_Citas.Size = new System.Drawing.Size(259, 34);
            this.Str_Buscar_Citas.Text = "Buscar Citas";
            this.Str_Buscar_Citas.Click += new System.EventHandler(this.Str_Buscar_Citas_Click);
            // 
            // Str_Registro_Cita
            // 
            this.Str_Registro_Cita.Name = "Str_Registro_Cita";
            this.Str_Registro_Cita.Size = new System.Drawing.Size(259, 34);
            this.Str_Registro_Cita.Text = "Registar Cita";
            this.Str_Registro_Cita.Click += new System.EventHandler(this.Str_Registro_Cita_Click);
            // 
            // citasImcumplidasToolStripMenuItem
            // 
            this.citasImcumplidasToolStripMenuItem.Name = "citasImcumplidasToolStripMenuItem";
            this.citasImcumplidasToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.citasImcumplidasToolStripMenuItem.Text = "Citas Imcumplidas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(868, 544);
            this.dataGridView1.TabIndex = 1;
            // 
            // Grupo_Buscar
            // 
            this.Grupo_Buscar.Controls.Add(this.lbl_Documento);
            this.Grupo_Buscar.Controls.Add(this.txt_documento);
            this.Grupo_Buscar.Controls.Add(this.Btn_Buscar);
            this.Grupo_Buscar.Location = new System.Drawing.Point(12, 41);
            this.Grupo_Buscar.Name = "Grupo_Buscar";
            this.Grupo_Buscar.Size = new System.Drawing.Size(369, 106);
            this.Grupo_Buscar.TabIndex = 2;
            this.Grupo_Buscar.TabStop = false;
            this.Grupo_Buscar.Text = "Buscar";
            this.Grupo_Buscar.Visible = false;
            // 
            // lbl_Documento
            // 
            this.lbl_Documento.AutoSize = true;
            this.lbl_Documento.Location = new System.Drawing.Point(7, 36);
            this.lbl_Documento.Name = "lbl_Documento";
            this.lbl_Documento.Size = new System.Drawing.Size(107, 20);
            this.lbl_Documento.TabIndex = 2;
            this.lbl_Documento.Text = "Identificacion:";
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(121, 33);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(242, 26);
            this.txt_documento.TabIndex = 1;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(264, 65);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(90, 35);
            this.Btn_Buscar.TabIndex = 0;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Grupo_Registro
            // 
            this.Grupo_Registro.Controls.Add(this.LogoDown_Mini);
            this.Grupo_Registro.Controls.Add(this.DatoFechaRegistro);
            this.Grupo_Registro.Controls.Add(this.DatoFechaNacimiento);
            this.Grupo_Registro.Controls.Add(this.Btn_Registro);
            this.Grupo_Registro.Controls.Add(this.lbl_FechaRegistroPaciente);
            this.Grupo_Registro.Controls.Add(this.txt_Email);
            this.Grupo_Registro.Controls.Add(this.lbl_EmailPaciente);
            this.Grupo_Registro.Controls.Add(this.txt_Telefono);
            this.Grupo_Registro.Controls.Add(this.lbl_Telefono_Salario);
            this.Grupo_Registro.Controls.Add(this.lbl_Direccion_AñosExp);
            this.Grupo_Registro.Controls.Add(this.lbl_FechaNa_Especialidad);
            this.Grupo_Registro.Controls.Add(this.txt_Apellidos);
            this.Grupo_Registro.Controls.Add(this.lbl_Apellidos);
            this.Grupo_Registro.Controls.Add(this.txt_Nombres);
            this.Grupo_Registro.Controls.Add(this.lbl_Nombres);
            this.Grupo_Registro.Controls.Add(this.txt_Identificacion);
            this.Grupo_Registro.Controls.Add(this.lbl_Identificacion);
            this.Grupo_Registro.Controls.Add(this.ComboEspecialidades);
            this.Grupo_Registro.Controls.Add(this.txt_Salario);
            this.Grupo_Registro.Controls.Add(this.Txt_Años);
            this.Grupo_Registro.Controls.Add(this.txt_Direccion);
            this.Grupo_Registro.Location = new System.Drawing.Point(12, 157);
            this.Grupo_Registro.Name = "Grupo_Registro";
            this.Grupo_Registro.Size = new System.Drawing.Size(369, 414);
            this.Grupo_Registro.TabIndex = 3;
            this.Grupo_Registro.TabStop = false;
            this.Grupo_Registro.Text = "Registro";
            this.Grupo_Registro.Visible = false;
            // 
            // DatoFechaRegistro
            // 
            this.DatoFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatoFechaRegistro.Location = new System.Drawing.Point(176, 284);
            this.DatoFechaRegistro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatoFechaRegistro.Name = "DatoFechaRegistro";
            this.DatoFechaRegistro.Size = new System.Drawing.Size(186, 26);
            this.DatoFechaRegistro.TabIndex = 19;
            // 
            // DatoFechaNacimiento
            // 
            this.DatoFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatoFechaNacimiento.Location = new System.Drawing.Point(176, 138);
            this.DatoFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatoFechaNacimiento.Name = "DatoFechaNacimiento";
            this.DatoFechaNacimiento.Size = new System.Drawing.Size(187, 26);
            this.DatoFechaNacimiento.TabIndex = 18;
            // 
            // Btn_Registro
            // 
            this.Btn_Registro.Location = new System.Drawing.Point(130, 348);
            this.Btn_Registro.Name = "Btn_Registro";
            this.Btn_Registro.Size = new System.Drawing.Size(90, 35);
            this.Btn_Registro.TabIndex = 3;
            this.Btn_Registro.Text = "Registar";
            this.Btn_Registro.UseMnemonic = false;
            this.Btn_Registro.UseVisualStyleBackColor = true;
            this.Btn_Registro.Click += new System.EventHandler(this.Btn_Registro_click);
            // 
            // lbl_FechaRegistroPaciente
            // 
            this.lbl_FechaRegistroPaciente.AutoSize = true;
            this.lbl_FechaRegistroPaciente.Location = new System.Drawing.Point(7, 284);
            this.lbl_FechaRegistroPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FechaRegistroPaciente.Name = "lbl_FechaRegistroPaciente";
            this.lbl_FechaRegistroPaciente.Size = new System.Drawing.Size(137, 20);
            this.lbl_FechaRegistroPaciente.TabIndex = 16;
            this.lbl_FechaRegistroPaciente.Text = "Fecha de registro:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(91, 243);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(272, 26);
            this.txt_Email.TabIndex = 15;
            // 
            // lbl_EmailPaciente
            // 
            this.lbl_EmailPaciente.AutoSize = true;
            this.lbl_EmailPaciente.Location = new System.Drawing.Point(6, 246);
            this.lbl_EmailPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_EmailPaciente.Name = "lbl_EmailPaciente";
            this.lbl_EmailPaciente.Size = new System.Drawing.Size(52, 20);
            this.lbl_EmailPaciente.TabIndex = 14;
            this.lbl_EmailPaciente.Text = "Email:";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(91, 207);
            this.txt_Telefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(272, 26);
            this.txt_Telefono.TabIndex = 13;
            // 
            // lbl_Telefono_Salario
            // 
            this.lbl_Telefono_Salario.AutoSize = true;
            this.lbl_Telefono_Salario.Location = new System.Drawing.Point(6, 207);
            this.lbl_Telefono_Salario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Telefono_Salario.Name = "lbl_Telefono_Salario";
            this.lbl_Telefono_Salario.Size = new System.Drawing.Size(75, 20);
            this.lbl_Telefono_Salario.TabIndex = 12;
            this.lbl_Telefono_Salario.Text = "Telefono:";
            // 
            // lbl_Direccion_AñosExp
            // 
            this.lbl_Direccion_AñosExp.AutoSize = true;
            this.lbl_Direccion_AñosExp.Location = new System.Drawing.Point(7, 171);
            this.lbl_Direccion_AñosExp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Direccion_AñosExp.Name = "lbl_Direccion_AñosExp";
            this.lbl_Direccion_AñosExp.Size = new System.Drawing.Size(79, 20);
            this.lbl_Direccion_AñosExp.TabIndex = 10;
            this.lbl_Direccion_AñosExp.Text = "Dirección:";
            // 
            // lbl_FechaNa_Especialidad
            // 
            this.lbl_FechaNa_Especialidad.AutoSize = true;
            this.lbl_FechaNa_Especialidad.Location = new System.Drawing.Point(6, 138);
            this.lbl_FechaNa_Especialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FechaNa_Especialidad.Name = "lbl_FechaNa_Especialidad";
            this.lbl_FechaNa_Especialidad.Size = new System.Drawing.Size(159, 20);
            this.lbl_FechaNa_Especialidad.TabIndex = 8;
            this.lbl_FechaNa_Especialidad.Text = "Fecha de Nacimiento";
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Location = new System.Drawing.Point(91, 99);
            this.txt_Apellidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(271, 26);
            this.txt_Apellidos.TabIndex = 7;
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Location = new System.Drawing.Point(6, 99);
            this.lbl_Apellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(77, 20);
            this.lbl_Apellidos.TabIndex = 6;
            this.lbl_Apellidos.Text = "Apellidos:";
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.Location = new System.Drawing.Point(91, 63);
            this.txt_Nombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.Size = new System.Drawing.Size(271, 26);
            this.txt_Nombres.TabIndex = 5;
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.Location = new System.Drawing.Point(6, 69);
            this.lbl_Nombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(77, 20);
            this.lbl_Nombres.TabIndex = 4;
            this.lbl_Nombres.Text = "Nombres:";
            // 
            // txt_Identificacion
            // 
            this.txt_Identificacion.Location = new System.Drawing.Point(115, 27);
            this.txt_Identificacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Identificacion.Name = "txt_Identificacion";
            this.txt_Identificacion.Size = new System.Drawing.Size(247, 26);
            this.txt_Identificacion.TabIndex = 3;
            // 
            // lbl_Identificacion
            // 
            this.lbl_Identificacion.AutoSize = true;
            this.lbl_Identificacion.Location = new System.Drawing.Point(6, 30);
            this.lbl_Identificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Identificacion.Name = "lbl_Identificacion";
            this.lbl_Identificacion.Size = new System.Drawing.Size(107, 20);
            this.lbl_Identificacion.TabIndex = 2;
            this.lbl_Identificacion.Text = "Identificación:";
            // 
            // ComboEspecialidades
            // 
            this.ComboEspecialidades.FormattingEnabled = true;
            this.ComboEspecialidades.Items.AddRange(new object[] {
            "Medico General",
            "Optometria",
            "Pediatria"});
            this.ComboEspecialidades.Location = new System.Drawing.Point(121, 135);
            this.ComboEspecialidades.Name = "ComboEspecialidades";
            this.ComboEspecialidades.Size = new System.Drawing.Size(241, 28);
            this.ComboEspecialidades.TabIndex = 5;
            this.ComboEspecialidades.Visible = false;
            // 
            // txt_Salario
            // 
            this.txt_Salario.Location = new System.Drawing.Point(130, 207);
            this.txt_Salario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Salario.Name = "txt_Salario";
            this.txt_Salario.Size = new System.Drawing.Size(233, 26);
            this.txt_Salario.TabIndex = 20;
            this.txt_Salario.Visible = false;
            // 
            // Txt_Años
            // 
            this.Txt_Años.CausesValidation = false;
            this.Txt_Años.Location = new System.Drawing.Point(176, 173);
            this.Txt_Años.Name = "Txt_Años";
            this.Txt_Años.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Años.Size = new System.Drawing.Size(187, 26);
            this.Txt_Años.TabIndex = 5;
            this.Txt_Años.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(91, 171);
            this.txt_Direccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(272, 26);
            this.txt_Direccion.TabIndex = 11;
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.ForeColor = System.Drawing.Color.Blue;
            this.lblResultados.Location = new System.Drawing.Point(411, 9);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(354, 20);
            this.lblResultados.TabIndex = 4;
            this.lblResultados.Text = "<- Seleccione el grupo y la acción realizar";
            // 
            // Logoup
            // 
            this.Logoup.BackgroundImage = global::IPS_Mejora_tu_Salud.Properties.Resources.Logo;
            this.Logoup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logoup.InitialImage = null;
            this.Logoup.Location = new System.Drawing.Point(115, 41);
            this.Logoup.Name = "Logoup";
            this.Logoup.Size = new System.Drawing.Size(145, 119);
            this.Logoup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logoup.TabIndex = 3;
            this.Logoup.TabStop = false;
            this.Logoup.Visible = false;
            // 
            // Logodown
            // 
            this.Logodown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logodown.BackgroundImage")));
            this.Logodown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logodown.InitialImage = null;
            this.Logodown.Location = new System.Drawing.Point(49, 214);
            this.Logodown.Name = "Logodown";
            this.Logodown.Size = new System.Drawing.Size(285, 277);
            this.Logodown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logodown.TabIndex = 5;
            this.Logodown.TabStop = false;
            this.Logodown.Visible = false;
            // 
            // Grupo_Actualizar
            // 
            this.Grupo_Actualizar.Controls.Add(this.btn_Actualizar);
            this.Grupo_Actualizar.Controls.Add(this.txt_up_telefono);
            this.Grupo_Actualizar.Controls.Add(this.lbl_up_telefono);
            this.Grupo_Actualizar.Controls.Add(this.txt_up_direccion_salario);
            this.Grupo_Actualizar.Controls.Add(this.lbl_up_direccion_salario);
            this.Grupo_Actualizar.Controls.Add(this.txt_up_email_nombre);
            this.Grupo_Actualizar.Controls.Add(this.lbl_up_identificacion);
            this.Grupo_Actualizar.Controls.Add(this.lbl_up_email_nombre);
            this.Grupo_Actualizar.Controls.Add(this.txt_up_identificacion);
            this.Grupo_Actualizar.Controls.Add(this.btn_up_buscar);
            this.Grupo_Actualizar.Location = new System.Drawing.Point(12, 51);
            this.Grupo_Actualizar.Name = "Grupo_Actualizar";
            this.Grupo_Actualizar.Size = new System.Drawing.Size(369, 283);
            this.Grupo_Actualizar.TabIndex = 3;
            this.Grupo_Actualizar.TabStop = false;
            this.Grupo_Actualizar.Text = "Actualizar";
            this.Grupo_Actualizar.Visible = false;
            // 
            // txt_up_email_nombre
            // 
            this.txt_up_email_nombre.Location = new System.Drawing.Point(92, 113);
            this.txt_up_email_nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_up_email_nombre.Name = "txt_up_email_nombre";
            this.txt_up_email_nombre.Size = new System.Drawing.Size(271, 26);
            this.txt_up_email_nombre.TabIndex = 22;
            // 
            // lbl_up_identificacion
            // 
            this.lbl_up_identificacion.AutoSize = true;
            this.lbl_up_identificacion.Location = new System.Drawing.Point(7, 36);
            this.lbl_up_identificacion.Name = "lbl_up_identificacion";
            this.lbl_up_identificacion.Size = new System.Drawing.Size(107, 20);
            this.lbl_up_identificacion.TabIndex = 2;
            this.lbl_up_identificacion.Text = "Identificacion:";
            // 
            // lbl_up_email_nombre
            // 
            this.lbl_up_email_nombre.AutoSize = true;
            this.lbl_up_email_nombre.Location = new System.Drawing.Point(9, 119);
            this.lbl_up_email_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_up_email_nombre.Name = "lbl_up_email_nombre";
            this.lbl_up_email_nombre.Size = new System.Drawing.Size(52, 20);
            this.lbl_up_email_nombre.TabIndex = 21;
            this.lbl_up_email_nombre.Text = "Email:";
            // 
            // txt_up_identificacion
            // 
            this.txt_up_identificacion.Location = new System.Drawing.Point(121, 33);
            this.txt_up_identificacion.Name = "txt_up_identificacion";
            this.txt_up_identificacion.Size = new System.Drawing.Size(242, 26);
            this.txt_up_identificacion.TabIndex = 1;
            // 
            // btn_up_buscar
            // 
            this.btn_up_buscar.Location = new System.Drawing.Point(264, 65);
            this.btn_up_buscar.Name = "btn_up_buscar";
            this.btn_up_buscar.Size = new System.Drawing.Size(90, 35);
            this.btn_up_buscar.TabIndex = 0;
            this.btn_up_buscar.Text = "Buscar";
            this.btn_up_buscar.UseVisualStyleBackColor = true;
            this.btn_up_buscar.Click += new System.EventHandler(this.btn_up_buscar_Click);
            // 
            // lbl_up_direccion_salario
            // 
            this.lbl_up_direccion_salario.AutoSize = true;
            this.lbl_up_direccion_salario.Location = new System.Drawing.Point(9, 152);
            this.lbl_up_direccion_salario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_up_direccion_salario.Name = "lbl_up_direccion_salario";
            this.lbl_up_direccion_salario.Size = new System.Drawing.Size(79, 20);
            this.lbl_up_direccion_salario.TabIndex = 23;
            this.lbl_up_direccion_salario.Text = "Dirección:";
            // 
            // txt_up_direccion_salario
            // 
            this.txt_up_direccion_salario.Location = new System.Drawing.Point(92, 149);
            this.txt_up_direccion_salario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_up_direccion_salario.Name = "txt_up_direccion_salario";
            this.txt_up_direccion_salario.Size = new System.Drawing.Size(270, 26);
            this.txt_up_direccion_salario.TabIndex = 21;
            // 
            // lbl_up_telefono
            // 
            this.lbl_up_telefono.AutoSize = true;
            this.lbl_up_telefono.Location = new System.Drawing.Point(9, 191);
            this.lbl_up_telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_up_telefono.Name = "lbl_up_telefono";
            this.lbl_up_telefono.Size = new System.Drawing.Size(75, 20);
            this.lbl_up_telefono.TabIndex = 21;
            this.lbl_up_telefono.Text = "Telefono:";
            // 
            // txt_up_telefono
            // 
            this.txt_up_telefono.Location = new System.Drawing.Point(92, 185);
            this.txt_up_telefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_up_telefono.Name = "txt_up_telefono";
            this.txt_up_telefono.Size = new System.Drawing.Size(271, 26);
            this.txt_up_telefono.TabIndex = 22;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Actualizar.AutoSize = true;
            this.btn_Actualizar.Location = new System.Drawing.Point(139, 235);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(90, 35);
            this.btn_Actualizar.TabIndex = 24;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // LogoDown_Mini
            // 
            this.LogoDown_Mini.BackgroundImage = global::IPS_Mejora_tu_Salud.Properties.Resources.Logo;
            this.LogoDown_Mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoDown_Mini.InitialImage = null;
            this.LogoDown_Mini.Location = new System.Drawing.Point(78, 207);
            this.LogoDown_Mini.Name = "LogoDown_Mini";
            this.LogoDown_Mini.Size = new System.Drawing.Size(205, 181);
            this.LogoDown_Mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoDown_Mini.TabIndex = 6;
            this.LogoDown_Mini.TabStop = false;
            this.LogoDown_Mini.Visible = false;
            // 
            // Modulo_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 583);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Grupo_Registro);
            this.Controls.Add(this.Logodown);
            this.Controls.Add(this.Logoup);
            this.Controls.Add(this.Grupo_Buscar);
            this.Controls.Add(this.Grupo_Actualizar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Modulo_Principal";
            this.Text = "Modulo Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Grupo_Buscar.ResumeLayout(false);
            this.Grupo_Buscar.PerformLayout();
            this.Grupo_Registro.ResumeLayout(false);
            this.Grupo_Registro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Años)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logoup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logodown)).EndInit();
            this.Grupo_Actualizar.ResumeLayout(false);
            this.Grupo_Actualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoDown_Mini)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem nombreYSalarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Str_Registro_Cita;
        private System.Windows.Forms.ToolStripMenuItem citasImcumplidasToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Grupo_Buscar;
        private System.Windows.Forms.Label lbl_Documento;
        private System.Windows.Forms.TextBox txt_documento;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.ToolStripMenuItem Str_Buscar_Citas;
        private System.Windows.Forms.GroupBox Grupo_Registro;
        private System.Windows.Forms.Label lbl_Identificacion;
        private System.Windows.Forms.TextBox txt_Identificacion;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.TextBox txt_Nombres;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.Label lbl_FechaNa_Especialidad;
        private System.Windows.Forms.Label lbl_Direccion_AñosExp;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label lbl_Telefono_Salario;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_EmailPaciente;
        private System.Windows.Forms.Label lbl_FechaRegistroPaciente;
        private System.Windows.Forms.ToolStripMenuItem Str_Registro_Medicos;
        private System.Windows.Forms.Button Btn_Registro;
        private System.Windows.Forms.DateTimePicker DatoFechaRegistro;
        private System.Windows.Forms.DateTimePicker DatoFechaNacimiento;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.ComboBox ComboEspecialidades;
        private System.Windows.Forms.NumericUpDown Txt_Años;
        private System.Windows.Forms.TextBox txt_Salario;
        private System.Windows.Forms.PictureBox Logoup;
        private System.Windows.Forms.PictureBox Logodown;
        private System.Windows.Forms.GroupBox Grupo_Actualizar;
        private System.Windows.Forms.Label lbl_up_identificacion;
        private System.Windows.Forms.TextBox txt_up_identificacion;
        private System.Windows.Forms.Button btn_up_buscar;
        private System.Windows.Forms.TextBox txt_up_email_nombre;
        private System.Windows.Forms.Label lbl_up_email_nombre;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.TextBox txt_up_telefono;
        private System.Windows.Forms.Label lbl_up_telefono;
        private System.Windows.Forms.TextBox txt_up_direccion_salario;
        private System.Windows.Forms.Label lbl_up_direccion_salario;
        private System.Windows.Forms.PictureBox LogoDown_Mini;
    }
}