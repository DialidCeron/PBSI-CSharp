using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public string user = "dialid";
        public string pass = "hola123.,";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string password = textBox2.Text;
            if (user == usuario && pass == password)
                MessageBox.Show("Bienvenido");
            else
                MessageBox.Show("Usuario o contraseña incorrectos");
        }
    }
}
