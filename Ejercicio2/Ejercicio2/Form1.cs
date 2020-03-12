
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    button1.BackColor = Color.Aqua;
                    break;
                case MouseButtons.Right:
                    button2.BackColor = Color.Aqua;
                    break;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    button1.BackColor = default;
                    break;
                case MouseButtons.Right:
                    button2.BackColor = default;
                    break;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            #if a
            foreach(Control cont in this.Controls)
            {
                if(cont.GetType()==typeof(TextBox))
                {
                    System.Diagnostics.Debug.WriteLine(cont.Name);
                }
            }
            #endif
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Texto.Text.Trim()!= "") {
                list.Items.Add(Texto.Text);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection indices = list.SelectedIndices;
            System.Diagnostics.Debug.WriteLine(indices.Count);
            for (int i=indices.Count-1; i>=0;i--)
            {
                list.Items.RemoveAt(indices[i]);
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                System.Diagnostics.Debug.WriteLine(((RadioButton)sender).Text);
            }
        }
    }
}
