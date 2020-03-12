namespace Tema4_Form_Ejercicio1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbr = new System.Windows.Forms.TextBox();
            this.tbg = new System.Windows.Forms.TextBox();
            this.tbb = new System.Windows.Forms.TextBox();
            this.tpath = new System.Windows.Forms.TextBox();
            this.Cargar = new System.Windows.Forms.Button();
            this.lImagen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(323, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.CambiarColorBoton);
            this.button1.MouseLeave += new System.EventHandler(this.RecuperarColorBoton);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.CambiarColorBoton);
            this.button2.MouseLeave += new System.EventHandler(this.RecuperarColorBoton);
            // 
            // tbr
            // 
            this.tbr.AcceptsReturn = true;
            this.tbr.Location = new System.Drawing.Point(122, 93);
            this.tbr.Name = "tbr";
            this.tbr.Size = new System.Drawing.Size(100, 20);
            this.tbr.TabIndex = 0;
            this.tbr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulsarEnter_KeyDown);
            // 
            // tbg
            // 
            this.tbg.AcceptsReturn = true;
            this.tbg.Location = new System.Drawing.Point(323, 94);
            this.tbg.Name = "tbg";
            this.tbg.Size = new System.Drawing.Size(100, 20);
            this.tbg.TabIndex = 2;
            this.tbg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulsarEnter_KeyDown);
            // 
            // tbb
            // 
            this.tbb.AcceptsReturn = true;
            this.tbb.Location = new System.Drawing.Point(541, 93);
            this.tbb.Name = "tbb";
            this.tbb.Size = new System.Drawing.Size(100, 20);
            this.tbb.TabIndex = 3;
            this.tbb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulsarEnter_KeyDown);
            // 
            // tpath
            // 
            this.tpath.AcceptsReturn = true;
            this.tpath.Location = new System.Drawing.Point(131, 203);
            this.tpath.Name = "tpath";
            this.tpath.Size = new System.Drawing.Size(330, 20);
            this.tpath.TabIndex = 5;
            this.tpath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulsarEnter_KeyDown);
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(507, 201);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(86, 23);
            this.Cargar.TabIndex = 6;
            this.Cargar.Text = "Cargar Imagen";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            this.Cargar.MouseEnter += new System.EventHandler(this.CambiarColorBoton);
            this.Cargar.MouseLeave += new System.EventHandler(this.RecuperarColorBoton);
            // 
            // lImagen
            // 
            this.lImagen.Image = global::Tema4_Form_Ejercicio1.Properties.Resources.Cosa;
            this.lImagen.Location = new System.Drawing.Point(128, 284);
            this.lImagen.Name = "lImagen";
            this.lImagen.Size = new System.Drawing.Size(76, 66);
            this.lImagen.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lImagen);
            this.Controls.Add(this.Cargar);
            this.Controls.Add(this.tpath);
            this.Controls.Add(this.tbb);
            this.Controls.Add(this.tbg);
            this.Controls.Add(this.tbr);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbr;
        private System.Windows.Forms.TextBox tbg;
        private System.Windows.Forms.TextBox tbb;
        private System.Windows.Forms.TextBox tpath;
        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.Label lImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

