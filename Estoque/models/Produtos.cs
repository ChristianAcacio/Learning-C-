using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Estoque.models;

namespace Produtos.models
{
    public class Produtos : Estoque
    {
        
        //Verificação e armazenamento do Nome do produto
        private string Nome_;
        public string Nome { 
            get{
                return Nome_;
            }

            set{
                if(value == ""){
                    throw new ArgumentException("Preencha o Nome do seu produto");
                }
                Nome_ = value;
            } 
        }

        //Verificação e armazenamento do preço do produto
        private double Preço_;
        public double Preço{ 
            get{
                return Preço_;
            } 
            
            set{
                if(value <= 0){
                    throw new ArgumentException("O preço do Su produto tem que ser maior que zero");
                }
                Preço_ = value;
            } 
        }

        //Verificação e armazenamento da quantidade do produto
        private int Quantidade_;
        public int Quantidade{
            get{
                return Quantidade_;
            }

            set{
                if(value <= 0){
                    throw new ArgumentException("Adicione pelomenos um produto");
                }
                Quantidade_ = value;
            }
        }






     








    }
}