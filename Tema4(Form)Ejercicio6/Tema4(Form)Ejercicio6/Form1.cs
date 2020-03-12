using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Tema4_Form_Ejercicio6
{
    public partial class Form1 : Form
    {
        private Form2 form2=new Form2();
        public Form1()
        {
            InitializeComponent();
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 12;
            int y = 60;
            String[] bot={ "1","2","3","4","5","6","7","8","9","*","0","#"};
            for (int i=0;i<bot.Length ; i++) {
                Button a = new Button();
                a.Location = new Point(x, y);
                a.Name = "button1";
                a.Size = new System.Drawing.Size(50, 25);
                a.TabIndex = i;
                a.Text = bot[i];
                a.Click += new System.EventHandler(PulsarAutoGenerados);
                a.MouseEnter += new System.EventHandler(AutoGenerados_MouseEnter);
                a.MouseLeave += new System.EventHandler(AutoGenerados_MouseLeave);
                a.UseVisualStyleBackColor = true;
                this.Controls.Add(a);
                x = x + 62;
                if ((i+1)%3==0 && i>0)
                {
                    x = 12;
                    y = y+37;
                }
                //System.Diagnostics.Debug.WriteLine(this.Controls.Count);
            }

        }
        private void PulsarAutoGenerados(object sender, EventArgs e)
        {
            pantalla.Text += ((Button)sender).Text;
            ((Button)sender).BackColor = Color.Aqua;
            ((Button)sender).MouseEnter -= new System.EventHandler(AutoGenerados_MouseEnter);
            ((Button)sender).MouseLeave -= new System.EventHandler(AutoGenerados_MouseLeave);
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            pantalla.Text = "";
            for (int i = 0; i < this.Controls.Count; i++)
            {
                //System.Diagnostics.Debug.WriteLine(""+this.Controls[i]);
                if (Controls[i].GetType().Equals(typeof(Button)))
                {
                    ((Button)Controls[i]).BackColor = default(Color);
                    ((Button)Controls[i]).MouseEnter -= new System.EventHandler(AutoGenerados_MouseEnter);
                    ((Button)Controls[i]).MouseLeave -= new System.EventHandler(AutoGenerados_MouseLeave);
                    ((Button)Controls[i]).MouseEnter += new System.EventHandler(AutoGenerados_MouseEnter);
                    ((Button)Controls[i]).MouseLeave += new System.EventHandler(AutoGenerados_MouseLeave);
                }
            }
        }

        private void AutoGenerados_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Aquamarine;
        }

        private void AutoGenerados_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor =default(Color);
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GrabarNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pantalla.TextLength>0) {
                if (!(DialogResult.Cancel == openFileDialog1.ShowDialog())) {
                    //System.Diagnostics.Debug.WriteLine(openFileDialog1.FileName);
                    using (StreamWriter writer = new StreamWriter(openFileDialog1.FileName))
                    {
                        writer.WriteLine(pantalla.Text);
                        MessageBox.Show("El numero se ha grabado correctamente", "Numero Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede proceder a guardar hasta que se introduzca un numero", "Numero vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
