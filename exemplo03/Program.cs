using exemplo03.moldels;

Pessoa p1 = new Pessoa();
p1.Nome = "Carlos";
p1.Sobrenome = "Alberto";

Pessoa p2 = new Pessoa();
p2.Nome = "Alberto";
p2.Sobrenome = "Carlos";

Curso Ingles = new Curso();
Ingles.Nome = "Curso de Inglês";
Ingles.Alunos = new List<Pessoa>();
Ingles.AdicionarALuno(p1);
Ingles.AdicionarALuno(p2);
Ingles.ListarAlunos();
