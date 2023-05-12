int Nota1;
int Nota2;
int i ;



do
{
    Aluno aluno = new Aluno();

    Console.WriteLine("Bem vindo ao software cara o cálculo de média dos alunos:\r\n Nome do Aluno: ");
    aluno.Nome= Console.ReadLine();

    Console.WriteLine(" Nota númnero 1: ");
    aluno.Nota1 = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine("Nota número 2: ");
    aluno.Nota2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("A média do(a)  "+ aluno.Nome +" : " );

    Console.WriteLine(aluno.MediaDasNotas(aluno.Nota1, aluno.Nota2) + "\r\n \r\n Digite: \r\n 1 - para cadastrar outro aluno \r\n 0- para sair ");
    i = Convert.ToInt32(Console.ReadLine());


}  while (i!=0);