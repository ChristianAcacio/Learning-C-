using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo02.Modelos
{
    public class Cachorros
    {
        
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Cor { get; set; }

        public void Latir(){
            Console.WriteLine("AUAUAU!");
        }
        



    }
}