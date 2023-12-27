using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Program
    {     
        
        //INDEXER
        private String[] Festival = new String[100];
        public string this[int indexer]
        {
            get => Festival[indexer];
            set => Festival[indexer] = value;
        }



        static void Main(string[] args)
        {
            Program p = new Program();
            p[0] = "Diwali";
            p[1] = "gudi Padwa";
            p[2] = "Ram Navani";

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(p[i]);
            }

        }
}
}
