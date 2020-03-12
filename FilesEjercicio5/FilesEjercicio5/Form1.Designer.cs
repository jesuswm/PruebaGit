namespace FilesEjercicio5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tdirectorio = new System.Windows.Forms.TextBox();
            this.tpalabra = new System.Windows.Forms.TextBox();
            this.tBusqueda = new System.Windows.Forms.TextBox();
            this.cMayusculas = new System.Windows.Forms.CheckBox();
            this.buscar = new System.Windows.Forms.Button();
            this.textensiones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tdirectorio
            // 
            this.tdirectorio.Location = new System.Drawing.Point(138, 29);
            this.tdirectorio.Name = "tdirectorio";
            this.tdirectorio.Size = new System.Drawing.Size(145, 20);
            this.tdirectorio.TabIndex = 0;
            // 
            // tpalabra
            // 
            this.tpalabra.Location = new System.Drawing.Point(138, 65);
            this.tpalabra.Name = "tpalabra";
            this.tpalabra.Size = new System.Drawing.Size(145, 20);
            this.tpalabra.TabIndex = 1;
            // 
            // tBusqueda
            // 
            this.tBusqueda.Location = new System.Drawing.Point(29, 151);
            this.tBusqueda.Multiline = true;
            this.tBusqueda.Name = "tBusqueda";
            this.tBusqueda.ReadOnly = true;
            this.tBusqueda.Size = new System.Drawing.Size(284, 151);
            this.tBusqueda.TabIndex = 2;
            // 
            // cMayusculas
            // 
            this.cMayusculas.AutoSize = true;
            this.cMayusculas.Location = new System.Drawing.Point(298, 71);
            this.cMayusculas.Name = "cMayusculas";
            this.cMayusculas.Size = new System.Drawing.Size(82, 17);
            this.cMayusculas.TabIndex = 3;
            this.cMayusculas.Text = "Mayusculas";
            this.cMayusculas.UseVisualStyleBackColor = true;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(577, 61);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 4;
            this.buscar.Text = "buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // textensiones
            // 
            this.textensiones.Location = new System.Drawing.Point(436, 151);
            this.textensiones.Name = "textensiones";
            this.textensiones.Size = new System.Drawing.Size(216, 20);
            this.textensiones.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Extensiones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ruta de la carpera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cadena que buscar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textensiones);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.cMayusculas);
            this.Controls.Add(this.tBusqueda);
            this.Controls.Add(this.tpalabra);
            this.Controls.Add(this.tdirectorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ejercicio5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tdirectorio;
        private System.Windows.Forms.TextBox tpalabra;
        private System.Windows.Forms.TextBox tBusqueda;
        private System.Windows.Forms.CheckBox cMayusculas;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox textensiones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

