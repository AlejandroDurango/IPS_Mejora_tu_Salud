using IPS_Mejora_tu_Salud.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPS_Mejora_tu_Salud.Interfaces
{
    public partial class Inicio_Sesion : Form
    {
        public Inicio_Sesion()
        {
            InitializeComponent();
        }

        private void btn_IrIniciarSesion_Click(object sender, EventArgs e)
        {

            if (txt_usuario.Text == "")
            {
                MessageBox.Show("Ingrese un usuario");
                txt_contraseña.Clear();
            }
            else if (txt_contraseña.Text == "")
                {
                    MessageBox.Show("Ingrese una Contraseña");
                    txt_usuario.Clear();
                }
                 else
                  {
                    string contraseña = txt_contraseña.Text;
                    string usuario = txt_usuario.Text;

                    IPS ips = new IPS();

                    if (ips.IniciarSesion(usuario, contraseña))

                    {
                        Form Modulo = new Modulo_Principal();
                        Modulo.Show();
                        this.Hide();
                        txt_contraseña.Clear();
                        txt_usuario.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Datos Incorrectos");
                    }
                  }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
