using IPS_Mejora_tu_Salud.Modelo;
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


        //PACIENTE
        private void Str_Buscar_Paciente_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Buscar Paciente//
            {
                Grupo_Registro.Visible = false;
                Grupo_Buscar.Text = "Buscar Paciente";
                Grupo_Buscar.Visible = true;
                Logodown.Visible = true;
                Logoup.Visible = false;
                Grupo_Actualizar.Visible = false;
                LogoDown_Mini.Visible = false;
            }
        }
        private void Str_Registro_Paciente_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Registro Paciente//
            {
                Grupo_Buscar.Visible = false;
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
            }

        }
        private void actualizarDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Actualizar Datos Paciente
            {
                Grupo_Buscar.Visible = false;
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
            }
        }



        //MEDICO
        private void Str_Buscar_Medico_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Buscar Medico//
            {
                Grupo_Registro.Visible = false;
                Grupo_Buscar.Text = "Buscar Medico";
                Grupo_Buscar.Visible = true;
                Logodown.Visible = true;
                Logoup.Visible = false;
                Grupo_Actualizar.Visible = false;
                LogoDown_Mini.Visible = false;
            }
        }
        private void Str_Registro_Medicos_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Registro Medicos//
            {
                Grupo_Buscar.Visible = false;
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
            }
        }
        private void actualizarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Actualizar Datos Medico//
            {
                Grupo_Buscar.Visible = false;
                Grupo_Registro.Visible = false;
                Logodown.Visible = false;
                Logoup.Visible = false;
                Grupo_Actualizar.Visible = true;
                LogoDown_Mini.Visible = true;
                Grupo_Actualizar.Text = "Actualizar Medico";
                lbl_up_email_nombre.Text = "Nombre:";
                lbl_up_direccion_salario.Text = "Salario:";
                lbl_up_telefono.Visible = false;
                txt_up_telefono.Visible = false;
            }
        }



        //CITAS
        private void Str_Buscar_Citas_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Buscar Citas//
            {
                Grupo_Registro.Visible = false;
                Grupo_Buscar.Text = "Buscar Cita";
                Grupo_Buscar.Visible = true;
                Logodown.Visible = true;
                Logoup.Visible = false;
                Grupo_Actualizar.Visible = false;
                LogoDown_Mini.Visible = false;
            }
        }
        private void Str_Registro_Cita_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Registro Cita//
            {
                Grupo_Buscar.Visible = false;
                Grupo_Registro.Text = "Registro Cita";
                Grupo_Registro.Visible = true;
                Logodown.Visible = false;
                Logoup.Visible = true;
                Grupo_Actualizar.Visible = false;
                LogoDown_Mini.Visible = false;
            }
        }


        //BOTONES
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (Grupo_Buscar.Text.Equals("Buscar Paciente"))
            {

            }
            if (Grupo_Buscar.Text == "Buscar Medico")
            {

            }
            if (Grupo_Buscar.Text == "Buscar Cita")
            {

            }

            txt_documento.Text = "";

        }

        private void Btn_Registro_click(object sender, EventArgs e)
        {
            if (Grupo_Registro.Text.Equals("Registro Paciente"))
            {
                try
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
                    IPS ips = new IPS();
                    ips.RegistrarPaciente(paciente);

                    MessageBox.Show("Paciente Registrado Correctamente");

                    txt_Identificacion.Clear();
                    txt_Nombres.Clear();
                    txt_Apellidos.Clear();
                    DatoFechaNacimiento.Format = (01 / 01 / 1000);
                    txt_Direccion.Clear();
                    txt_Telefono.Clear();

                }
                catch
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
                    IPS ips = new IPS();
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

        //BOTONES ACTUALIZAR
        private void btn_up_buscar_Click(object sender, EventArgs e)
        {

        }
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (Grupo_Actualizar.Text.Equals("Actualizar Paciente"))
            {
                try
                {


                }
                catch
                {

                }

            }
            if (Grupo_Actualizar.Text.Equals("Actualizar Medico"))
            {
                try
                {


                }
                catch
                {

                }

            }
            
        }


    }
}