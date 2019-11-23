using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypton
{
    class Program
    {
        static void Main(string[] args)
        {
            string messageTxt = "Mb'qsph'd'ftu'm(gvo";
            string NouveauMessage = "";

            for (int i = 0; i<messageTxt.Length; i++)
            {
                int valeurAsc = (int)messageTxt[i];
                NouveauMessage += Char.ConvertFromUtf32(valeurAsc - 1);
            }
            Console.WriteLine(NouveauMessage);
            Console.ReadLine();        }
    }
}
