using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CSFeatures
    {
        public static void Main()
        {
            Action<string> action = (string name) => { Console.WriteLine($"Hai {name}"); };
            Action<string, string> action1 = (string s1, string s2) => { Console.WriteLine($"Hai {s1}," +$"you said {s2}"); };

            action.Invoke("arusha");
            action1.Invoke("arusha", "am in blr");

            Action<int, string, string> printemp = (int id, string name, string email) =>
            {
                Console.WriteLine($"id={id}, name={name}, email={email}");
            };
            printemp(22795, "arusha", "arusha.g");
            HashSet<int> ids = new HashSet<int>();
            ids.Add(22793);
            ids.Add(22876);
            ids.Add(22793);
            ids.Add(22783);

            foreach (int id in ids)
                Console.WriteLine(id);

        }
    }

    
    

}
