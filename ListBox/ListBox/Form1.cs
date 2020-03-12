using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        String titulo;
        public Form1()
        {
            InitializeComponent();
            titulo = this.Text;
            this.Text="";
            timer1.Start();
        }
        public void numeroDeItens()
        {
            NumeroItens.Text = "Nº de itens "+listBoxI.Items.Count+"";
        }
        public void actualizarIndice()
        {
            Indeces.Text = "Indices Seleccionados";
            foreach (int a in listBoxI.SelectedIndices)
            {
                Indeces.Text += " " + a;
            }
        }
        private void Añadir_Click(object sender, EventArgs e)
        {
            if (texto.Text.Trim()!="") {
                listBoxI.Items.Add(texto.Text);
            }
            else
            {
                MessageBox.Show("Mesaga dialog","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            numeroDeItens();
        }

        private void PasarD_Click(object sender, EventArgs e) {
            System.Windows.Forms.ListBox.SelectedIndexCollection a= listBoxI.SelectedIndices;
            for (int i=a.Count-1;i>=0;i--)
            {
                listBoxD.Items.Insert(0,listBoxI.Items[a[i]]);
                listBoxI.Items.RemoveAt(a[i]);
            }
            numeroDeItens();
            actualizarIndice();
        }

        private void ListBoxI_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarIndice();
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ListBox.SelectedIndexCollection a = listBoxI.SelectedIndices;
            for (int i = a.Count - 1; i >= 0; i--)
            {
                listBoxI.Items.RemoveAt(a[i]);
            }
            numeroDeItens();
            actualizarIndice();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Text.Length == titulo.Length)
            {
                Text = "";
            }
            else
            {
                Text=Text.Insert(0,titulo[titulo.Length-1-Text.Length]+"");
            }
        }

        private void PasarI_Click(object sender, EventArgs e)
        {
            if (listBoxD.SelectedIndex!=-1) {
                listBoxI.Items.Insert(0, listBoxD.Items[listBoxD.SelectedIndex]);
                listBoxD.Items.RemoveAt(listBoxD.SelectedIndex);
                numeroDeItens();
                actualizarIndice();
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show("Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                e.Cancel = true;
            }
        }
    }
}
