namespace Ejercicio_3_Tema_1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.jugar = new System.Windows.Forms.Button();
            this.premio = new System.Windows.Forms.Label();
            this.lcredito = new System.Windows.Forms.Label();
            this.bcredito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(132, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(330, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(554, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // jugar
            // 
            this.jugar.Location = new System.Drawing.Point(330, 297);
            this.jugar.Name = "jugar";
            this.jugar.Size = new System.Drawing.Size(75, 23);
            this.jugar.TabIndex = 3;
            this.jugar.Text = "Jugar";
            this.jugar.UseVisualStyleBackColor = true;
            this.jugar.Click += new System.EventHandler(this.Jugar_Click);
            // 
            // premio
            // 
            this.premio.AutoSize = true;
            this.premio.Location = new System.Drawing.Point(349, 240);
            this.premio.Name = "premio";
            this.premio.Size = new System.Drawing.Size(0, 13);
            this.premio.TabIndex = 4;
            // 
            // lcredito
            // 
            this.lcredito.AutoSize = true;
            this.lcredito.Location = new System.Drawing.Point(573, 297);
            this.lcredito.Name = "lcredito";
            this.lcredito.Size = new System.Drawing.Size(48, 13);
            this.lcredito.TabIndex = 5;
            this.lcredito.Text = "Creditos ";
            // 
            // bcredito
            // 
            this.bcredito.Location = new System.Drawing.Point(564, 240);
            this.bcredito.Name = "bcredito";
            this.bcredito.Size = new System.Drawing.Size(75, 23);
            this.bcredito.TabIndex = 6;
            this.bcredito.Text = "Añadir 10€";
            this.bcredito.UseVisualStyleBackColor = true;
            this.bcredito.Click += new System.EventHandler(this.Bcredito_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bcredito);
            this.Controls.Add(this.lcredito);
            this.Controls.Add(this.premio);
            this.Controls.Add(this.jugar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button jugar;
        private System.Windows.Forms.Label premio;
        private System.Windows.Forms.Label lcredito;
        private System.Windows.Forms.Button bcredito;
    }
}

