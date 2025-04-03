using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo03.moldels
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        //Ali nos parametros coloque onde quero colocar e oque quero colocar no caso colocar alunos na lista de pessoas
        public void AdicionarALuno(Pessoa Aluno){
            Alunos.Add(Aluno);
        }

        public int QuanditadeDeAlunos(){
            int Quantidade = Alunos.Count;
            return Quantidade;
        }

        public void RemoverAluno(Pessoa Aluno){
            Alunos.Remove(Aluno);
        }

        public void ListarAlunos(){
            foreach(Pessoa Aluno in Alunos){
                Console.WriteLine(Aluno.NomeCompleto);
            }
        }
    }
}