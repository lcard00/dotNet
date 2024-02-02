using dotNet.Models;

Pessoa p1 = new()
{
    Nome = "Leonardo",
    Sobrenome = "Cardoso",
};

Pessoa p2 = new("Luna", "Golden");

Curso cursoDotNet = new()
{
    Nome = "dotNet",
    Alunos = new List<Pessoa>()
};


cursoDotNet.AdicionarAluno(p1);
cursoDotNet.AdicionarAluno(p2);

cursoDotNet.ListarAlunos();