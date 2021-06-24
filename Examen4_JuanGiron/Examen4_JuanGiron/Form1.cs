using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen4_JuanGiron
{
    public partial class Form1 : Form
    {
        ArrayList Arreglo1;
        ArrayList Arreglo2;

        public Form1()
        {
            InitializeComponent();
            Arreglo1 = new ArrayList();
            Arreglo2 = new ArrayList();
        }

        string N;
        string ED;

        private void button1_Click(object sender, EventArgs e)
        {

            if (Nombre_textBox.Text == "" || Edad_textBox.Text == "")
            {

                MessageBox.Show("Campos Vacios");

            }
            else
            {

                Arreglo1.Add(Nombre_textBox.Text.ToString());
                Arreglo2.Add(Edad_textBox.Text.ToString());

                for (int i = 0; i < Arreglo1.Count; i++)
                {
                    N = Arreglo1[i].ToString();

                }

                for (int E = 0; E < Arreglo2.Count; E++)
                {

                    ED = Arreglo2[E].ToString();

                }

                comboBox1.Items.Add("Nombre: " + N + " Edad: " + ED);

                Nombre_textBox.Clear();
                Nombre_textBox.Focus();
                Edad_textBox.Clear();

            }


        }

    }
}
