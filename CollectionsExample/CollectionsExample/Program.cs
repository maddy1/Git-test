using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList(3);  
    
        
            al.Add(11);
            al.Add("Aloha");
            al.Add(2);
            Console.WriteLine("initialSize:" + al.Capacity);
            al.Add("Madhuri");
            Console.WriteLine("FinalSize:" + al.Capacity);
            Console.WriteLine("ListExample");
            Console.ReadLine();
           var Names  = new List<string> { "Madhuri", "Aloha", "Sarha", "Neel"};
            Names.Remove("Neel");
            Names.Add("MMMM");

           foreach (var Name in Names)
           {
               Console.Write(Name + " ");
           }
                
             Console.ReadLine();
        }
        
    }
}
