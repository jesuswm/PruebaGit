namespace PruebaGrafico
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grafico2 = new GráficoDeBarras.Grafico();
            this.grafico1 = new GráficoDeBarras.Grafico();
            this.SuspendLayout();
            // 
            // grafico2
            // 
            this.grafico2.ColorLinea = System.Drawing.Color.Sienna;
            this.grafico2.Ejex = "Ejex";
            this.grafico2.Ejey = "Ejey";
            this.grafico2.Location = new System.Drawing.Point(541, 55);
            this.grafico2.MaxEjey = 100F;
            this.grafico2.Modo = GráficoDeBarras.Modo.automatico;
            this.grafico2.Name = "grafico2";
            this.grafico2.Size = new System.Drawing.Size(227, 168);
            this.grafico2.TabIndex = 1;
            this.grafico2.Text = "grafico2";
            this.grafico2.Tipo = GráficoDeBarras.Tipo.lineas;
            this.grafico2.Valores = ((System.Collections.Generic.List<int>)(resources.GetObject("grafico2.Valores")));
            // 
            // grafico1
            // 
            this.grafico1.ColorLinea = System.Drawing.Color.BlueViolet;
            this.grafico1.Ejex = "";
            this.grafico1.Ejey = "Kilometros hora y segundo a la menos 1";
            this.grafico1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grafico1.Location = new System.Drawing.Point(45, 27);
            this.grafico1.MaxEjey = 150F;
            this.grafico1.Modo = GráficoDeBarras.Modo.manual;
            this.grafico1.Name = "grafico1";
            this.grafico1.Size = new System.Drawing.Size(472, 382);
            this.grafico1.TabIndex = 0;
            this.grafico1.Text = "grafico1";
            this.grafico1.Tipo = GráficoDeBarras.Tipo.barras;
            this.grafico1.Valores = ((System.Collections.Generic.List<int>)(resources.GetObject("grafico1.Valores")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grafico2);
            this.Controls.Add(this.grafico1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Graficos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GráficoDeBarras.Grafico grafico1;
        private GráficoDeBarras.Grafico grafico2;
    }
}

