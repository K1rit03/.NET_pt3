using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploExplorando.Models;

namespace NET_pt3.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }
        public int AlunoMatriculado(){
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno){
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos(){
            Console.WriteLine($"Alunos do curso de {Nome} ");
            foreach (Pessoa Aluno in Alunos){
                Console.WriteLine(Aluno.NomeCompleto);
            }
        }
    }
}