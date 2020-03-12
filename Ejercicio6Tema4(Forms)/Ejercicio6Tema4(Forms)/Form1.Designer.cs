namespace Ejercicio6Tema4_Forms_
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
            this.Display = new System.Windows.Forms.Label();
            this.Tiradaj1 = new System.Windows.Forms.Label();
            this.Tiradaj2 = new System.Windows.Forms.Label();
            this.Puntuacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.AutoSize = true;
            this.Display.Location = new System.Drawing.Point(223, 97);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(41, 13);
            this.Display.TabIndex = 0;
            this.Display.Text = "Display";
            // 
            // Tiradaj1
            // 
            this.Tiradaj1.AutoSize = true;
            this.Tiradaj1.Location = new System.Drawing.Point(87, 97);
            this.Tiradaj1.Name = "Tiradaj1";
            this.Tiradaj1.Size = new System.Drawing.Size(51, 13);
            this.Tiradaj1.TabIndex = 1;
            this.Tiradaj1.Text = "Jugador1";
            // 
            // Tiradaj2
            // 
            this.Tiradaj2.AutoSize = true;
            this.Tiradaj2.Location = new System.Drawing.Point(360, 97);
            this.Tiradaj2.Name = "Tiradaj2";
            this.Tiradaj2.Size = new System.Drawing.Size(51, 13);
            this.Tiradaj2.TabIndex = 2;
            this.Tiradaj2.Text = "Jugador2";
            // 
            // Puntuacion
            // 
            this.Puntuacion.AutoSize = true;
            this.Puntuacion.Location = new System.Drawing.Point(223, 176);
            this.Puntuacion.Name = "Puntuacion";
            this.Puntuacion.Size = new System.Drawing.Size(35, 13);
            this.Puntuacion.TabIndex = 3;
            this.Puntuacion.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jugador1";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(360, 56);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(51, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Jugador2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Puntuacion);
            this.Controls.Add(this.Tiradaj2);
            this.Controls.Add(this.Tiradaj1);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.Label Tiradaj1;
        private System.Windows.Forms.Label Tiradaj2;
        private System.Windows.Forms.Label Puntuacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label2;
    }
}

