using exemplo03.moldels;

Pessoa p1 = new Pessoa("Carlos", "Alberto");
Pessoa p2 = new Pessoa("Alberto", "Carlos");

Curso Ingles = new Curso();
Ingles.Nome = "Curso de Inglês";
Ingles.Alunos = new List<Pessoa>();
Ingles.AdicionarALuno(p1);
Ingles.AdicionarALuno(p2);
Ingles.ListarAlunos();
