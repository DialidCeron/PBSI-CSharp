using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.ForeColor = Color.Black;
            label1.Font = new Font("Times New Roman", 20);
        }
        public void clearColor()
        {
            negroToolStripMenuItem.Checked = false;
            azulToolStripMenuItem.Checked= false;
            verdeToolStripMenuItem.Checked = false;
        }
        public void clearFont()
        {
            timesNewRomanToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
            comicSansToolStripMenuItem.Checked = false;
        }
        private void cambiarTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = Interaction.InputBox("Ingresa una cadena", "Cambiar texto");
        }

        private void créditosF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hecho por Dialid");
        }

        private void salirAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            label1.ForeColor = Color.Black;
            negroToolStripMenuItem.Checked = true;
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            label1.ForeColor = Color.Blue;
            azulToolStripMenuItem.Checked = true;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            label1.ForeColor = Color.Green;
            verdeToolStripMenuItem.Checked = true;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFont();
            label1.Font = new Font("Times New Roman", 20);
            timesNewRomanToolStripMenuItem.Checked = true;
        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFont();
            label1.Font = new Font("Comic Sans MS", 20);
            comicSansToolStripMenuItem.Checked = true;
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFont();
            label1.Font = new Font("Courier", 20);
            courierToolStripMenuItem.Checked = true;
        }
    }
}
