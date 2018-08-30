using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Day8
    {
        private Day8() { }

        

        public static void Dictionaries()
        {
            int numEntries = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            List<String> person = new List<String>();
            string key, value;

            for (int i = 0; i < numEntries; i++)
            {
                String[] contact = Console.ReadLine().Split(' ');
                phonebook.Add(contact[0], contact[1]);
            }
            //while user wants to continue searching contacts


            while ((key = Console.ReadLine()) != null && key != "")
            {
                person.Add(key);
            }

            foreach(string p in person)
            {
                if (phonebook.TryGetValue(p, out value))
                    Console.WriteLine($"{p}={value}");
                else
                    Console.WriteLine("Not found");
                
            }
                
            
        }

    }
}
