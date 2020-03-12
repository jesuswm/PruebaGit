using System.Drawing;

namespace PracticaDi
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nota = new System.Windows.Forms.Label();
            this.btnAlmacenar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.GTipo = new System.Windows.Forms.GroupBox();
            this.RPersonal = new System.Windows.Forms.RadioButton();
            this.rEmpresa = new System.Windows.Forms.RadioButton();
            this.rPublico = new System.Windows.Forms.RadioButton();
            this.gUrgencia = new System.Windows.Forms.GroupBox();
            this.rMañana = new System.Windows.Forms.RadioButton();
            this.rHoy = new System.Windows.Forms.RadioButton();
            this.rYa = new System.Windows.Forms.RadioButton();
            this.GTipo.SuspendLayout();
            this.gUrgencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(40, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Tag = System.Drawing.Color.LightPink;
            this.txtNombre.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(311, 33);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(100, 20);
            this.txtDestinatario.TabIndex = 1;
            this.txtDestinatario.Tag = System.Drawing.Color.LightPink;
            this.txtDestinatario.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtDestinatario.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(475, 33);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNota.Size = new System.Drawing.Size(226, 135);
            this.txtNota.TabIndex = 2;
            this.txtNota.Tag = System.Drawing.Color.Aquamarine;
            this.txtNota.WordWrap = false;
            this.txtNota.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtNota.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripción";
            // 
            // Nota
            // 
            this.Nota.AutoSize = true;
            this.Nota.Location = new System.Drawing.Point(574, 13);
            this.Nota.Name = "Nota";
            this.Nota.Size = new System.Drawing.Size(35, 13);
            this.Nota.TabIndex = 5;
            this.Nota.Text = "label3";
            // 
            // btnAlmacenar
            // 
            this.btnAlmacenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlmacenar.Location = new System.Drawing.Point(40, 222);
            this.btnAlmacenar.Name = "btnAlmacenar";
            this.btnAlmacenar.Size = new System.Drawing.Size(75, 23);
            this.btnAlmacenar.TabIndex = 6;
            this.btnAlmacenar.Text = "&Almacenar";
            this.btnAlmacenar.UseVisualStyleBackColor = true;
            this.btnAlmacenar.Click += new System.EventHandler(this.BtnAlmacenar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizar.Location = new System.Drawing.Point(225, 222);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "&Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Location = new System.Drawing.Point(405, 221);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.TabStop = false;
            this.btnBorrar.Text = "&Borrar";
            this.btnBorrar.UseCompatibleTextRendering = true;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(602, 221);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // GTipo
            // 
            this.GTipo.Controls.Add(this.RPersonal);
            this.GTipo.Controls.Add(this.rEmpresa);
            this.GTipo.Controls.Add(this.rPublico);
            this.GTipo.Location = new System.Drawing.Point(40, 320);
            this.GTipo.Name = "GTipo";
            this.GTipo.Size = new System.Drawing.Size(200, 100);
            this.GTipo.TabIndex = 10;
            this.GTipo.TabStop = false;
            this.GTipo.Text = "Tipo";
            // 
            // RPersonal
            // 
            this.RPersonal.AutoSize = true;
            this.RPersonal.Location = new System.Drawing.Point(7, 68);
            this.RPersonal.Name = "RPersonal";
            this.RPersonal.Size = new System.Drawing.Size(66, 17);
            this.RPersonal.TabIndex = 2;
            this.RPersonal.Tag = "Personal";
            this.RPersonal.Text = "Personal";
            this.RPersonal.UseVisualStyleBackColor = true;
            this.RPersonal.CheckedChanged += new System.EventHandler(this.Tipo_CheckedChanged);
            // 
            // rEmpresa
            // 
            this.rEmpresa.AutoSize = true;
            this.rEmpresa.Location = new System.Drawing.Point(7, 44);
            this.rEmpresa.Name = "rEmpresa";
            this.rEmpresa.Size = new System.Drawing.Size(66, 17);
            this.rEmpresa.TabIndex = 1;
            this.rEmpresa.Tag = "Empresa";
            this.rEmpresa.Text = "Empresa";
            this.rEmpresa.UseVisualStyleBackColor = true;
            this.rEmpresa.CheckedChanged += new System.EventHandler(this.Tipo_CheckedChanged);
            // 
            // rPublico
            // 
            this.rPublico.AutoSize = true;
            this.rPublico.Checked = true;
            this.rPublico.Location = new System.Drawing.Point(7, 20);
            this.rPublico.Name = "rPublico";
            this.rPublico.Size = new System.Drawing.Size(60, 17);
            this.rPublico.TabIndex = 0;
            this.rPublico.TabStop = true;
            this.rPublico.Tag = "Publica";
            this.rPublico.Text = "Publico";
            this.rPublico.UseVisualStyleBackColor = true;
            this.rPublico.CheckedChanged += new System.EventHandler(this.Tipo_CheckedChanged);
            // 
            // gUrgencia
            // 
            this.gUrgencia.Controls.Add(this.rMañana);
            this.gUrgencia.Controls.Add(this.rHoy);
            this.gUrgencia.Controls.Add(this.rYa);
            this.gUrgencia.Location = new System.Drawing.Point(539, 320);
            this.gUrgencia.Name = "gUrgencia";
            this.gUrgencia.Size = new System.Drawing.Size(200, 100);
            this.gUrgencia.TabIndex = 11;
            this.gUrgencia.TabStop = false;
            this.gUrgencia.Text = "Urgencia";
            // 
            // rMañana
            // 
            this.rMañana.AutoSize = true;
            this.rMañana.Location = new System.Drawing.Point(7, 68);
            this.rMañana.Name = "rMañana";
            this.rMañana.Size = new System.Drawing.Size(64, 17);
            this.rMañana.TabIndex = 2;
            this.rMañana.Tag = PracticaDi.Form1.Urgencia.Mañana;
            this.rMañana.Text = "Mañana";
            this.rMañana.UseVisualStyleBackColor = true;
            this.rMañana.CheckedChanged += new System.EventHandler(this.Urgencia_CheckedChanged);
            // 
            // rHoy
            // 
            this.rHoy.AutoSize = true;
            this.rHoy.Location = new System.Drawing.Point(7, 44);
            this.rHoy.Name = "rHoy";
            this.rHoy.Size = new System.Drawing.Size(44, 17);
            this.rHoy.TabIndex = 1;
            this.rHoy.Tag = PracticaDi.Form1.Urgencia.Hoy;
            this.rHoy.Text = "Hoy";
            this.rHoy.UseVisualStyleBackColor = true;
            this.rHoy.CheckedChanged += new System.EventHandler(this.Urgencia_CheckedChanged);
            // 
            // rYa
            // 
            this.rYa.AutoSize = true;
            this.rYa.Checked = true;
            this.rYa.Location = new System.Drawing.Point(7, 20);
            this.rYa.Name = "rYa";
            this.rYa.Size = new System.Drawing.Size(38, 17);
            this.rYa.TabIndex = 0;
            this.rYa.TabStop = true;
            this.rYa.Tag = PracticaDi.Form1.Urgencia.Ya;
            this.rYa.Text = "Ya";
            this.rYa.UseVisualStyleBackColor = true;
            this.rYa.CheckedChanged += new System.EventHandler(this.Urgencia_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gUrgencia);
            this.Controls.Add(this.GTipo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnAlmacenar);
            this.Controls.Add(this.Nota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.GTipo.ResumeLayout(false);
            this.GTipo.PerformLayout();
            this.gUrgencia.ResumeLayout(false);
            this.gUrgencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nota;
        private System.Windows.Forms.Button btnAlmacenar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox GTipo;
        private System.Windows.Forms.RadioButton RPersonal;
        private System.Windows.Forms.RadioButton rEmpresa;
        private System.Windows.Forms.RadioButton rPublico;
        private System.Windows.Forms.GroupBox gUrgencia;
        private System.Windows.Forms.RadioButton rMañana;
        private System.Windows.Forms.RadioButton rHoy;
        private System.Windows.Forms.RadioButton rYa;
    }
}

