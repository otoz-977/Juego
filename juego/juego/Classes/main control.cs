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
        public main_control(int _S, int _C)
        {
             S = _S;
             C = _C;

        }



        public string main()
        {
           List<string> scene = new List<string>();
           scene.Add("scenes_2_file");
           scene.Add("scenes_1_text");
            

            Texto text = new Texto(scene[S]);
            return text.text(C);
        }

    }
}
