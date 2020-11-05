namespace IPS_Mejora_tu_Salud.Interfaces
{
    partial class BuscarPaciente
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
            this.txt_CedulaPaciente = new System.Windows.Forms.TextBox();
            this.lbl_CedulaPaciente = new System.Windows.Forms.Label();
            this.btn_BuscarPaciente = new System.Windows.Forms.Button();
            this.lbl_ResultadoBusqueda = new System.Windows.Forms.Label();
            this.btn_IrCrearCita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_CedulaPaciente
            // 
            this.txt_CedulaPaciente.Location = new System.Drawing.Point(92, 72);
            this.txt_CedulaPaciente.Name = "txt_CedulaPaciente";
            this.txt_CedulaPaciente.Size = new System.Drawing.Size(147, 20);
            this.txt_CedulaPaciente.TabIndex = 0;
            // 
            // lbl_CedulaPaciente
            // 
            this.lbl_CedulaPaciente.AutoSize = true;
            this.lbl_CedulaPaciente.Location = new System.Drawing.Point(118, 56);
            this.lbl_CedulaPaciente.Name = "lbl_CedulaPaciente";
            this.lbl_CedulaPaciente.Size = new System.Drawing.Size(101, 13);
            this.lbl_CedulaPaciente.TabIndex = 1;
            this.lbl_CedulaPaciente.Text = "Cédula del paciente";
            // 
            // btn_BuscarPaciente
            // 
            this.btn_BuscarPaciente.Location = new System.Drawing.Point(130, 110);
            this.btn_BuscarPaciente.Name = "btn_BuscarPaciente";
            this.btn_BuscarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarPaciente.TabIndex = 2;
            this.btn_BuscarPaciente.Text = "Buscar";
            this.btn_BuscarPaciente.UseVisualStyleBackColor = true;
            // 
            // lbl_ResultadoBusqueda
            // 
            this.lbl_ResultadoBusqueda.AutoSize = true;
            this.lbl_ResultadoBusqueda.Location = new System.Drawing.Point(12, 176);
            this.lbl_ResultadoBusqueda.Name = "lbl_ResultadoBusqueda";
            this.lbl_ResultadoBusqueda.Size = new System.Drawing.Size(35, 13);
            this.lbl_ResultadoBusqueda.TabIndex = 3;
            this.lbl_ResultadoBusqueda.Text = "label1";
            // 
            // btn_IrCrearCita
            // 
            this.btn_IrCrearCita.Enabled = false;
            this.btn_IrCrearCita.Location = new System.Drawing.Point(15, 241);
            this.btn_IrCrearCita.Name = "btn_IrCrearCita";
            this.btn_IrCrearCita.Size = new System.Drawing.Size(75, 23);
            this.btn_IrCrearCita.TabIndex = 4;
            this.btn_IrCrearCita.Text = "Asignar Cita";
            this.btn_IrCrearCita.UseVisualStyleBackColor = true;
            // 
            // BuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 293);
            this.Controls.Add(this.btn_IrCrearCita);
            this.Controls.Add(this.lbl_ResultadoBusqueda);
            this.Controls.Add(this.btn_BuscarPaciente);
            this.Controls.Add(this.lbl_CedulaPaciente);
            this.Controls.Add(this.txt_CedulaPaciente);
            this.Name = "BuscarPaciente";
            this.Text = "BuscarPaciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CedulaPaciente;
        private System.Windows.Forms.Label lbl_CedulaPaciente;
        private System.Windows.Forms.Button btn_BuscarPaciente;
        private System.Windows.Forms.Label lbl_ResultadoBusqueda;
        private System.Windows.Forms.Button btn_IrCrearCita;
    }
}