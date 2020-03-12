namespace Ejercicio4Cliente
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
            this.sendword = new System.Windows.Forms.Button();
            this.labelLetra = new System.Windows.Forms.Label();
            this.Jugar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tJugar = new System.Windows.Forms.ToolStripButton();
            this.tRecords = new System.Windows.Forms.ToolStripButton();
            this.tPalabras = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.juegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mJugar = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarPartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.consultarRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palabrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirPalbrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ltiempo = new System.Windows.Forms.Label();
            this.textLetra = new System.Windows.Forms.TextBox();
            this.dibujoAhorcado1 = new DibujoAhorcado.DibujoAhorcado();
            this.sevidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarIpYPuertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lcomprobados = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendword
            // 
            this.sendword.Enabled = false;
            this.sendword.Location = new System.Drawing.Point(272, 125);
            this.sendword.Name = "sendword";
            this.sendword.Size = new System.Drawing.Size(75, 23);
            this.sendword.TabIndex = 4;
            this.sendword.Tag = "sendword";
            this.sendword.Text = "&Comprobar";
            this.sendword.UseVisualStyleBackColor = true;
            this.sendword.Click += new System.EventHandler(this.ComprobarLetra);
            // 
            // labelLetra
            // 
            this.labelLetra.AutoSize = true;
            this.labelLetra.Enabled = false;
            this.labelLetra.Location = new System.Drawing.Point(32, 131);
            this.labelLetra.Name = "labelLetra";
            this.labelLetra.Size = new System.Drawing.Size(101, 13);
            this.labelLetra.TabIndex = 2;
            this.labelLetra.Text = "Introduzca una letra";
            // 
            // Jugar
            // 
            this.Jugar.Location = new System.Drawing.Point(165, 178);
            this.Jugar.Name = "Jugar";
            this.Jugar.Size = new System.Drawing.Size(75, 23);
            this.Jugar.TabIndex = 6;
            this.Jugar.Tag = "getword";
            this.Jugar.Text = "&Iniciar Juego";
            this.Jugar.UseVisualStyleBackColor = true;
            this.Jugar.Click += new System.EventHandler(this.Jugar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tJugar,
            this.tRecords,
            this.tPalabras});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(645, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tJugar
            // 
            this.tJugar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tJugar.Image = ((System.Drawing.Image)(resources.GetObject("tJugar.Image")));
            this.tJugar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tJugar.Name = "tJugar";
            this.tJugar.Size = new System.Drawing.Size(23, 22);
            this.tJugar.Text = "Jugar";
            this.tJugar.Click += new System.EventHandler(this.Jugar_Click);
            // 
            // tRecords
            // 
            this.tRecords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tRecords.Image = ((System.Drawing.Image)(resources.GetObject("tRecords.Image")));
            this.tRecords.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tRecords.Name = "tRecords";
            this.tRecords.Size = new System.Drawing.Size(23, 22);
            this.tRecords.Tag = "getrecords";
            this.tRecords.Text = "Records";
            this.tRecords.Click += new System.EventHandler(this.Getrecords_Click);
            // 
            // tPalabras
            // 
            this.tPalabras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tPalabras.Image = ((System.Drawing.Image)(resources.GetObject("tPalabras.Image")));
            this.tPalabras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tPalabras.Name = "tPalabras";
            this.tPalabras.Size = new System.Drawing.Size(23, 22);
            this.tPalabras.Text = "Enviar Palabras";
            this.tPalabras.Click += new System.EventHandler(this.AñadirPalbrasToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.juegoToolStripMenuItem,
            this.palabrasToolStripMenuItem,
            this.sevidorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // juegoToolStripMenuItem
            // 
            this.juegoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mJugar,
            this.cancelarPartidaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.consultarRecordsToolStripMenuItem});
            this.juegoToolStripMenuItem.Name = "juegoToolStripMenuItem";
            this.juegoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.juegoToolStripMenuItem.Text = "Juego";
            // 
            // mJugar
            // 
            this.mJugar.Name = "mJugar";
            this.mJugar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mJugar.Size = new System.Drawing.Size(208, 22);
            this.mJugar.Tag = "getword";
            this.mJugar.Text = "Iniciar juego";
            this.mJugar.Click += new System.EventHandler(this.Jugar_Click);
            // 
            // cancelarPartidaToolStripMenuItem
            // 
            this.cancelarPartidaToolStripMenuItem.Name = "cancelarPartidaToolStripMenuItem";
            this.cancelarPartidaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.cancelarPartidaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.cancelarPartidaToolStripMenuItem.Text = "Cancelar partida";
            this.cancelarPartidaToolStripMenuItem.Click += new System.EventHandler(this.CancelarPartidaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 6);
            // 
            // consultarRecordsToolStripMenuItem
            // 
            this.consultarRecordsToolStripMenuItem.Name = "consultarRecordsToolStripMenuItem";
            this.consultarRecordsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.consultarRecordsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.consultarRecordsToolStripMenuItem.Tag = "getrecords";
            this.consultarRecordsToolStripMenuItem.Text = "Consultar records";
            this.consultarRecordsToolStripMenuItem.Click += new System.EventHandler(this.Getrecords_Click);
            // 
            // palabrasToolStripMenuItem
            // 
            this.palabrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirPalbrasToolStripMenuItem});
            this.palabrasToolStripMenuItem.Name = "palabrasToolStripMenuItem";
            this.palabrasToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.palabrasToolStripMenuItem.Text = "Palabras";
            // 
            // añadirPalbrasToolStripMenuItem
            // 
            this.añadirPalbrasToolStripMenuItem.Name = "añadirPalbrasToolStripMenuItem";
            this.añadirPalbrasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.añadirPalbrasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.añadirPalbrasToolStripMenuItem.Text = "Añadir palabras";
            this.añadirPalbrasToolStripMenuItem.Click += new System.EventHandler(this.AñadirPalbrasToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ltiempo
            // 
            this.ltiempo.AutoSize = true;
            this.ltiempo.Location = new System.Drawing.Point(151, 216);
            this.ltiempo.Name = "ltiempo";
            this.ltiempo.Size = new System.Drawing.Size(0, 13);
            this.ltiempo.TabIndex = 5;
            // 
            // textLetra
            // 
            this.textLetra.Enabled = false;
            this.textLetra.Location = new System.Drawing.Point(154, 128);
            this.textLetra.MaxLength = 1;
            this.textLetra.Name = "textLetra";
            this.textLetra.Size = new System.Drawing.Size(100, 20);
            this.textLetra.TabIndex = 3;
            // 
            // dibujoAhorcado1
            // 
            this.dibujoAhorcado1.Errores = 0;
            this.dibujoAhorcado1.Location = new System.Drawing.Point(391, 88);
            this.dibujoAhorcado1.MinimumSize = new System.Drawing.Size(100, 150);
            this.dibujoAhorcado1.Name = "dibujoAhorcado1";
            this.dibujoAhorcado1.Size = new System.Drawing.Size(228, 165);
            this.dibujoAhorcado1.TabIndex = 7;
            this.dibujoAhorcado1.Text = "dibujoAhorcado1";
            this.dibujoAhorcado1.Ahorcado += new System.EventHandler(this.DibujoAhorcado1_Ahorcado_1);
            // 
            // sevidorToolStripMenuItem
            // 
            this.sevidorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarIpYPuertoToolStripMenuItem});
            this.sevidorToolStripMenuItem.Name = "sevidorToolStripMenuItem";
            this.sevidorToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sevidorToolStripMenuItem.Text = "Sevidor";
            // 
            // cambiarIpYPuertoToolStripMenuItem
            // 
            this.cambiarIpYPuertoToolStripMenuItem.Name = "cambiarIpYPuertoToolStripMenuItem";
            this.cambiarIpYPuertoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.cambiarIpYPuertoToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.cambiarIpYPuertoToolStripMenuItem.Text = "Cambiar ip y puerto ";
            this.cambiarIpYPuertoToolStripMenuItem.Click += new System.EventHandler(this.CambiarIpYPuertoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Letras ya comprobadas: ";
            // 
            // lcomprobados
            // 
            this.lcomprobados.AutoSize = true;
            this.lcomprobados.Location = new System.Drawing.Point(154, 240);
            this.lcomprobados.Name = "lcomprobados";
            this.lcomprobados.Size = new System.Drawing.Size(0, 13);
            this.lcomprobados.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.sendword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 277);
            this.Controls.Add(this.lcomprobados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLetra);
            this.Controls.Add(this.ltiempo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Jugar);
            this.Controls.Add(this.dibujoAhorcado1);
            this.Controls.Add(this.labelLetra);
            this.Controls.Add(this.sendword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sendword;
        private System.Windows.Forms.Label labelLetra;
        private DibujoAhorcado.DibujoAhorcado dibujoAhorcado1;
        private System.Windows.Forms.Button Jugar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tJugar;
        private System.Windows.Forms.ToolStripButton tRecords;
        private System.Windows.Forms.ToolStripButton tPalabras;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem juegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mJugar;
        private System.Windows.Forms.ToolStripMenuItem cancelarPartidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palabrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirPalbrasToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ltiempo;
        private System.Windows.Forms.TextBox textLetra;
        private System.Windows.Forms.ToolStripMenuItem sevidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarIpYPuertoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lcomprobados;
    }
}

