using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DéKrypton
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "La_kryptonite_est_un_danger";
            string nouveauMessage = "";
            for (int i = 0; i < message.Length; i++)
            {
                int valeurAsc = (int)message[i];
                nouveauMessage += Char.ConvertFromUtf32(valeurAsc + 1);
            }
            Console.WriteLine(nouveauMessage);
        }
    }
}
