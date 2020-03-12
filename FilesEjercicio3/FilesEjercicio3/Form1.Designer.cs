namespace FilesEjercicio3
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
            this.editor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bnuevo = new System.Windows.Forms.Button();
            this.bAbrir = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // editor
            // 
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.Enabled = false;
            this.editor.Location = new System.Drawing.Point(0, 0);
            this.editor.Multiline = true;
            this.editor.Name = "editor";
            this.editor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.editor.Size = new System.Drawing.Size(800, 381);
            this.editor.TabIndex = 0;
            this.editor.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bnuevo);
            this.panel1.Controls.Add(this.bAbrir);
            this.panel1.Controls.Add(this.bguardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 69);
            this.panel1.TabIndex = 1;
            // 
            // bnuevo
            // 
            this.bnuevo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnuevo.Location = new System.Drawing.Point(0, 0);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(800, 23);
            this.bnuevo.TabIndex = 2;
            this.bnuevo.Text = "Nuevo";
            this.bnuevo.UseVisualStyleBackColor = true;
            this.bnuevo.Click += new System.EventHandler(this.Bnuevo_Click);
            // 
            // bAbrir
            // 
            this.bAbrir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bAbrir.Location = new System.Drawing.Point(0, 23);
            this.bAbrir.Name = "bAbrir";
            this.bAbrir.Size = new System.Drawing.Size(800, 23);
            this.bAbrir.TabIndex = 1;
            this.bAbrir.Text = "Abrir";
            this.bAbrir.UseVisualStyleBackColor = true;
            this.bAbrir.Click += new System.EventHandler(this.BAbrir_Click);
            // 
            // bguardar
            // 
            this.bguardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bguardar.Location = new System.Drawing.Point(0, 46);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(800, 23);
            this.bguardar.TabIndex = 0;
            this.bguardar.Text = "Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.Bguardar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.editor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 381);
            this.panel2.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Textos|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Textos|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Ejercicio3 Files";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox editor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.Button bAbrir;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

