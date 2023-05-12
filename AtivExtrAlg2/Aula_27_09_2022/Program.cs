using atividadeAula_27_09_2022;

Pessoa novo, pessoa, cad, lista, inicio, aux = null;
inicio = null;
lista = null;

    cad = new Pessoa();
int op = 0;
do
{
    novo = new Pessoa();

    Console.WriteLine("Digite onome da Pessoa");
    novo.nome = Console.ReadLine();
    Console.WriteLine("Digite o Email da pessoa ");
    novo.email = Console.ReadLine();
    Console.WriteLine("Digite a idade da pessoa:");
    novo.idade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("O nome da pessoa é: " + novo.nome);

    if (inicio == null)
    {
        inicio = novo;
        inicio.prox = null;

    }
    else
    {
        if (inicio.prox == null)
        {
            lista = novo;
            inicio.prox = lista;
            lista.prox = null;
        }
        lista.prox = novo;
        lista = novo;
        lista.prox = null;


    }
    Console.WriteLine("Deseja cadastrar outro? Digite 1 para sim, e 0 para sair");
    op = Convert.ToInt32(Console.ReadLine());
} while (op!=0);

aux = inicio;
while (aux != null)
{
    Console.WriteLine("O nome da pessoa é:" + aux.nome);
    Console.WriteLine("O email d pessoa é:"+ aux.email);
    Console.WriteLine("A idade pessoa é" + aux.idade);

    Console.WriteLine("================================================================");

    aux= aux.prox;

}








