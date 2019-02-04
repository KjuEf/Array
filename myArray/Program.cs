using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string [] name = new string[4];
            name[0] = "name 1";
            name[1] = "name 2";
            name[2] = "name 3";
            name[3] = "name 4";


            for (int i = 0; i<name.Length ; i++)
            {
                Console.WriteLine(name[i]);
            }*/

            /* string[] myName = new string[5];
             myName[0] = "name1";
             myName[1] = "name2";
             myName[2] = "name3";
             myName[3] = "name4";
             myName[4] = "name5";

             for (int i= 0; i < myName.Length; i++)
             {
                 Console.WriteLine(myName[i]);
             }*/

            /*string[] myName = new string[5];
           


            for (int x = 0; x < myName.Length; x++)
            {
                myName[x]=Console.ReadLine();
            }
            for (int i = 0; i < myName.Length; i++)
            {
                Console.WriteLine(myName[i]);
            }*/
            //Upises vrijednost [5] sa for//

            List<int> name = new List<int>();

            name.Add(22);
            name.Add(25);

            Console.WriteLine(name[0]);

            Console.ReadKey();
        }
    }
}
