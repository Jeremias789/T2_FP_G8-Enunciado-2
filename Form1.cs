using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado_2._1
{
    public partial class Form1 : Form
    {
        private List<int> G8_numeros = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int G8_numero = int.Parse(textBoxNumero.Text);
                G8_numeros.Add(G8_numero);
                MostrarLista();
                textBoxNumero.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonOrdenarAsc_Click(object sender, EventArgs e)
        {
            G8_numeros.Sort();
            MostrarLista();  // Actualizar la lista mostrada 
        }

        private void buttonOrdenarDesc_Click(object sender, EventArgs e)
        {
            G8_numeros.Sort((a, b) => b.CompareTo(a));
            MostrarLista();  // Actualizar la lista mostrada 
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int G8_numero = int.Parse(textBoxNumero.Text);
                int G8_indice = G8_numeros.IndexOf(G8_numero);
                if (G8_indice != -1)
                {
                    MessageBox.Show($"Número encontrado en la posición: {G8_indice}");
                }
                else
                {
                    MessageBox.Show("Número no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int G8_numero = int.Parse(textBoxNumero.Text);
                if (G8_numeros.Remove(G8_numero))
                {
                    MessageBox.Show("Número eliminado.");
                }
                else
                {
                    MessageBox.Show("Número no encontrado.");
                }
                MostrarLista();  // Actualizar la lista mostrada
                textBoxNumero.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void MostrarLista()
        {
            listBoxNumeros.Items.Clear();  // Limpiar el ListBox
            foreach (var num in G8_numeros)
            {
                listBoxNumeros.Items.Add(num);  // Agregar cada número al ListBox
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
