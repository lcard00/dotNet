namespace dotNet.Models
{
    public class Curso : Utils
    {
        private string _nome;
        public string Nome 
        { 
            get => ValidaTexto(_nome); 
            set => _nome = value; 
        }    
        public List<Pessoa> Alunos { get; set; }        

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public override void Aprersentar()
        {
            Console.WriteLine($"Curso: {Nome}");
        }

    }
}