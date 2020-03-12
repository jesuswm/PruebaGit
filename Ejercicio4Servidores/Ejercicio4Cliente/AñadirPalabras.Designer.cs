namespace Ejercicio4Cliente
{
    partial class AñadirPalabras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirPalabras));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioArchivo = new System.Windows.Forms.RadioButton();
            this.radioTexto = new System.Windows.Forms.RadioButton();
            this.bAñadir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bArchivo = new System.Windows.Forms.Button();
            this.tPalabras = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioArchivo);
            this.groupBox1.Controls.Add(this.radioTexto);
            this.groupBox1.Location = new System.Drawing.Point(26, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioArchivo
            // 
            this.radioArchivo.AutoSize = true;
            this.radioArchivo.Location = new System.Drawing.Point(7, 44);
            this.radioArchivo.Name = "radioArchivo";
            this.radioArchivo.Size = new System.Drawing.Size(166, 17);
            this.radioArchivo.TabIndex = 1;
            this.radioArchivo.Text = "Añadir palabras de un archivo";
            this.radioArchivo.UseVisualStyleBackColor = true;
            this.radioArchivo.CheckedChanged += new System.EventHandler(this.RadioArchivo_CheckedChanged);
            // 
            // radioTexto
            // 
            this.radioTexto.AutoSize = true;
            this.radioTexto.Checked = true;
            this.radioTexto.Location = new System.Drawing.Point(6, 21);
            this.radioTexto.Name = "radioTexto";
            this.radioTexto.Size = new System.Drawing.Size(210, 17);
            this.radioTexto.TabIndex = 0;
            this.radioTexto.TabStop = true;
            this.radioTexto.Text = "Añadir el contenido del cuadro de texto";
            this.radioTexto.UseVisualStyleBackColor = true;
            this.radioTexto.CheckedChanged += new System.EventHandler(this.RadioArchivo_CheckedChanged);
            // 
            // bAñadir
            // 
            this.bAñadir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAñadir.Location = new System.Drawing.Point(168, 172);
            this.bAñadir.Name = "bAñadir";
            this.bAñadir.Size = new System.Drawing.Size(75, 23);
            this.bAñadir.TabIndex = 1;
            this.bAñadir.Text = "Añadir";
            this.bAñadir.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Archivos de texto\"|*.txt";
            // 
            // bArchivo
            // 
            this.bArchivo.Enabled = false;
            this.bArchivo.Location = new System.Drawing.Point(265, 93);
            this.bArchivo.Name = "bArchivo";
            this.bArchivo.Size = new System.Drawing.Size(147, 23);
            this.bArchivo.TabIndex = 2;
            this.bArchivo.Text = "Seleccionar archivo";
            this.bArchivo.UseVisualStyleBackColor = true;
            this.bArchivo.Click += new System.EventHandler(this.BArchivo_Click);
            // 
            // tPalabras
            // 
            this.tPalabras.Location = new System.Drawing.Point(265, 66);
            this.tPalabras.Name = "tPalabras";
            this.tPalabras.Size = new System.Drawing.Size(147, 20);
            this.tPalabras.TabIndex = 3;
            // 
            // AñadirPalabras
            // 
            this.AcceptButton = this.bAñadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 217);
            this.Controls.Add(this.tPalabras);
            this.Controls.Add(this.bArchivo);
            this.Controls.Add(this.bAñadir);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AñadirPalabras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AñadirPalabras";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioArchivo;
        private System.Windows.Forms.RadioButton radioTexto;
        private System.Windows.Forms.Button bAñadir;
        private System.Windows.Forms.Button bArchivo;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox tPalabras;
    }
}