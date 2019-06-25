using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicar_Herencias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //  List<casa> persona = new List<casa>();

        casa[] persona = new casa[5];
        int i = 0;
        private void AgregarPersona_Click(object sender, EventArgs e)
        {
            persona[i].Nombre = "Juan";
            persona[i].Edad = 15;
            persona[i].Direccion = "Privada Francisco villa";
            persona[i].Numerodecuenta = 20136710;
            i++;
            if (i > 1)
            {
                persona[i].Nombre = "pedro";
                persona[i].Edad = 31;
                persona[i].Direccion = "Guadalaja guadalajara";
                persona[i].Numerodecuenta = 20146451;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void AgregarACmb_Click(object sender, EventArgs e)
        {

            comboBox1.Items.Add(persona[i].Nombre+ " "+persona[i].Edad+ "  "+persona[i].Direccion+ " " +persona[i].Numerodecuenta);
        }

        private void AgregarAlistbox_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(persona[i].Nombre + " " + persona[i].Edad + "  " + persona[i].Direccion + " " + persona[i].Numerodecuenta);
        }
    }
}
