using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaidimasGitHub
{
    class Zmog : IZaidimas
    {
        public int ataka
        { get ; set ; }
        public int gyvybes { get ; set ; }
        public string charName { get ; set ; }


       public void Atakuoti()
        {
            Console.WriteLine("Ataka");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Zmog zmogus = new Zmog();
            zmogus.Atakuoti();
        }
    }
}
