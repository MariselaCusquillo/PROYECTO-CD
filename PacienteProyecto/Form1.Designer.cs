﻿namespace PacienteProyecto
{
    partial class frmRegistro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblNumHistoria = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.mtxtNombres = new System.Windows.Forms.MaskedTextBox();
            this.mtxtApellidos = new System.Windows.Forms.MaskedTextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.mtxtEdad = new System.Windows.Forms.MaskedTextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.mtxtNumHistoria = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSala = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(334, 24);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(114, 13);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Registro de Pacientes ";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(221, 57);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(52, 13);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(221, 87);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(221, 113);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(43, 13);
            this.lblCedula.TabIndex = 3;
            this.lblCedula.Text = "Cédula:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(221, 138);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad:";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(178, 247);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(86, 13);
            this.lblSala.TabIndex = 8;
            this.lblSala.Text = "Número de Sala:";
            // 
            // lblNumHistoria
            // 
            this.lblNumHistoria.AutoSize = true;
            this.lblNumHistoria.Location = new System.Drawing.Point(130, 224);
            this.lblNumHistoria.Name = "lblNumHistoria";
            this.lblNumHistoria.Size = new System.Drawing.Size(136, 13);
            this.lblNumHistoria.TabIndex = 7;
            this.lblNumHistoria.Text = "Número de Historia Clínica:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(155, 194);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNacimiento.TabIndex = 6;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(221, 166);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 5;
            this.lblGenero.Text = "Género:";
            // 
            // mtxtNombres
            // 
            this.mtxtNombres.Location = new System.Drawing.Point(279, 57);
            this.mtxtNombres.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mtxtNombres.Name = "mtxtNombres";
            this.mtxtNombres.Size = new System.Drawing.Size(153, 20);
            this.mtxtNombres.TabIndex = 9;
            // 
            // mtxtApellidos
            // 
            this.mtxtApellidos.Location = new System.Drawing.Point(279, 84);
            this.mtxtApellidos.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mtxtApellidos.Name = "mtxtApellidos";
            this.mtxtApellidos.Size = new System.Drawing.Size(153, 20);
            this.mtxtApellidos.TabIndex = 10;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(279, 110);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 11;
            // 
            // mtxtEdad
            // 
            this.mtxtEdad.Location = new System.Drawing.Point(279, 138);
            this.mtxtEdad.Mask = "99";
            this.mtxtEdad.Name = "mtxtEdad";
            this.mtxtEdad.Size = new System.Drawing.Size(100, 20);
            this.mtxtEdad.TabIndex = 12;
            this.mtxtEdad.ValidatingType = typeof(int);
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbGenero.Location = new System.Drawing.Point(279, 166);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 13;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(279, 194);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 14;
            // 
            // mtxtNumHistoria
            // 
            this.mtxtNumHistoria.Location = new System.Drawing.Point(279, 221);
            this.mtxtNumHistoria.Mask = "9999";
            this.mtxtNumHistoria.Name = "mtxtNumHistoria";
            this.mtxtNumHistoria.Size = new System.Drawing.Size(100, 20);
            this.mtxtNumHistoria.TabIndex = 15;
            this.mtxtNumHistoria.ValidatingType = typeof(int);
            // 
            // mtxtSala
            // 
            this.mtxtSala.Location = new System.Drawing.Point(279, 247);
            this.mtxtSala.Mask = "999";
            this.mtxtSala.Name = "mtxtSala";
            this.mtxtSala.Size = new System.Drawing.Size(100, 20);
            this.mtxtSala.TabIndex = 16;
            this.mtxtSala.ValidatingType = typeof(int);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(279, 294);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(426, 294);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 18;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 370);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.mtxtSala);
            this.Controls.Add(this.mtxtNumHistoria);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.mtxtEdad);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.mtxtApellidos);
            this.Controls.Add(this.mtxtNombres);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblNumHistoria);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblRegistro);
            this.Name = "frmRegistro";
            this.Text = "Registro de Pacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblNumHistoria;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.MaskedTextBox mtxtNombres;
        private System.Windows.Forms.MaskedTextBox mtxtApellidos;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.MaskedTextBox mtxtEdad;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.MaskedTextBox mtxtNumHistoria;
        private System.Windows.Forms.MaskedTextBox mtxtSala;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrar;
    }
}

