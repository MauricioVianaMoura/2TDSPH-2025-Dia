using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Classes
{
    /// <summary>
    /// Classe Pessoa
    /// </summary>
    public class Person
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }

        /// <summary>
        /// Contrutor da classe
        /// </summary>
        public Person() { }

        public Person(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

    }
}
