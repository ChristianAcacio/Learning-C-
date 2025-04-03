using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo03.moldels
{
    public class Pessoa
    {
        
        //Construtor
        public Pessoa(){

        }
        

        //Modo de guardar um nome de forma segura
        //Alem disso tem uma validação de nomes válidos
        private string Nome_;
        public string Nome{ 
            get{
                return Nome_.ToUpper();
            } 

            set{
                if (value == ""){
                    throw new ArgumentException("O nome não pode ser vazio");   
                }
                Nome_ = value;
            }
        }



        //Modo de guardar uma idade de forma segura
        //Alem disso tem uma validação de idades válidas
        private int Idade_;
        public int Idade { 
            get{
                return Idade_;
            } 

            set{
                if(value <= 0 ){
                    throw new ArgumentException("Sua idade não pode ser negativa");
                }
                Idade_ = value;
            } 
        }

        //mesma coisa so que com sobre nome
        private string Sobrenome_;
        public string Sobrenome { 
            get{
                return Sobrenome_;
            } 
            
            set{
                if(value == ""){
                    throw new ArgumentException("O Sobrenome não pode estar vazio");
                }
                Sobrenome_ = value;
            } 
        }

        public string NomeCompleto{ 
            get{
                return $"{Nome_} {Sobrenome_}";
            }
        }










        
        public void apresentar(){

            Console.WriteLine($"Meu nome é {NomeCompleto} e tenho {Idade} anos!!!");    

        }


    }
}