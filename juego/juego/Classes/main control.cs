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
       
        //cuenta las escenas;
        public main_control()
        {
             S = 0;
             C = 0;

        }



        public string main()
        {
           List<string> scene = new List<string>();
           scene.Add("scenes_1_text");
           scene.Add("scenes_2_file");
           
            

            Texto text = new Texto(scene[S]);
            string done =text.text(C);

            if(done =="")
            {
                S++;
                C = 0;
            }

            C++;
            return done;
        }

    }
}
