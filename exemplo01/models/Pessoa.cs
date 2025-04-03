using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//caminho da classe
namespace exemplo01.models
{

    //OBS IMPORTANTE: Sempre que for passar uma nova classe tem que ser com a primeira letra maiúscula, Nome das pastas tbm;
    //classe
    public class Pessoa{
        //Atributos
        public string? Nome { get; set; }
        public int Idade { get; set; }

        //Metodos
        public void Apresentar(){

            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos!");

        }

    }
}