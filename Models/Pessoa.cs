namespace dotNet.Models
{
    public class Pessoa : Utils
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
            get => ($"{ValidaTexto(Nome.ToUpper())} {Sobrenome.ToUpper()}");
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

        public override void Aprersentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }

    }
}