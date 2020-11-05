namespace IPS_Mejora_tu_Salud.Interfaces
{
    partial class MenuPacientes
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
            this.btn_IrBuscarPaciente = new System.Windows.Forms.Button();
            this.btn_IrRegistrarPaciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_IrBuscarPaciente
            // 
            this.btn_IrBuscarPaciente.Location = new System.Drawing.Point(107, 117);
            this.btn_IrBuscarPaciente.Name = "btn_IrBuscarPaciente";
            this.btn_IrBuscarPaciente.Size = new System.Drawing.Size(174, 39);
            this.btn_IrBuscarPaciente.TabIndex = 0;
            this.btn_IrBuscarPaciente.Text = "Bucar paciente";
            this.btn_IrBuscarPaciente.UseVisualStyleBackColor = true;
            this.btn_IrBuscarPaciente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_IrRegistrarPaciente
            // 
            this.btn_IrRegistrarPaciente.Location = new System.Drawing.Point(107, 195);
            this.btn_IrRegistrarPaciente.Name = "btn_IrRegistrarPaciente";
            this.btn_IrRegistrarPaciente.Size = new System.Drawing.Size(174, 39);
            this.btn_IrRegistrarPaciente.TabIndex = 1;
            this.btn_IrRegistrarPaciente.Text = "Registrar paciente";
            this.btn_IrRegistrarPaciente.UseVisualStyleBackColor = true;
            // 
            // MenuPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 363);
            this.Controls.Add(this.btn_IrRegistrarPaciente);
            this.Controls.Add(this.btn_IrBuscarPaciente);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPacientes";
            this.Text = "MenuPacientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_IrBuscarPaciente;
        private System.Windows.Forms.Button btn_IrRegistrarPaciente;
    }
}