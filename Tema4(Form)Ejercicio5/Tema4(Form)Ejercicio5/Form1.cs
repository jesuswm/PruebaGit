using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_Form_Ejercicio5
{
    public partial class Form1 : Form
    {
        private Icon icono1 = new Icon("C:\\Users\\Jesus\\Downloads\\frame-square-button-symbol-of-interface-for-images_icon-icons.com_74281.ico");
        private Icon icono2= new Icon("C:\\Users\\Jesus\\Downloads\\Acrobat.ico");

        private String titulo;
        bool aux=false;
        public Form1()
        {
            InitializeComponent();
            titulo = Text;
            timer.Start();
            Icon = icono1;
            tooltipLD();
        }

        private void Bañadir_Click(object sender, EventArgs e)
        {
            if (tbox.Text.Trim() != "")
            {
                listaI.Items.Add(tbox.Text);
                actualizarLabelElementos();
            }
        }

        private void Beliminar_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection indices= listaI.SelectedIndices;
            for (int i= indices.Count-1;i>=0 ;i--)
            {
                listaI.Items.RemoveAt(indices[i]);
            }
            actualizarLabelElementos();
        }

        private void TraspasarDI_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection indices = listaI.SelectedIndices;
            for (int i = indices.Count - 1; i >= 0; i--)
            {
                listaD.Items.Insert(0,listaI.Items[indices[i]]);
            }
            Beliminar_Click(sender, e);
            actualizarLabelIndices();
            tooltipLD();
        }
        private void TraspasarID_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection indices = listaD.SelectedIndices;
            for (int i = indices.Count - 1; i >= 0; i--)
            {
                listaI.Items.Insert(0, listaD.Items[indices[i]]);
            }
            for (int i = indices.Count - 1; i >= 0; i--)
            {
                listaD.Items.RemoveAt(indices[i]);
            }
            actualizarLabelElementos();
            actualizarLabelIndices();
            tooltipLD();

        }
        private void actualizarLabelElementos()
        {
            Elementos.Text = "Elementos: "+Convert.ToString(listaI.Items.Count);
        }
        private void actualizarLabelIndices()
        {
            ListBox.SelectedIndexCollection indices = listaI.SelectedIndices;
            Indices.Text = "Indices: ";
            for (int i =  0; i < indices.Count; i++)
            {
                Indices.Text += Convert.ToString(indices[i])+" ";
            }
        }

        private void tooltipLD()
        {
            this.toolTip1.SetToolTip(this.listaD, "Lista derecha nº de elementos "+listaD.Items.Count);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (aux)
            {
                if (Icon.Equals(icono1))
                {
                    Icon = icono2;
                }
                else
                {
                    Icon = icono1;
                }
            }
            
            if (Text.Length==titulo.Length)
            {
                Text = "";
            }
            else
            {
                Text= Text.Insert(0, Convert.ToString(titulo[(titulo.Length - 1) - Text.Length]));
            }
            if (aux)
            {
                aux = false;
            }
            else
            {
                aux = true;
            }
        }

        private void ListaI_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarLabelIndices();
        }
    }
}
