//2) Crie uma lista simples com o aluno, onde este possui nome, matrícula, curso, disciplina
//e nota dessas disciplinas, e com média das notas.// 
using NotasAlunos;
using System.Globalization;
using System.Net.Http.Headers;

Aluno Cad, Inicio = null, lista = null, aux = null;
int op = 0;

double SomaNotaDisc = 0.0;
double mediaDisc = 0.0;

double SomaMedias=0.0;
double MediaGeral=0.0;
do {
    // criando lista 
    Cad= new Aluno();
    Console.WriteLine("Digite o nome do aluno:");
    Cad.Nome = Console.ReadLine();

    Console.WriteLine("Digite a matrícula do aluno:");
    Cad.Matricula =Convert.ToInt32( Console.ReadLine());


    Console.WriteLine("Digite o Curso do aluno:");
    Cad.Curso = Console.ReadLine();

    Console.WriteLine("Digite a quantitade de disciplinas do aluno:");
    Cad.QuantidadeDisc =Convert.ToInt32( Console.ReadLine());

    Cad.Disciplina = new string[aux.QuantidadeDisc];
    Cad.NotasDisc= new double[aux.QuantidadeDisc,4];

    //Inserção dads notas
    for(int i=0; i<aux.QuantidadeDisc.Length; i++)
    {
        Console.WriteLine("Digite o nome da disciplina:");
        Cad.Disciplina[i] = Console.ReadLine();

        for(int j=0;j<4; j++)
        {
            Console.WriteLine("Digite o valor da nota do "+ j+"º bimestre: ");
            Cad.NotasDisc[i, j] = Convert.ToDouble(Console.ReadLine());

        }

    }

    //4 ver se a lista tem inicio
    if (Inicio == null)
    {
        // primeiro elemento da lista
        Inicio = Cad;
        Inicio.prox = null;
    }
    else
    {
        //segundo elemento da lista
        //5 ver se a lista tem segundo elemento
        if (Inicio.prox == null)
        {
            lista = Cad;
            Inicio.prox = lista;
            lista.prox = null;
        }
        //6 acrescentar itens da lista
        lista.prox = Cad;
        lista = Cad;
        lista.prox = null;
    }


    Console.WriteLine("Para cadastrar mais um aluno, digite 1");
    Console.WriteLine("Para sair, digite 0");
    op = Convert.ToInt32(Console.ReadLine());

    //Checar icio da lista 




} while(op!=0);


aux = Inicio;

while (aux != null) {

    Console.WriteLine("Nome do Aluno:");
    Console.WriteLine(aux.Nome);

    Console.WriteLine("Matricula do Aluno:");
    Console.WriteLine(aux.Matricula);

    Console.WriteLine("Curso do Aluno:");
    Console.WriteLine(aux.Curso);

    for(int i=0; i< aux.QuantidadeDisc.Length; i++)
    {

        Console.WriteLine("Disciplina Nº" + (i + 1)+":");
        Console.WriteLine(aux.Disciplina[i]);

        for (int j = 0; j < 4; j++) {
            Console.WriteLine("Nota do " + (i + 1)+"º bimestre:");
            Console.WriteLine(aux.NotasDisc[i,j]) ;
            
            SomaNotaDisc = aux.NotasDisc[i, j] + SomaNotaDisc;

            
        }
        mediaDisc = SomaNotaDisc / 4;

        Console.WriteLine("A medisa na disciplina é de: ");
       Console.WriteLine(mediaDisc);
        SomaMedias = mediaDisc + SomaMedias;

        MediaGeral = SomaMedias / i;
    }
    
   
    
    Console.WriteLine("A media geral do Aluno é de:" + MediaGeral);
    // 9 o aux recebe o proximo elemento, até ser nulo
    aux = aux.prox;
}

    




















