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
        private void Str_Buscar_Paciente_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Buscar Paciente//
            {
                Grupo_Registro.Visible = false;
                Grupo_Buscar.Text = "Buscar Paciente";
                Grupo_Buscar.Visible = true;
                Logodown.Visible = true;
                Logoup.Visible = false;
            }
        }
        private void Str_Buscar_Medico_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Buscar Medico//
            {
                Grupo_Registro.Visible = false;
                Grupo_Buscar.Text = "Buscar Medico";
                Grupo_Buscar.Visible = true;
                Logodown.Visible = true;
                Logoup.Visible = false;
            }
        }
        private void Str_Buscar_Citas_Click(object sender, EventArgs e)
        {
            //Ajuste Interfaz Buscar Citas//
            {
                Grupo_Registro.Visible = false;
                Grupo_Buscar.Text = "Buscar Cita";
                Grupo_Buscar.Visible = true;
                Logodown.Visible = true;
                Logoup.Visible = false;
            }
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (Grupo_Buscar.Text == "Buscar Paciente")
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
                txt_Telefono.Visible= false;
                DatoFechaRegistro.Visible= false;
                Logodown.Visible = false;
                Logoup.Visible = true;
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
            }
        }
        private void btn_RegistroPaciente_click(object sender, EventArgs e)
        {
            if (Grupo_Registro.Text == "Registro Paciente")
            {

            }
            if (Grupo_Registro.Text == "Registro Medico")
            {

            }
            if (Grupo_Registro.Text == "Registro Cita")
            {

            }
        }


    }
}
