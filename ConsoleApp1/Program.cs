using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Run();
        }
        public void Run() { this.ReadTextFiles(); }

        public void ReadTextFiles()
        {
            using (StreamReader File = new StreamReader("U:/Users/731846/Beowulf.txt"))
            {
                int counter = 0;
                string ln;

                while((ln = File.ReadLine()) != null)
                {
                    counter++;
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }
                File.Close();

                Console.WriteLine($"File has {counter} lines.");
            }
        }

        
       
    }
}
