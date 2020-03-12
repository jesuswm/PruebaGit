namespace ListBox
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
            this.listBoxI = new System.Windows.Forms.ListBox();
            this.listBoxD = new System.Windows.Forms.ListBox();
            this.Indeces = new System.Windows.Forms.Label();
            this.NumeroItens = new System.Windows.Forms.Label();
            this.texto = new System.Windows.Forms.TextBox();
            this.añadir = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.PasarI = new System.Windows.Forms.Button();
            this.PasarD = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxI
            // 
            this.listBoxI.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listBoxI.FormattingEnabled = true;
            this.listBoxI.Location = new System.Drawing.Point(101, 65);
            this.listBoxI.Name = "listBoxI";
            this.listBoxI.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxI.Size = new System.Drawing.Size(120, 95);
            this.listBoxI.TabIndex = 0;
            this.listBoxI.SelectedIndexChanged += new System.EventHandler(this.ListBoxI_SelectedIndexChanged);
            // 
            // listBoxD
            // 
            this.listBoxD.FormattingEnabled = true;
            this.listBoxD.Location = new System.Drawing.Point(426, 65);
            this.listBoxD.Name = "listBoxD";
            this.listBoxD.Size = new System.Drawing.Size(120, 95);
            this.listBoxD.TabIndex = 1;
            // 
            // Indeces
            // 
            this.Indeces.AutoSize = true;
            this.Indeces.Location = new System.Drawing.Point(101, 167);
            this.Indeces.Name = "Indeces";
            this.Indeces.Size = new System.Drawing.Size(0, 13);
            this.Indeces.TabIndex = 2;
            // 
            // NumeroItens
            // 
            this.NumeroItens.AutoSize = true;
            this.NumeroItens.Location = new System.Drawing.Point(101, 32);
            this.NumeroItens.Name = "NumeroItens";
            this.NumeroItens.Size = new System.Drawing.Size(68, 13);
            this.NumeroItens.TabIndex = 3;
            this.NumeroItens.Text = "Nº de itens 0";
            // 
            // texto
            // 
            this.texto.Location = new System.Drawing.Point(101, 237);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(100, 20);
            this.texto.TabIndex = 4;
            // 
            // añadir
            // 
            this.añadir.Location = new System.Drawing.Point(266, 233);
            this.añadir.Name = "añadir";
            this.añadir.Size = new System.Drawing.Size(75, 23);
            this.añadir.TabIndex = 5;
            this.añadir.Text = "Añadir";
            this.añadir.UseVisualStyleBackColor = true;
            this.añadir.Click += new System.EventHandler(this.Añadir_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(266, 131);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(75, 23);
            this.BEliminar.TabIndex = 7;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // PasarI
            // 
            this.PasarI.Location = new System.Drawing.Point(266, 102);
            this.PasarI.Name = "PasarI";
            this.PasarI.Size = new System.Drawing.Size(75, 23);
            this.PasarI.TabIndex = 8;
            this.PasarI.Text = "<=";
            this.PasarI.UseVisualStyleBackColor = true;
            this.PasarI.Click += new System.EventHandler(this.PasarI_Click);
            // 
            // PasarD
            // 
            this.PasarD.Location = new System.Drawing.Point(266, 65);
            this.PasarD.Name = "PasarD";
            this.PasarD.Size = new System.Drawing.Size(75, 23);
            this.PasarD.TabIndex = 9;
            this.PasarD.Text = "=>";
            this.PasarD.UseVisualStyleBackColor = true;
            this.PasarD.Click += new System.EventHandler(this.PasarD_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasarD);
            this.Controls.Add(this.PasarI);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.añadir);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.NumeroItens);
            this.Controls.Add(this.Indeces);
            this.Controls.Add(this.listBoxD);
            this.Controls.Add(this.listBoxI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxI;
        private System.Windows.Forms.ListBox listBoxD;
        private System.Windows.Forms.Label Indeces;
        private System.Windows.Forms.Label NumeroItens;
        private System.Windows.Forms.TextBox texto;
        private System.Windows.Forms.Button añadir;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Button PasarI;
        private System.Windows.Forms.Button PasarD;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

