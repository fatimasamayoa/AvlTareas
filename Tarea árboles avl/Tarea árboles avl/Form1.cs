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

namespace Tarea_árboles_avl
{
    public partial class Form1 : Form
    {
        ArbolAVL MiArbolAvl = new ArbolAVL();



        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\HP\\Desktop\\PROGRAM III\\Tarea árboles avl\\Tarea árboles avl\\txtArchivo.txt");
            Char delimiter = ',';
            while ((line = file.ReadLine()) != null)
            {
                String[] substrings = line.Split(delimiter);
                ProyectosInversion ObjDato = new ProyectosInversion (Convert.ToDecimal(substrings[0]), substrings[1], substrings[2], substrings[3]);

                MiArbolAvl.insertar(ObjDato);
                counter++;
            }
            file.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProyectosInversion ObjDatoBuscado = new ProyectosInversion(Convert.ToDecimal(textBox1.Text), " ", " ", " ");
            MiArbolAvl.buscar(ObjDatoBuscado);
            ProyectosInversion ObjDatoEncontrado = (ProyectosInversion)MiArbolAvl.buscar(ObjDatoBuscado).valorNodo();
            textBox2.Text = ObjDatoEncontrado.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox4.Text == "Chiquimula")
            {
                MessageBox.Show("El número de prioridad es 1, ingréselo");
            }
            else
            {
                if (textBox4.Text == "Zacapa")
                {
                    MessageBox.Show("El número de prioridad es 2, ingréselo");
                }
                else
                {
                    if (textBox4.Text == "El Progreso")
                    {
                        MessageBox.Show("El número de prioridad es 3, ingréselo");
                    }
                    else
                    {
                        if (textBox4.Text == "Alta Verapaz")
                        {
                            MessageBox.Show("El número de prioridad es 4, ingréselo");
                        }
                        else
                        {
                            if (textBox4.Text == "Baja Verapaz")
                            {
                                MessageBox.Show("El número de prioridad es 5, ingréselo");
                            }
                            else
                            {
                                if (textBox4.Text == "Guatemala")
                                {
                                    MessageBox.Show("El número de prioridad es 6, ingréselo");
                                }
                            }
                        }
                    }
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            using (StreamWriter writer = new StreamWriter("C:\\Users\\HP\\Desktop\\PROGRAM III\\Tarea árboles avl\\Tarea árboles avl\\txtArchivo.txt"))
            {
                writer.WriteLine(string.Format("{0},{1},{2},{3},{4}", textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text));
            }
        }
    }
}
