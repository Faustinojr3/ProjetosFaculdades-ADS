using AtividadePresença;

// 1 criar o cad, inicio, lista e aux
Eleitor cad, inicio = null, lista = null, aux = null;
int qv = 0, op = 0;

// 2 ter do while para fazer varias vezes
do
{

    // 3 criar nova lista
    cad = new Eleitor();
    Console.WriteLine("Digite o nome do Eleitor");
    cad.Name = Console.ReadLine();
    Console.WriteLine("Digite o CPF do Eleitor");
    cad.cpf = Console.ReadLine();

    //Escolher político 
int NumeroPresidente= 0;
int NumeroDeputadoFed = 0;


    for (int i = 0; i < qv; i++)
    {
        Console.WriteLine("Digite o numero do seu candidato para presidente");
        cad.NumeroPresidente = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o Valor do Produto");
        cad.NumeroDeputadoFed = Convert.ToInt32(Console.ReadLine());
    }

    //4 ver se a lista tem inicio
    if (inicio == null)
    {
        // primeiro elemento da lista
        inicio = cad;
        inicio.prox = null;
    }
    else
    {
        //segundo elemento da lista
        //5 ver se a lista tem segundo elemento
        if (inicio.prox == null)
        {
            lista = cad;
            inicio.prox = lista;
            lista.prox = null;
        }
        //6 acrescentar itens da lista
        lista.prox = cad;
        lista = cad;
        lista.prox = null;
    }
    Console.WriteLine("Para ir para o próximo eleitor digite 1");
    Console.WriteLine("Para sair, digite 0");
    op = Convert.ToInt32(Console.ReadLine());

} while (op != 0);

//7 aux para percorrer e mostrar a lista
aux = inicio;
// 8 aux vai até ser nulo
while (aux != null)
{
    Console.WriteLine("Nome do Eleitor");
    Console.WriteLine(aux.Name);
    Console.WriteLine("O Endereço do Eleitor");
    Console.WriteLine(aux.end.logradouro);
    Console.WriteLine(aux.end.cep);


    // 9 o aux recebe o proximo elemento, até ser nulo
    aux = aux.prox;
}

Console.ReadKey();