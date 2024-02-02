using System.Xml.XPath;

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

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public int ObertQuantidadeDeAlunosMatriculados()
        {
            return Alunos.Count;
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso : {Nome}");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }

        public override void Aprersentar()
        {
            Console.WriteLine($"Curso: {Nome}");
        }



    }
}