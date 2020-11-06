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
            Form Modulo = new Modulo_Principal();
            Modulo.Show();
            this.Hide();
            


        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
