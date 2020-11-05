namespace IPS_Mejora_tu_Salud.Interfaces
{
    partial class Menu_Principal
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
            this.btn_IrPacientes = new System.Windows.Forms.Button();
            this.btn_IrCitas = new System.Windows.Forms.Button();
            this.btn_IrMedicos = new System.Windows.Forms.Button();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_IrPacientes
            // 
            this.btn_IrPacientes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_IrPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IrPacientes.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IrPacientes.Location = new System.Drawing.Point(57, 83);
            this.btn_IrPacientes.Name = "btn_IrPacientes";
            this.btn_IrPacientes.Size = new System.Drawing.Size(110, 30);
            this.btn_IrPacientes.TabIndex = 3;
            this.btn_IrPacientes.Text = "Pacientes";
            this.btn_IrPacientes.UseVisualStyleBackColor = false;
            // 
            // btn_IrCitas
            // 
            this.btn_IrCitas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_IrCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IrCitas.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IrCitas.Location = new System.Drawing.Point(57, 155);
            this.btn_IrCitas.Name = "btn_IrCitas";
            this.btn_IrCitas.Size = new System.Drawing.Size(110, 30);
            this.btn_IrCitas.TabIndex = 4;
            this.btn_IrCitas.Text = "Citas";
            this.btn_IrCitas.UseVisualStyleBackColor = false;
            // 
            // btn_IrMedicos
            // 
            this.btn_IrMedicos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_IrMedicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IrMedicos.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IrMedicos.Location = new System.Drawing.Point(57, 119);
            this.btn_IrMedicos.Name = "btn_IrMedicos";
            this.btn_IrMedicos.Size = new System.Drawing.Size(110, 30);
            this.btn_IrMedicos.TabIndex = 5;
            this.btn_IrMedicos.Text = "Medicos";
            this.btn_IrMedicos.UseVisualStyleBackColor = false;
            this.btn_IrMedicos.Click += new System.EventHandler(this.btn_IrMedicos_Click);
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraseña.ForeColor = System.Drawing.Color.Blue;
            this.lbl_contraseña.Location = new System.Drawing.Point(49, 40);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(118, 25);
            this.lbl_contraseña.TabIndex = 8;
            this.lbl_contraseña.Text = "Gestionar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::IPS_Mejora_tu_Salud.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(34, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(215, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(215, 306);
            this.Controls.Add(this.btn_IrCitas);
            this.Controls.Add(this.btn_IrMedicos);
            this.Controls.Add(this.btn_IrPacientes);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_Principal";
            this.Text = "Menú Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_IrPacientes;
        private System.Windows.Forms.Button btn_IrCitas;
        private System.Windows.Forms.Button btn_IrMedicos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}