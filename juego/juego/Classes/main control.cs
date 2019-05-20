using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego.Classes
{
    class main_control
    {
        int S, C;
        string[] choices;
        bool Choices;
        int select = 0;
        //cuenta las escenas;
        public main_control()
        {
             S = 0;
             C = 0;
        }



        public string main(int Slc)
        {
           List<string> scene = new List<string>();
           scene.Add("scenes_1_text");
           scene.Add("scenes_2_file");
           scene.Add("scenes_3_file");
           scene.Add("scenes_4_text");



            
            Texto text = new Texto(scene[S]);
            
            
            string done =text.text(C);

            if(done =="")
            {
                S++;
                C = 0;
                done = ".....";
            }

            if(text.Getquest == false)
            {
                Choices = false;

            }
            else
            {
                Choices = true;
                done.Trim('@');
                choices = done.Split('/');
               
                S = int.Parse(choices[Slc]);
                C = 0;
            }

            C++;
            return done;
        }

        public bool choice
        {
            get { return Choices; }

            
        }
        public string[] Ctext
        {
            
            get { return choices; }

            
        }





    }
}
