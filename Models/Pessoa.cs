using System;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome; 

        public string Nome 
        { 
            get
            {
                return _nome.ToUpper();
            } 
            set 
            {
                if (value == "") 
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value; // 
            } 
        }

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
            Console.WriteLine($"Nome: {Nome}, idade: {Idade}");
        }  
    }
}
