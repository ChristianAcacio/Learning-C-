using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Armazenamento.Models
{
    public class Estoque
    {   
        //Constructor sem argumento
        public Estoque(){

        }

        //Construstor com argumento
        public Estoque(string NomeParametro, double ValorParametro, int QuantidadeParametro){
            Nome_ = NomeParametro;
            Valor_ = ValorParametro;
            Quantidade_ = QuantidadeParametro;
        }
        
        //Verificação e armasenamento do nome do produto
        private string Nome_;
        public string Nome{ 
            get{
                return Nome_;
            } 
            
            set{
                if(value == ""){
                    throw new ArgumentException("Preencha o nome do Produto");
                }
                Nome_ = value;
            }
        }

        //Verificação e armasenamento do valor do produto
        private double Valor_;
        public double Valor{ 
            get{
                return Valor_;
            }
            
            set{
                if(value <= 0){
                    throw new ArgumentException("O valor do produto Tem que ser maior que zero");
                }
                Valor_ = value;
            } 
        }

        //Verificação e armasenamento quantidade do produto
        private int Quantidade_;
        public int Quantidade{ 
            get{
                return Quantidade_;
            } 
            
            set{
                if(value <= 0){
                    throw new ArgumentException("Coloque pelo menos um produto");
                }
                Quantidade_ = value;
            }
        }










        private List<Produto> Produtos = new List<Produto>();

        public void Exibir(){
            
            if(Produtos.Count == 0){
                Console.WriteLine("O estoque está vazio");
                return;
            }


            for(int i=0; i<Produtos.Count; i++){
                Console.Write($"{i+1}º {Produtos[i]}");
            }
        }


        public void Adicionar(Produto Produto){
            Produtos.Add(Produto);
            Console.WriteLine("Produto adicionado com sucesso");
        }


















    }
}