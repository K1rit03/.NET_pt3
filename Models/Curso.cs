using System;
using System.Collections.Generic;
using ExemploExplorando.Models;

namespace NET_pt3.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        // Construtor para inicializar a lista de alunos
        public Curso()
        {
            Alunos = new List<Pessoa>();
        }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int AlunoMatriculado()
        {
            // Pega a quantidade de alunos matriculados
            return Alunos.Count;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}:");

            // Correção na formatação da string
            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = $"N° {count + 1}: {Alunos[count].NomeCompleto}";

                Console.WriteLine(texto);
            }

            // Alternativa usando foreach, se preferir:
            // foreach (Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine(aluno.NomeCompleto);
            // }
        }
    }
}
