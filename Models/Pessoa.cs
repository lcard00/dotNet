using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace dotNet.Models
{
    public class Pessoa
    {
        private string _nome;
        private string _sobrenome;
        private int _idade;
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public string Sobrenome
        {
            get => _sobrenome;
            set => _sobrenome = value;
        }

        public string NomeCompleto
        {
            get => ($"{ValidaNome(Nome.ToUpper())} {Sobrenome.ToUpper()}");
        }
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A Idade não pode ser menor do que zero.");
                }
                _idade = value;
            }
        }

        public void Aprersentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }

        public static string ValidaNome(string name)
        {
            if (name == "")
            {
                throw new ArgumentException("O nome não pode ser vazio.");
            }

            return name;
        }
    }
}