namespace PracticaDi2ec
{
    partial class FormModal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombre = new ValidateTextBox.UserControl1();
            this.edad = new ValidateTextBox.UserControl1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Masculino = new System.Windows.Forms.RadioButton();
            this.Femenino = new System.Windows.Forms.RadioButton();
            this.Omasculino = new System.Windows.Forms.RadioButton();
            this.Ofemenino = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(147, 70);
            this.nombre.Multiline = false;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(120, 40);
            this.nombre.TabIndex = 0;
            this.nombre.TextB = "";
            this.nombre.Tipo = ValidateTextBox.eTipo.Texto;
            // 
            // edad
            // 
            this.edad.Location = new System.Drawing.Point(147, 116);
            this.edad.Multiline = false;
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(120, 40);
            this.edad.TabIndex = 1;
            this.edad.TextB = "";
            this.edad.Tipo = ValidateTextBox.eTipo.Numero;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Femenino);
            this.groupBox1.Controls.Add(this.Masculino);
            this.groupBox1.Location = new System.Drawing.Point(500, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Ofemenino);
            this.groupBox2.Controls.Add(this.Omasculino);
            this.groupBox2.Location = new System.Drawing.Point(500, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SexoOpuesto";
            // 
            // Masculino
            // 
            this.Masculino.AutoSize = true;
            this.Masculino.Checked = true;
            this.Masculino.Location = new System.Drawing.Point(7, 20);
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(85, 17);
            this.Masculino.TabIndex = 0;
            this.Masculino.TabStop = true;
            this.Masculino.Text = "radioButton1";
            this.Masculino.UseVisualStyleBackColor = true;
            // 
            // Femenino
            // 
            this.Femenino.AutoSize = true;
            this.Femenino.Location = new System.Drawing.Point(7, 44);
            this.Femenino.Name = "Femenino";
            this.Femenino.Size = new System.Drawing.Size(85, 17);
            this.Femenino.TabIndex = 1;
            this.Femenino.Text = "radioButton2";
            this.Femenino.UseVisualStyleBackColor = true;
            // 
            // Omasculino
            // 
            this.Omasculino.AutoSize = true;
            this.Omasculino.Checked = true;
            this.Omasculino.Location = new System.Drawing.Point(7, 20);
            this.Omasculino.Name = "Omasculino";
            this.Omasculino.Size = new System.Drawing.Size(85, 17);
            this.Omasculino.TabIndex = 0;
            this.Omasculino.TabStop = true;
            this.Omasculino.Text = "radioButton3";
            this.Omasculino.UseVisualStyleBackColor = true;
            // 
            // Ofemenino
            // 
            this.Ofemenino.AutoSize = true;
            this.Ofemenino.Location = new System.Drawing.Point(7, 44);
            this.Ofemenino.Name = "Ofemenino";
            this.Ofemenino.Size = new System.Drawing.Size(85, 17);
            this.Ofemenino.TabIndex = 1;
            this.Ofemenino.Text = "radioButton4";
            this.Ofemenino.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(192, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(500, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Foto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "edad";
            // 
            // FormModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.nombre);
            this.Name = "FormModal";
            this.Text = "FormModal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public ValidateTextBox.UserControl1 nombre;
        public ValidateTextBox.UserControl1 edad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RadioButton Femenino;
        public System.Windows.Forms.RadioButton Masculino;
        public System.Windows.Forms.RadioButton Ofemenino;
        public System.Windows.Forms.RadioButton Omasculino;
        public System.Windows.Forms.TextBox textBox1;
    }
}