using System;
using System.IO;
using System.Windows.Forms;

namespace ArchivoDeTexto1
{
    public partial class Form1 : Form
    {
        Persona[] p;
        public Form1()
        {
            InitializeComponent();
            p = new Persona[5];
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            if(dialogo.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(dialogo.FileName);
                {
                    try
                    {
                        // Create an instance of StreamReader to read from a file.
                        // The using statement also closes the StreamReader.
                        using (StreamReader sr = new StreamReader("TestFile.txt"))
                        {
                            string line;
                            // Read and display lines from the file until the end of
                            // the file is reached.
                            while ((line = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    catch (Exception p)
                    {
                        // Let the user know what went wrong.
                        Console.WriteLine("The file could not be read:");
                        Console.WriteLine(p.Message);
                    }
                }
            }         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(dialogo.FileName);
                {
                    try
                    {
                        // Create an instance of StreamReader to read from a file.
                        // The using statement also closes the StreamReader.
                        using (StreamReader sr = new StreamReader("TestFile.txt"))
                        {
                            string line;
                            // Read and display lines from the file until the end of
                            // the file is reached.
                            while ((line = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    catch (Exception p)
                    {
                        // Let the user know what went wrong.
                        Console.WriteLine("The file could not be read:");
                        Console.WriteLine(p.Message);
                    }
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Persona n = new Persona();
            n.Nombre = txtNombre.Text;
            n.Edad = double.Parse(txtEdad.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

