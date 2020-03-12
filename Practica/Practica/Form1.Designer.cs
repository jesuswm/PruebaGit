namespace Practica
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
            this.components = new System.ComponentModel.Container();
            this.Babrir = new System.Windows.Forms.Button();
            this.cmodal = new System.Windows.Forms.CheckBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Babrir
            // 
            this.Babrir.Location = new System.Drawing.Point(139, 103);
            this.Babrir.Name = "Babrir";
            this.Babrir.Size = new System.Drawing.Size(75, 23);
            this.Babrir.TabIndex = 0;
            this.Babrir.Text = "Seleccionar archivo";
            this.toolTip1.SetToolTip(this.Babrir, "Al pulsar este boton se le permitira al usuario seleccionar una imagen\r\n");
            this.Babrir.UseVisualStyleBackColor = true;
            this.Babrir.Click += new System.EventHandler(this.Babrir_Click);
            // 
            // cmodal
            // 
            this.cmodal.AutoSize = true;
            this.cmodal.Location = new System.Drawing.Point(272, 108);
            this.cmodal.Name = "cmodal";
            this.cmodal.Size = new System.Drawing.Size(55, 17);
            this.cmodal.TabIndex = 1;
            this.cmodal.Text = "Modal";
            this.toolTip1.SetToolTip(this.cmodal, "Si esta chekeado el formulario secundario sera  modal");
            this.cmodal.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Todos los archivos|*.*|jpge|.jpg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmodal);
            this.Controls.Add(this.Babrir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Babrir;
        private System.Windows.Forms.CheckBox cmodal;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

