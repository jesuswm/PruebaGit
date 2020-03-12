namespace Tema4_Form_Ejercicio4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numero1 = new System.Windows.Forms.TextBox();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.division = new System.Windows.Forms.RadioButton();
            this.multiplicaccion = new System.Windows.Forms.RadioButton();
            this.resta = new System.Windows.Forms.RadioButton();
            this.suma = new System.Windows.Forms.RadioButton();
            this.operacion = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(126, 67);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(100, 20);
            this.numero1.TabIndex = 0;
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(439, 67);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(100, 20);
            this.numero2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.division);
            this.groupBox1.Controls.Add(this.multiplicaccion);
            this.groupBox1.Controls.Add(this.resta);
            this.groupBox1.Controls.Add(this.suma);
            this.groupBox1.Location = new System.Drawing.Point(155, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 47);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // division
            // 
            this.division.AutoSize = true;
            this.division.Location = new System.Drawing.Point(294, 19);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(30, 17);
            this.division.TabIndex = 7;
            this.division.Tag = "/";
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // multiplicaccion
            // 
            this.multiplicaccion.AutoSize = true;
            this.multiplicaccion.Location = new System.Drawing.Point(203, 19);
            this.multiplicaccion.Name = "multiplicaccion";
            this.multiplicaccion.Size = new System.Drawing.Size(29, 17);
            this.multiplicaccion.TabIndex = 6;
            this.multiplicaccion.Tag = "*";
            this.multiplicaccion.Text = "*";
            this.multiplicaccion.UseVisualStyleBackColor = true;
            this.multiplicaccion.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // resta
            // 
            this.resta.AutoSize = true;
            this.resta.Location = new System.Drawing.Point(112, 19);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(28, 17);
            this.resta.TabIndex = 5;
            this.resta.Tag = "-";
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // suma
            // 
            this.suma.AutoSize = true;
            this.suma.Checked = true;
            this.suma.Location = new System.Drawing.Point(21, 19);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(31, 17);
            this.suma.TabIndex = 4;
            this.suma.TabStop = true;
            this.suma.Tag = "+";
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // operacion
            // 
            this.operacion.AutoSize = true;
            this.operacion.Location = new System.Drawing.Point(324, 67);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(13, 13);
            this.operacion.TabIndex = 3;
            this.operacion.Text = "+";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(636, 73);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(35, 13);
            this.Resultado.TabIndex = 2;
            this.Resultado.Text = "label1";
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(289, 167);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 8;
            this.Calcular.Text = "&calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.Calcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "00:00";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton division;
        private System.Windows.Forms.RadioButton multiplicaccion;
        private System.Windows.Forms.RadioButton resta;
        private System.Windows.Forms.RadioButton suma;
        private System.Windows.Forms.Label operacion;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Timer timer1;
    }
}

