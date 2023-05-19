using BancoXX;

Console.WriteLine("Bem vindo ao Banco XX, por favor insira:\r\n Nº da conta:");
int nconta=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Agência:");
string agencia= Console.ReadLine();
Console.WriteLine("Titular:"); 
string titular =Console.ReadLine();

Console.Clear();
Console.WriteLine("Selecione o tipo da conta:\r\n 1- Conta comum\r\n 2-Conta Empresarial \r\n 3- Conta Estudantil:");
int op=Convert.ToInt32(Console.ReadLine());

if(op == 1)
{ Conta conta= new Conta(nconta, agencia,titular);

    Console.WriteLine("Escolha uma das seguintes opções: \r\n 1- Sacar \r\n 2- Depositar");
    op=Convert.ToInt32(Console.ReadLine());

    if(op == 1)
    {
        Console.WriteLine("Digite o valor a ser sacado");
        double sacar= Convert.ToDouble( Console.ReadLine());
        conta.Sacar(sacar);
    }
    if(op == 2) { Console.WriteLine(); }


}
if(op == 2)
{
    ContaEmpresarial contaEmpresarial = new ContaEmpresarial(nconta, agencia, titular);


}
if(op == 3)
{
    Console.WriteLine("Insira o cpf");
    string cpf= Console.ReadLine();
    Console.WriteLine( "Insira o nome da instituição");
    string nomeInstituição= Console.ReadLine();

    ContaEstudante contaEstudante = new ContaEstudante(nconta, agencia, titular, cpf, nomeInstituição);

}