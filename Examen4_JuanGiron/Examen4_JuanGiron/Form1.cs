using System;
using System.Collections.Generic;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] Nombre;
            ushort CantidadNombre;

            Console.WriteLine("¿Cunatos nombre vas a introducir");

            CantidadNombre = UInt16.Parse(Console.ReadLine());
            do
            {


            } while (CantidadNombre <= 0);
            Nombre = new string[CantidadNombre];
        }
    }
}
