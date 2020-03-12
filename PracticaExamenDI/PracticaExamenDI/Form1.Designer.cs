using System.Drawing;

namespace PracticaExamenDI
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
            this.tipo = new System.Windows.Forms.GroupBox();
            this.rpersona = new System.Windows.Forms.RadioButton();
            this.re = new System.Windows.Forms.RadioButton();
            this.rpublica = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.urgencia = new System.Windows.Forms.GroupBox();
            this.Rmañana = new System.Windows.Forms.RadioButton();
            this.rHoy = new System.Windows.Forms.RadioButton();
            this.ry = new System.Windows.Forms.RadioButton();
            this.btnAlmacenar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tipo.SuspendLayout();
            this.urgencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Tag = System.Drawing.Color.LightPink;
            this.txtNombre.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(218, 34);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(100, 20);
            this.txtDestinatario.TabIndex = 1;
            this.txtDestinatario.Tag = System.Drawing.Color.LightPink;
            this.txtDestinatario.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtDestinatario.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(421, 34);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(306, 144);
            this.txtNota.TabIndex = 2;
            this.txtNota.Tag = System.Drawing.Color.Aquamarine;
            this.txtNota.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtNota.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // tipo
            // 
            this.tipo.Controls.Add(this.rpersona);
            this.tipo.Controls.Add(this.re);
            this.tipo.Controls.Add(this.rpublica);
            this.tipo.Location = new System.Drawing.Point(12, 268);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(110, 83);
            this.tipo.TabIndex = 5;
            this.tipo.TabStop = false;
            this.tipo.Tag = "";
            this.tipo.Text = "Tipo";
            // 
            // rpersona
            // 
            this.rpersona.AutoSize = true;
            this.rpersona.Location = new System.Drawing.Point(6, 61);
            this.rpersona.Name = "rpersona";
            this.rpersona.Size = new System.Drawing.Size(66, 17);
            this.rpersona.TabIndex = 8;
            this.rpersona.TabStop = true;
            this.rpersona.Tag = "personal";
            this.rpersona.Text = "Personal";
            this.rpersona.UseVisualStyleBackColor = true;
            // 
            // re
            // 
            this.re.AutoSize = true;
            this.re.Location = new System.Drawing.Point(5, 38);
            this.re.Name = "re";
            this.re.Size = new System.Drawing.Size(66, 17);
            this.re.TabIndex = 7;
            this.re.TabStop = true;
            this.re.Tag = "empresa";
            this.re.Text = "Empresa";
            this.re.UseVisualStyleBackColor = true;
            // 
            // rpublica
            // 
            this.rpublica.AutoSize = true;
            this.rpublica.Location = new System.Drawing.Point(6, 19);
            this.rpublica.Name = "rpublica";
            this.rpublica.Size = new System.Drawing.Size(60, 17);
            this.rpublica.TabIndex = 6;
            this.rpublica.TabStop = true;
            this.rpublica.Tag = "publica";
            this.rpublica.Text = "Publica";
            this.rpublica.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destinatario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // urgencia
            // 
            this.urgencia.Controls.Add(this.Rmañana);
            this.urgencia.Controls.Add(this.rHoy);
            this.urgencia.Controls.Add(this.ry);
            this.urgencia.Location = new System.Drawing.Point(569, 268);
            this.urgencia.Name = "urgencia";
            this.urgencia.Size = new System.Drawing.Size(200, 83);
            this.urgencia.TabIndex = 9;
            this.urgencia.TabStop = false;
            this.urgencia.Text = "Urgencia";
            // 
            // Rmañana
            // 
            this.Rmañana.AutoSize = true;
            this.Rmañana.Location = new System.Drawing.Point(7, 65);
            this.Rmañana.Name = "Rmañana";
            this.Rmañana.Size = new System.Drawing.Size(64, 17);
            this.Rmañana.TabIndex = 12;
            this.Rmañana.TabStop = true;
            this.Rmañana.Text = "Mañana";
            this.Rmañana.UseVisualStyleBackColor = true;
            // 
            // rHoy
            // 
            this.rHoy.AutoSize = true;
            this.rHoy.Location = new System.Drawing.Point(7, 41);
            this.rHoy.Name = "rHoy";
            this.rHoy.Size = new System.Drawing.Size(44, 17);
            this.rHoy.TabIndex = 11;
            this.rHoy.TabStop = true;
            this.rHoy.Text = "Hoy";
            this.rHoy.UseVisualStyleBackColor = true;
            // 
            // ry
            // 
            this.ry.AutoSize = true;
            this.ry.Location = new System.Drawing.Point(7, 17);
            this.ry.Name = "ry";
            this.ry.Size = new System.Drawing.Size(38, 17);
            this.ry.TabIndex = 10;
            this.ry.TabStop = true;
            this.ry.Text = "Ya";
            this.ry.UseVisualStyleBackColor = true;
            // 
            // btnAlmacenar
            // 
            this.btnAlmacenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlmacenar.Location = new System.Drawing.Point(43, 206);
            this.btnAlmacenar.Name = "btnAlmacenar";
            this.btnAlmacenar.Size = new System.Drawing.Size(75, 23);
            this.btnAlmacenar.TabIndex = 3;
            this.btnAlmacenar.Text = "&Almacenar";
            this.btnAlmacenar.UseVisualStyleBackColor = true;
            this.btnAlmacenar.Click += new System.EventHandler(this.BtnAlmacenar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizar.Location = new System.Drawing.Point(218, 205);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 4;
            this.btnVisualizar.Text = "&Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Location = new System.Drawing.Point(421, 206);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.TabStop = false;
            this.btnBorrar.Text = "&Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(613, 205);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnAlmacenar);
            this.Controls.Add(this.urgencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tipo.ResumeLayout(false);
            this.tipo.PerformLayout();
            this.urgencia.ResumeLayout(false);
            this.urgencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.GroupBox tipo;
        private System.Windows.Forms.RadioButton rpersona;
        private System.Windows.Forms.RadioButton re;
        private System.Windows.Forms.RadioButton rpublica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox urgencia;
        private System.Windows.Forms.RadioButton Rmañana;
        private System.Windows.Forms.RadioButton rHoy;
        private System.Windows.Forms.RadioButton ry;
        private System.Windows.Forms.Button btnAlmacenar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
    }
}

