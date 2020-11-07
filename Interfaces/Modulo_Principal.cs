using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
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

            Grupo_Registro.Visible = false;
            Grupo_Buscar.Text = "Buscar Paciente";
            Grupo_Buscar.Visible = true;
        }
        private void Str_Buscar_Medico_Click(object sender, EventArgs e)
        {
            Grupo_Registro.Visible = false;
            Grupo_Buscar.Text = "Buscar Medico";
            Grupo_Buscar.Visible = true;
        }
        private void Str_Buscar_Citas_Click(object sender, EventArgs e)
        {
            Grupo_Registro.Visible = false; 
            Grupo_Buscar.Text = "Buscar Cita";
            Grupo_Buscar.Visible = true;
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
            Grupo_Buscar.Visible = false; 
            Grupo_Registro.Text = "Registro Paciente";
            Grupo_Registro.Visible = true;
        }
        private void Str_Registro_Medicos_Click(object sender, EventArgs e)
        {
            Grupo_Buscar.Visible = false;
            Grupo_Registro.Text = "Registro Medico";
            Grupo_Registro.Visible = true;
        }
        private void Str_Registro_Cita_Click(object sender, EventArgs e)
        {
            Grupo_Buscar.Visible = false;
            Grupo_Registro.Text = "Registro Cita";
            Grupo_Registro.Visible = true;
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
