using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaDi2ec
{
    public enum eSexo
    {
        Hombre, Mujer
    }
    public enum eAficion
    {
        Manga, SciFi, RPG, Fantasia, Terror, Tecnologia
    }

    public struct sFriki
    {
        private string nombre;
        private int edad;
        private eAficion aficion;
        private eSexo sexo;
        private eSexo sexoOpuesto;
        public String Foto;

        public sFriki(string nombre, int edad, eAficion aficion, eSexo sexo, eSexo sexoOpuesto, string foto)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.aficion = aficion;
            this.sexo = sexo;
            this.sexoOpuesto = sexoOpuesto;
            Foto = foto;
        }

        
    }
    public partial class Form1 : Form
    {
        private List<sFriki> sFrikis=new List<sFriki>();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        

        private void Añadir_Click(object sender, EventArgs e)
        {
            FormModal formModal = new FormModal();
            if(DialogResult.OK==formModal.ShowDialog())
            {
                sFrikis.Add(new sFriki(formModal.nombre.TextB, Convert.ToInt32(formModal.edad.TextB), eAficion.Fantasia, formModal.Masculino.Checked==true?eSexo.Hombre:eSexo.Mujer, formModal.Omasculino.Checked == true ? eSexo.Hombre : eSexo.Mujer, formModal.textBox1.Text));
                listBox1.Items.Add(formModal.nombre.TextB);
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection indices = listBox1.SelectedIndices;
            for(int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                if (indices.Contains(i))
                {
                    listBox1.Items.RemoveAt(i);
                    sFrikis.RemoveAt(i);
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            String titulo = "FrikiLove Inc";
            if (titulo.Length == Text.Length)
            {
                Text = "";
            }
            else
            {
               Text=Text+titulo[Text.Length];
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(listBox1.SelectedIndex);
            if (listBox1.SelectedIndex != -1)
            {
                pictureBox1.Image = new Bitmap(sFrikis[listBox1.SelectedIndex].Foto);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
    }
}
