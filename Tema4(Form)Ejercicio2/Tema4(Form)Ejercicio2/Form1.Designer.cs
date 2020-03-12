namespace Tema4_Form_Ejercicio2
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
            this.Izquierda = new System.Windows.Forms.Button();
            this.Derecha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Izquierda
            // 
            this.Izquierda.Location = new System.Drawing.Point(223, 58);
            this.Izquierda.Name = "Izquierda";
            this.Izquierda.Size = new System.Drawing.Size(75, 23);
            this.Izquierda.TabIndex = 0;
            this.Izquierda.Text = "Izquierda";
            this.Izquierda.UseVisualStyleBackColor = true;
            this.Izquierda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseMove);
            // 
            // Derecha
            // 
            this.Derecha.Location = new System.Drawing.Point(374, 58);
            this.Derecha.Name = "Derecha";
            this.Derecha.Size = new System.Drawing.Size(75, 23);
            this.Derecha.TabIndex = 1;
            this.Derecha.Text = "Derecha";
            this.Derecha.UseVisualStyleBackColor = true;
            this.Derecha.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Derecha);
            this.Controls.Add(this.Izquierda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Ejercicio 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

#endregion

        private System.Windows.Forms.Button Izquierda;
        private System.Windows.Forms.Button Derecha;
    }
}

