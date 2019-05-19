using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;


namespace juego.Classes
{
    class Texto
    {
        string SCn;
        
        public Texto(string scn)
        {
            SCn = scn;
            
        }

        public string text(int C)
        {
            string line = juego.Properties.Resources.ResourceManager.GetString(SCn);
            string[] result = line.Split('#');
            

            if(C < result.Length)
            {
                string res = result[C];
                return res;
            }
            else
            {
                return "null";
            }
            
        }


    }
}
