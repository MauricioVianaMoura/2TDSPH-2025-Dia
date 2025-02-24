using System;
using System.Globalization;
using System.Collections.Generic;
using ConsoleApp1.Classes;


namespace ConsoleApp1
{
    /// <summary>
    /// Classe Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Método Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Person pessoa = new Person("Mauricio","Viana",29);
            Console.WriteLine(pessoa.Nome);
        }
    }
}