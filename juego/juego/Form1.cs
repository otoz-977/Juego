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
    
        string palabra;
   
        public Form1()
        {
            InitializeComponent();
        }
        main_control read = new main_control();
        private void button1_Click(object sender, EventArgs e)
        {
            
          
            palabra =read.main();

            textBox1.Text = palabra;
        
        
        }
    }
}
