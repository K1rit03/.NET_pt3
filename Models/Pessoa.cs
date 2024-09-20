using System;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa(){

        }     
        public Pessoa(string nome, string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome; 

        public string Nome 
        { 
            get => _nome.ToUpper();
             
            set 
            {
                if (value == "") 
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value; // 
            } 
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); 

        private int _idade;
        public int Idade 
        { 
                get{
                    return _idade;
                } 
                set
                {
                    if (value < 0){
                        throw new ArgumentException("O numero não pode ser negativo");
                    } 
                    _idade = value;   
                }
            } 

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, idade: {Idade}");
        }  
    }
}
