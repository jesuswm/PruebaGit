namespace Tema4_Form_Ejercicio5
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
            this.listaI = new System.Windows.Forms.ListBox();
            this.listaD = new System.Windows.Forms.ListBox();
            this.beliminar = new System.Windows.Forms.Button();
            this.traspasarDI = new System.Windows.Forms.Button();
            this.traspasarID = new System.Windows.Forms.Button();
            this.bañadir = new System.Windows.Forms.Button();
            this.tbox = new System.Windows.Forms.TextBox();
            this.Elementos = new System.Windows.Forms.Label();
            this.Indices = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // listaI
            // 
            this.listaI.FormattingEnabled = true;
            this.listaI.Location = new System.Drawing.Point(129, 46);
            this.listaI.Name = "listaI";
            this.listaI.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listaI.Size = new System.Drawing.Size(120, 95);
            this.listaI.TabIndex = 0;
            this.toolTip1.SetToolTip(this.listaI, "Lista Izquierda");
            this.listaI.SelectedIndexChanged += new System.EventHandler(this.ListaI_SelectedIndexChanged);
            // 
            // listaD
            // 
            this.listaD.FormattingEnabled = true;
            this.listaD.Location = new System.Drawing.Point(408, 46);
            this.listaD.Name = "listaD";
            this.listaD.Size = new System.Drawing.Size(120, 95);
            this.listaD.TabIndex = 1;
            // 
            // beliminar
            // 
            this.beliminar.Location = new System.Drawing.Point(26, 69);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(75, 23);
            this.beliminar.TabIndex = 2;
            this.beliminar.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.beliminar, "Elimina los componentes seleccionados en la lista de la izquierda");
            this.beliminar.UseVisualStyleBackColor = true;
            this.beliminar.Click += new System.EventHandler(this.Beliminar_Click);
            // 
            // traspasarDI
            // 
            this.traspasarDI.Location = new System.Drawing.Point(297, 69);
            this.traspasarDI.Name = "traspasarDI";
            this.traspasarDI.Size = new System.Drawing.Size(75, 23);
            this.traspasarDI.TabIndex = 3;
            this.traspasarDI.Text = "=>";
            this.toolTip1.SetToolTip(this.traspasarDI, "Traspasa los valores seleccionados de la izquierda a la derecha");
            this.traspasarDI.UseVisualStyleBackColor = true;
            this.traspasarDI.Click += new System.EventHandler(this.TraspasarDI_Click);
            // 
            // traspasarID
            // 
            this.traspasarID.Location = new System.Drawing.Point(297, 98);
            this.traspasarID.Name = "traspasarID";
            this.traspasarID.Size = new System.Drawing.Size(75, 23);
            this.traspasarID.TabIndex = 4;
            this.traspasarID.Text = "<=";
            this.toolTip1.SetToolTip(this.traspasarID, "Traspasa los valores seleccionados de la derecha a la izquierda");
            this.traspasarID.UseVisualStyleBackColor = true;
            this.traspasarID.Click += new System.EventHandler(this.TraspasarID_Click);
            // 
            // bañadir
            // 
            this.bañadir.Location = new System.Drawing.Point(408, 185);
            this.bañadir.Name = "bañadir";
            this.bañadir.Size = new System.Drawing.Size(75, 23);
            this.bañadir.TabIndex = 5;
            this.bañadir.Text = "Añadir";
            this.toolTip1.SetToolTip(this.bañadir, "Añade el valor del texbox en la lista de la izquierda");
            this.bañadir.UseVisualStyleBackColor = true;
            this.bañadir.Click += new System.EventHandler(this.Bañadir_Click);
            // 
            // tbox
            // 
            this.tbox.Location = new System.Drawing.Point(253, 185);
            this.tbox.Name = "tbox";
            this.tbox.Size = new System.Drawing.Size(100, 20);
            this.tbox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.tbox, "TexBox en el que introducimos el texto que queremos añadir a la lista de la izqui" +
        "erad");
            // 
            // Elementos
            // 
            this.Elementos.AutoSize = true;
            this.Elementos.Location = new System.Drawing.Point(158, 30);
            this.Elementos.Name = "Elementos";
            this.Elementos.Size = new System.Drawing.Size(68, 13);
            this.Elementos.TabIndex = 7;
            this.Elementos.Text = "Elementos: 0";
            this.toolTip1.SetToolTip(this.Elementos, "Numero de elementos en la lista de la izquierda");
            // 
            // Indices
            // 
            this.Indices.AutoSize = true;
            this.Indices.Location = new System.Drawing.Point(126, 144);
            this.Indices.Name = "Indices";
            this.Indices.Size = new System.Drawing.Size(41, 13);
            this.Indices.TabIndex = 8;
            this.Indices.Text = "Indices";
            this.toolTip1.SetToolTip(this.Indices, "Indices seleccionados en la lista de la izquierda");
            // 
            // timer
            // 
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Indices);
            this.Controls.Add(this.Elementos);
            this.Controls.Add(this.tbox);
            this.Controls.Add(this.bañadir);
            this.Controls.Add(this.traspasarID);
            this.Controls.Add(this.traspasarDI);
            this.Controls.Add(this.beliminar);
            this.Controls.Add(this.listaD);
            this.Controls.Add(this.listaI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaI;
        private System.Windows.Forms.ListBox listaD;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button traspasarDI;
        private System.Windows.Forms.Button traspasarID;
        private System.Windows.Forms.Button bañadir;
        private System.Windows.Forms.TextBox tbox;
        private System.Windows.Forms.Label Elementos;
        private System.Windows.Forms.Label Indices;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

