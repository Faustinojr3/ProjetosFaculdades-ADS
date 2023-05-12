
Livro l = new Livro();
l.autor = "Faustino";
l.titulo = "Java aprender";
l.código = 123;
l.ano_de_lançamento = 2023;
l.status = true;

Pessoa p= new Pessoa();
p.nome = "Roberto";
p.email = "email";
p.CPF = "000.000.000-00";

Pessoa p1 = new Pessoa();
p.nome = "Roberte";
p.email = "email1";
p.CPF = "000.000.000-01";

Emprestimo e= new Emprestimo();
e.emprestimo(l, p, new DateTime(2023, 03, 20));

e.emprestimo(l, p1, new DateTime(2023, 03, 25));

e.Devolucao(l, p, new DateTime(2023, 03, 20));

e.emprestimo(l, p1, new DateTime(2023, 03, 25));
Console.WriteLine(l.status);
