using IPS_Mejora_tu_Salud.Modelo;
using IPS_Mejora_tu_Salud.Modelo.Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPS_Mejora_tu_Salud.Interfaces
{
    public partial class Modulo_Principal : Form
    {

        Validaciones validar = new Validaciones();
        IPS ips = new IPS();
        int verificacion;
 
       



        public Modulo_Principal()
        {
            InitializeComponent();

        }
        private void Str_CerrarSesion_Click_1(object sender, EventArgs e)
        {

            Form iniciosesion = new Inicio_Sesion();
            iniciosesion.Show();
            this.Hide();
        }


        //PACIENTE-----------------------------------------------------------------------------------------------------
        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ajuste interfaz
            {
                Grupo_Actualizar.Visible = false;
                Grupo_Buscar.Visible = false;
                Grupo_Citas.Visible = false;
                Btn_asistio.Visible = false;
                btn_noasistio.Visible = false;
            }

            DataSet BuscarTodosPacientes = new DataSet();
            BuscarTodosPacientes = ips.BuscarTodosPacientes();
            DataGriwView.DataSource = BuscarTodosPacientes.Tables["Pacientes registrados en la IPS"];
        }
        private void Str_Buscar_Paciente_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Buscar Paciente//
            {
                Grupo_Registro.Visible = false;
                Grupo_Citas.Visible = false;
                Grupo_Buscar.Text = "Buscar Paciente";
                Grupo_Buscar.Visible = true;
                Logodown.Visible = true;
                Logoup.Visible = false;
                Grupo_Actualizar.Visible = false;
                LogoDown_Mini.Visible = false;
                txt_documento.Clear();
            }
        }
        private void Str_Registro_Paciente_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Registro Paciente//
            {
                Grupo_Buscar.Visible = false;
                Grupo_Citas.Visible = false;
                Grupo_Registro.Text = "Registro Paciente";
                Grupo_Registro.Visible = true;
                lbl_FechaNa_Especialidad.Text = "Fecha de Nacimiento:";
                DatoFechaNacimiento.Visible = true;
                ComboEspecialidades.Visible = false;
                lbl_Direccion_AñosExp.Text = "Direccion:";
                Txt_Años.Visible = false;
                txt_Direccion.Visible = true;
                lbl_EmailPaciente.Visible = true;
                lbl_FechaRegistroPaciente.Visible = true;
                lbl_Telefono_Salario.Text = "Telefono:";
                txt_Salario.Visible = false;
                txt_Email.Visible = true;
                txt_Telefono.Visible = true;
                DatoFechaRegistro.Visible = true;
                Logodown.Visible = false;
                Logoup.Visible = true;
                Grupo_Actualizar.Visible = false;
                LogoDown_Mini.Visible = false;
                txt_Identificacion.Clear();
                txt_Nombres.Clear();
                txt_Apellidos.Clear();
                txt_Direccion.Clear();
                txt_Telefono.Clear();
                txt_Email.Clear();
                Btn_asistio.Visible = false;
                btn_noasistio.Visible = false;
            }

        }
        private void actualizarDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Actualizar Datos Paciente
            {
                Grupo_Buscar.Visible = false;
                Grupo_Citas.Visible = false;
                Grupo_Registro.Visible = false;
                Logodown.Visible = false;
                Logoup.Visible = false;
                Grupo_Actualizar.Visible = true;
                LogoDown_Mini.Visible = true;
                Grupo_Actualizar.Text = "Actualizar Paciente";
                lbl_up_email_nombre.Text = "Email:";
                lbl_up_direccion_salario.Text = "Dirección:";
                lbl_up_telefono.Visible = true;
                txt_up_telefono.Visible = true;
                txt_up_salario_medico.Visible = false;
                txt_up_nombreMedico.Visible = false;
                txt_up_direccion.Visible = true;
                txt_up_email.Visible = true;
                txt_up_identificacion.Clear();
                txt_up_email.Clear();
                txt_up_direccion.Clear();
                txt_up_telefono.Clear();
                Btn_asistio.Visible = false;
                btn_noasistio.Visible = false;
            }
        }
        private void verMultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Multas Paciente//
            {
                Grupo_Registro.Visible = false;
                Grupo_Citas.Visible = false;
                Grupo_Buscar.Text = "Multas Paciente";
                Grupo_Buscar.Visible = true;
                Logodown.Visible = true;
                Logoup.Visible = false;
                Grupo_Actualizar.Visible = false;
                LogoDown_Mini.Visible = false;
                txt_documento.Clear();
                Btn_asistio.Visible = false;
                btn_noasistio.Visible = false;
                DataSet DatasetMultas = new DataSet();
                DatasetMultas = ips.VerMultas();
                DataGriwView.DataSource = DatasetMultas.Tables["Todas Las multas"];
            }
        }
        private void verCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Ver_Citas Paciente//
            {
                Grupo_Registro.Visible = false;
                Grupo_Citas.Visible = false;
                Grupo_Buscar.Text = "Citas Paciente";
                Grupo_Buscar.Visible = true;
                Logodown.Visible = true;
                Logoup.Visible = false;
                Grupo_Actualizar.Visible = false;
                LogoDown_Mini.Visible = false;
                txt_documento.Clear();
                Btn_asistio.Visible = true;
                btn_noasistio.Visible = true;
                DataSet BuscarTodosCitas = new DataSet();
                BuscarTodosCitas = ips.VerTodasCitas();
                DataGriwView.DataSource = BuscarTodosCitas.Tables["Citas"];
            }
        }

        //MEDICO-----------------------------------------------------------------------------------------------------
        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ajuste interfaz
            {
                Grupo_Actualizar.Visible = false;
                Grupo_Buscar.Visible = false;
                Grupo_Citas.Visible = false;
                Btn_asistio.Visible = false;
                btn_noasistio.Visible = false;
            }

            DataSet BuscarTodosMedicos = new DataSet();
            BuscarTodosMedicos = ips.BuscarTodosMedicos();
            DataGriwView.DataSource = BuscarTodosMedicos.Tables["Medicos registrados en la IPS"];
        }
        private void Str_Buscar_Medico_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Buscar Medico//
            {
                Grupo_Registro.Visible = false;
                Grupo_Citas.Visible = false;
                Grupo_Buscar.Text = "Buscar Medico";
                Grupo_Buscar.Visible = true;
                Logodown.Visible = true;
                Logoup.Visible = false;
                Grupo_Actualizar.Visible = false;
                LogoDown_Mini.Visible = false;
                txt_documento.Clear();
                Btn_asistio.Visible = false;
                btn_noasistio.Visible = false;
            }
        }
        private void Str_Registro_Medicos_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Registro Medicos//
            {
                Grupo_Buscar.Visible = false;
                Grupo_Citas.Visible = false;
                Grupo_Registro.Text = "Registro Medico";
                Grupo_Registro.Visible = true;
                lbl_FechaNa_Especialidad.Text = "Especialidad";
                DatoFechaNacimiento.Visible = false;
                ComboEspecialidades.Visible = true;
                lbl_Direccion_AñosExp.Text = "Años De Experiencia:";
                Txt_Años.Visible = true;
                txt_Direccion.Visible = false;
                lbl_EmailPaciente.Visible = false;
                lbl_FechaRegistroPaciente.Visible = false;
                lbl_Telefono_Salario.Text = "Salario por Cita:";
                txt_Salario.Visible = true;
                txt_Email.Visible = false;
                txt_Telefono.Visible = false;
                DatoFechaRegistro.Visible = false;
                Logodown.Visible = false;
                Logoup.Visible = true;
                Grupo_Actualizar.Visible = false;
                LogoDown_Mini.Visible = false;
                txt_Identificacion.Clear();
                txt_Nombres.Clear();
                txt_Apellidos.Clear();
                ComboEspecialidades.Text = "";
                txt_Salario.Clear();
                Txt_Años.Value = 0;
                Btn_asistio.Visible = false;
                btn_noasistio.Visible = false;
            }
        }
        private void actualizarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Actualizar Datos Medico//
            {
                Grupo_Buscar.Visible = false;
                Grupo_Registro.Visible = false;
                Grupo_Citas.Visible = false;
                Logodown.Visible = false;
                Logoup.Visible = false;
                Grupo_Actualizar.Visible = true;
                LogoDown_Mini.Visible = true;
                Grupo_Actualizar.Text = "Actualizar Medico";
                lbl_up_email_nombre.Text = "Nombre:";
                lbl_up_direccion_salario.Text = "Salario:";
                lbl_up_telefono.Visible = false;
                txt_up_telefono.Visible = false;
                txt_up_salario_medico.Visible = true;
                txt_up_nombreMedico.Visible = true;
                txt_up_direccion.Visible = false;
                txt_up_email.Visible = false;
                txt_up_identificacion.Clear();
                txt_up_salario_medico.Clear();
                txt_up_nombreMedico.Clear();
                Btn_asistio.Visible = false;
                btn_noasistio.Visible = false;
            }
        }
        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Buscar Medico//
            {
                Grupo_Registro.Visible = false;
                Grupo_Citas.Visible = false;
                Grupo_Buscar.Text = "Buscar Pago Medico";
                Grupo_Buscar.Visible = true;
                Logodown.Visible = true;
                Logoup.Visible = false;
                Grupo_Actualizar.Visible = false;
                LogoDown_Mini.Visible = false;
                txt_documento.Clear();
                Btn_asistio.Visible = false;
                btn_noasistio.Visible = false;
            }
        }
        private void verCitasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Ver_Citas Paciente//
            {
                Grupo_Registro.Visible = false;
                Grupo_Citas.Visible = false;
                Grupo_Buscar.Text = "Citas Medico";
                Grupo_Buscar.Visible = true;
                Logodown.Visible = true;
                Logoup.Visible = false;
                Grupo_Actualizar.Visible = false;
                LogoDown_Mini.Visible = false;
                txt_documento.Clear();
                Btn_asistio.Visible = true;
                btn_noasistio.Visible = true;
                DataSet BuscarTodosCitas = new DataSet();
                BuscarTodosCitas = ips.VerTodasCitas();
                DataGriwView.DataSource = BuscarTodosCitas.Tables["Citas"];
            }
        }

        //CITAS-----------------------------------------------------------------------------------------------------
        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet BuscarTodosCitas = new DataSet();
            BuscarTodosCitas = ips.VerTodasCitas();
            DataGriwView.DataSource = BuscarTodosCitas.Tables["Citas"];

            //Ajuste interfaz
            {
                Grupo_Actualizar.Visible = false;
                Grupo_Buscar.Visible = false;
                Grupo_Citas.Visible = false;
                Btn_asistio.Visible = false;
                btn_noasistio.Visible = false;
            }
        }
        private void citapacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Ver_Citas Paciente//
            {
                Grupo_Registro.Visible = false;
                Grupo_Citas.Visible = false;
                Grupo_Buscar.Text = "Citas Paciente";
                Grupo_Buscar.Visible = true;
                Logodown.Visible = true;
                Logoup.Visible = false;
                Grupo_Actualizar.Visible = false;
                LogoDown_Mini.Visible = false;
                txt_documento.Clear();
                Btn_asistio.Visible = true;
                btn_noasistio.Visible = true;
                DataSet BuscarTodosCitas = new DataSet();
                BuscarTodosCitas = ips.VerTodasCitas();
                DataGriwView.DataSource = BuscarTodosCitas.Tables["Citas"];
            }
        }
        private void citamedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Ver_Citas Paciente//
            {
                Grupo_Registro.Visible = false;
                Grupo_Citas.Visible = false;
                Grupo_Buscar.Text = "Citas Medico";
                Grupo_Buscar.Visible = true;
                Logodown.Visible = true;
                Logoup.Visible = false;
                Grupo_Actualizar.Visible = false;
                LogoDown_Mini.Visible = false;
                txt_documento.Clear();
                Btn_asistio.Visible = true;
                btn_noasistio.Visible = true;
                DataSet BuscarTodosCitas = new DataSet();
                BuscarTodosCitas = ips.VerTodasCitas();
                DataGriwView.DataSource = BuscarTodosCitas.Tables["Citas"];
            }
        }
        private void Str_Registro_Cita_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Registro Cita//
            {
                Grupo_Citas.Text = "Registro Cita";
                Grupo_Citas.Visible = true;
                Grupo_Buscar.Visible = false;
                Grupo_Actualizar.Visible = false;
                Grupo_Registro.Visible = false;
                Logodown.Visible = false;
                Logoup.Visible = false;
                LogoDown_Mini.Visible = true;
                lbl_identificacionMedico_Cita.Visible = false;
                txt_identificacion_medico_cita.Visible = false;
                lbl_FechaCita.Visible = false;
                lbl_HoraCita.Visible = false;
                Datatime_cita.Visible = false;
                Datatime2_cita.Visible = false;
                Btn_RegistarCita.Visible = false;
                lbl_Tipo_Cita.Visible = false;
                comboBoxCitas.Visible = false;
                txt_identificacionPacienteCita.Clear();
                comboBoxCitas.Text = "";
                txt_identificacion_medico_cita.Clear();
                Btn_asistio.Visible = false;
                btn_noasistio.Visible = false;
            }
        }


        //BOTONES-----------------------------------------------------------------------------------------------------
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (Grupo_Buscar.Text.Equals("Buscar Paciente"))
            {
                string identificacion = txt_documento.Text;
                DataSet DatasetPaciente = new DataSet();
                DatasetPaciente = ips.BuscarPaciente(identificacion);
                DataGriwView.DataSource = DatasetPaciente.Tables["Paciente encontrado"];

            }

            if (Grupo_Buscar.Text.Equals("Multas Paciente"))
            {
                string identificacion = txt_documento.Text;
                DataSet DatasetMultas = new DataSet();
                DatasetMultas = ips.VerMultasPorIdentificacion(identificacion);
                DataGriwView.DataSource = DatasetMultas.Tables["Paciente"];
                if (DataGriwView.Rows.Count == 0)
                {
                    MessageBox.Show("PACIENTE SIN MULTAS");
                }
                
            }

            if (Grupo_Buscar.Text.Equals("Citas Paciente"))
            {
                string identificacion = txt_documento.Text;
                DataSet actualizar = new DataSet();
                actualizar = ips.VerCitasPaciente(identificacion);
                DataGriwView.DataSource = actualizar.Tables["Citas del paciente"];
            }

            if (Grupo_Buscar.Text == "Buscar Medico")
            {
                string identificacion = txt_documento.Text;
                DataSet DatasetMedico = new DataSet();
                DatasetMedico = ips.BuscarMedico(identificacion);
                DataGriwView.DataSource = DatasetMedico.Tables["Medico encontrado"];
            }

            if (Grupo_Buscar.Text == "Buscar Pago Medico")
            {
                string identificacionMedico = txt_documento.Text;
                DataSet DatasetPagoMedico = new DataSet();
                DatasetPagoMedico = ips.VerValorPagar(identificacionMedico);
                DataGriwView.DataSource = DatasetPagoMedico.Tables["Salario por cita del medico"];

                ////texto


            }

            if (Grupo_Buscar.Text.Equals("Citas Medico"))
            {
                string identificacionMedico = txt_documento.Text;
                DataSet actualizar = new DataSet();
                actualizar = ips.VerCitasMedico(identificacionMedico);
                DataGriwView.DataSource = actualizar.Tables["Citas del Medico"];
            }

            txt_documento.Clear();
        }
        private void Btn_Registro_click(object sender, EventArgs e)
        {
            if (Grupo_Registro.Text.Equals("Registro Paciente"))
            {
                string identificacionPaciente = txt_Identificacion.Text;
                string nombres = txt_Nombres.Text;
                string apellidos = txt_Apellidos.Text;
                string fechaNacimiento = DatoFechaNacimiento.Text;
                string direccion = txt_Direccion.Text;
                string telefono = txt_Telefono.Text;
                string email = txt_Email.Text;
                string fechaRegistro = DatoFechaRegistro.Text;

                Paciente paciente = new Paciente(identificacionPaciente, nombres, apellidos, fechaNacimiento, direccion, telefono, email, fechaRegistro);
                verificacion = ips.RegistrarPaciente(paciente);

                if (verificacion == 1)
                {
                    MessageBox.Show("Paciente Registrado Correctamente");
                    txt_Identificacion.Clear();
                    txt_Nombres.Clear();
                    txt_Apellidos.Clear();
                    txt_Direccion.Clear();
                    txt_Telefono.Clear();
                    txt_Email.Clear();
                }
                else
                {

                }



            }
            if (Grupo_Registro.Text.Equals("Registro Medico"))
            {
                try
                {
                    string identificacionMedico = txt_Identificacion.Text;
                    string nombres = txt_Nombres.Text;
                    string apellidos = txt_Apellidos.Text;
                    string especialidad = ComboEspecialidades.Text;
                    int salario_cita = Int32.Parse(txt_Salario.Text);
                    int años_experiencia = Int32.Parse(Txt_Años.Text);

                    Medico medico = new Medico(identificacionMedico, nombres, apellidos, especialidad, salario_cita, años_experiencia);
                    ips.RegistrarMedico(medico);
                    MessageBox.Show("Medico Registrado Correctamente");

                    txt_Identificacion.Clear();
                    txt_Nombres.Clear();
                    txt_Apellidos.Clear();
                    ComboEspecialidades.Text = "";
                    txt_Salario.Clear();
                    Txt_Años.Value = 0;
                }

                catch
                {

                }
            }
            if (Grupo_Registro.Text.Equals("Registro Cita"))
            {

            }
        }
        private void btn_up_buscar_Click(object sender, EventArgs e)
        {

            if (Grupo_Actualizar.Text.Equals("Actualizar Paciente"))
            {
                string identificacion = txt_up_identificacion.Text;
                DataSet DatasetActualizar = new DataSet();
                DatasetActualizar = ips.BuscarPaciente(identificacion);
                DataGriwView.DataSource = DatasetActualizar.Tables["Paciente encontrado"];
            }
            if (Grupo_Actualizar.Text.Equals("Actualizar Medico"))
            {
                string identificacionMedico = txt_up_identificacion.Text;
                DataSet DataActualizarMedico = new DataSet();
                DataActualizarMedico = ips.BuscarMedico(identificacionMedico);
                DataGriwView.DataSource = DataActualizarMedico.Tables["Medico encontrado"];
            }

        }
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {

            if (Grupo_Actualizar.Text.Equals("Actualizar Paciente"))
            {
                string identificacion = txt_up_identificacion.Text;
                string email = txt_up_email.Text;
                string direccion = txt_up_direccion.Text;
                string telefono = txt_up_telefono.Text;
                int verificacion = ips.ActualizarPaciente(email, direccion, telefono, identificacion);

                if (verificacion == 1)
                {
                    MessageBox.Show("Paciente Actualizado Correctamente");
                    DataSet Actualizar = new DataSet();
                    Actualizar = ips.BuscarPaciente(identificacion);
                    DataGriwView.DataSource = Actualizar.Tables["Paciente encontrado"];
                    txt_up_identificacion.Clear();
                    txt_up_email.Clear();
                    txt_up_direccion.Clear();
                    txt_up_telefono.Clear();
                }
                else
                {

                }
            }
            if (Grupo_Actualizar.Text.Equals("Actualizar Medico"))
            {
                string identificacionMedico = txt_up_identificacion.Text;
                int salarioMedico = Int32.Parse(txt_up_salario_medico.Text);
                string nombreMedico = txt_up_nombreMedico.Text;
                int verificacion = ips.ActualizarMedico(nombreMedico, salarioMedico, identificacionMedico);

                if (verificacion == 1)
                {
                    MessageBox.Show("Médico Actualizado Correctamente");
                    DataSet DatasetMedico = new DataSet();
                    DatasetMedico = ips.BuscarMedico(identificacionMedico);
                    DataGriwView.DataSource = DatasetMedico.Tables["Medico encontrado"];
                    txt_up_identificacion.Clear();
                    txt_up_salario_medico.Clear();
                    txt_up_nombreMedico.Clear();
                }
                else
                {

                }
            }

        }
        private void Btn_RegistarCita_Click(object sender, EventArgs e)
        {

            string IdentificacionPaciente = txt_identificacionPacienteCita.Text;
            string Especialidad = comboBoxCitas.Text;
            string IdentificacionMedico = txt_identificacion_medico_cita.Text;
            string FechaCita = Datatime_cita.Text;
            string HoraCita = Datatime2_cita.Text;
            Cita cita = new Cita(IdentificacionMedico, IdentificacionPaciente, FechaCita);
            int verificacion = ips.RegistarCita(cita);

            if (verificacion == 1)
            {
                MessageBox.Show("Cita Registrada Correctamente");
                DataSet Actualizarcitas = new DataSet();
                //Actualizarcitas = ips.BuscarCitas(IdentificacionPaciente);
                DataGriwView.DataSource = Actualizarcitas.Tables["Paciente encontrado"];
                txt_identificacionPacienteCita.Clear();
                comboBoxCitas.Text = "";
                txt_identificacion_medico_cita.Clear();
            }

        }

        //Validaciones-----------------------------------------------------------------------------------------------------
        private void txt_documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.OnlyNumbers(e);
        }
        private void txt_Identificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.OnlyNumbers(e);
        }
        private void txt_Nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.OnlyLetters(e);
        }
        private void txt_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.OnlyLetters(e);
        }
        private void DatoFechaNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.OnlyNumbers(e);
        }
        private void ComboEspecialidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.OnlyLetters(e);
        }
        private void txt_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.OnlyLetters(e);
        }
        private void Txt_Años_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.OnlyNumbers(e);
        }
        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.OnlyNumbers(e);
        }
        private void txt_up_identificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.OnlyNumbers(e);
        }
        private void txt_up_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.OnlyNumbers(e);
        }
        private void txt_up_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.OnlyLetters(e);
        }
        private void txt_up_salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.OnlyNumbers(e);
        }
        private void txt_documento_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validar.OnlyNumbers(e);
        }
        private void txt_Salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.OnlyNumbers(e);
        }
        private void txt_identificacionPacienteCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.OnlyNumbers(e);
        }
        private void ComboBoxCitas_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.OnlyLetters(e);
        }
        private void txt_identificacion_medico_cita_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.OnlyNumbers(e);
        }

        private void Btn_BuscarRegistroCita_Click(object sender, EventArgs e)
        {
            string IdentificacionPaciente = txt_identificacionPacienteCita.Text;
            DataSet pazysalvo = new DataSet();
            pazysalvo = ips.VerMultasPorIdentificacion(IdentificacionPaciente);
            DataGriwView.DataSource = pazysalvo.Tables["MultaID"];
            if (DataGriwView.Rows.Count == 0)
            {
                 //DataGriwView.Rows.
                //if ()
                {
                    lbl_Tipo_Cita.Visible = true;
                    this.ComboEspecialidades.Items.AddRange(new object[] {"Medico General","Optometria","Pediatria"});
                    comboBoxCitas.Visible = true;
                }
                lbl_identificacionMedico_Cita.Visible = true;
                txt_identificacion_medico_cita.Visible = true;
                lbl_FechaCita.Visible = true;
                lbl_HoraCita.Visible = true;
                Datatime_cita.Visible = true;
                Datatime2_cita.Visible = true;
                Btn_RegistarCita.Visible = true;
                
            }
        }
   
       
    }
 
       
}