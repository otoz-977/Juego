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
        
        int selected = 0;
   
        public Form1()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            InitializeComponent();
        }
        main_control read = new main_control();
        private void button1_Click(object sender, EventArgs e)
        {
            int selected = 0;
            selected = Int32.Parse(Ans.Text);
            if(selected <=1)
            {
                selected = 2;
            }
                palabra =read.main(selected);
                panel1.Visible = false;
            
            

            textBox1.Text = palabra;
            
            if(read.choice == true)
            {
               

                panel1.Visible = true;
                choice_one.Text = read.Ctext[0];
                choice_two.Text = read.Ctext[1];

            }
            

        
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void choice_one_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void choice_two_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

   

}
