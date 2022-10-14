using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MittFörstaFönster
{
    public partial class Form1 : Form
    {
        private int antalKlick = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pizzaKnapp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mmm, vad gott!");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            antalKlick++;

            counterLabel.Text = $"Du har ätit {antalKlick} pizzor";
        }
    }
}
