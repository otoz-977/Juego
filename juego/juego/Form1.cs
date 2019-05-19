using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using juego.Classes;

namespace juego
{
    public partial class Form1 : Form
    {
        int C = 0;
        int S = 0;
        string palabra;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_control read = new main_control(S,C);
          
            palabra =read.text(C);

            textBox1.Text = palabra;
            C++;
        
        }
    }
}
