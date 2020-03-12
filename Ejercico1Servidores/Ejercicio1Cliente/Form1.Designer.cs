namespace Ejercicio1Cliente
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
            this.resultado = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.Button();
            this.todo = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.cambiar = new System.Windows.Forms.Button();
            this.labelPuerto = new System.Windows.Forms.Label();
            this.labelIp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(358, 220);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 13);
            this.resultado.TabIndex = 0;
            // 
            // hora
            // 
            this.hora.Location = new System.Drawing.Point(58, 152);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(75, 23);
            this.hora.TabIndex = 1;
            this.hora.Tag = "HORA";
            this.hora.Text = "Hora";
            this.hora.UseVisualStyleBackColor = true;
            this.hora.Click += new System.EventHandler(this.Click);
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(233, 152);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(75, 23);
            this.fecha.TabIndex = 2;
            this.fecha.Tag = "FECHA";
            this.fecha.Text = "Fecha";
            this.fecha.UseVisualStyleBackColor = true;
            this.fecha.Click += new System.EventHandler(this.Click);
            // 
            // todo
            // 
            this.todo.Location = new System.Drawing.Point(453, 152);
            this.todo.Name = "todo";
            this.todo.Size = new System.Drawing.Size(75, 23);
            this.todo.TabIndex = 3;
            this.todo.Tag = "TODO";
            this.todo.Text = "todo";
            this.todo.UseVisualStyleBackColor = true;
            this.todo.Click += new System.EventHandler(this.Click);
            // 
            // apagar
            // 
            this.apagar.Location = new System.Drawing.Point(701, 152);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(75, 23);
            this.apagar.TabIndex = 4;
            this.apagar.Tag = "APAGAR";
            this.apagar.Text = "Apagar";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.Click);
            // 
            // cambiar
            // 
            this.cambiar.Location = new System.Drawing.Point(295, 304);
            this.cambiar.Name = "cambiar";
            this.cambiar.Size = new System.Drawing.Size(159, 23);
            this.cambiar.TabIndex = 5;
            this.cambiar.Text = "Cambiar Servidor";
            this.cambiar.UseVisualStyleBackColor = true;
            this.cambiar.Click += new System.EventHandler(this.Cambiar_Click);
            // 
            // labelPuerto
            // 
            this.labelPuerto.AutoSize = true;
            this.labelPuerto.Location = new System.Drawing.Point(55, 44);
            this.labelPuerto.Name = "labelPuerto";
            this.labelPuerto.Size = new System.Drawing.Size(35, 13);
            this.labelPuerto.TabIndex = 6;
            this.labelPuerto.Text = "label1";
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Location = new System.Drawing.Point(55, 19);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(35, 13);
            this.labelIp.TabIndex = 7;
            this.labelIp.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelIp);
            this.Controls.Add(this.labelPuerto);
            this.Controls.Add(this.cambiar);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.todo);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.resultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button hora;
        private System.Windows.Forms.Button fecha;
        private System.Windows.Forms.Button todo;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button cambiar;
        private System.Windows.Forms.Label labelPuerto;
        private System.Windows.Forms.Label labelIp;
    }
}

