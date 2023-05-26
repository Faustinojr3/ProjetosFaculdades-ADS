using BancoXX;
int op;
int op1;
int op2;
int op3;

Console.WriteLine("Bem vindo ao Banco XX, por favor insira:\r\n Nº da conta:");
int nconta=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Agência:");
string agencia= Console.ReadLine();
Console.WriteLine("Titular:"); 
string titular =Console.ReadLine();
 
do
{
    Console.Clear();
    Console.WriteLine("Selecione o tipo da conta:\r\n 1- Conta comum\r\n 2-Conta Empresarial \r\n 3- Conta Estudantil \r\n 0- Para sair");
     op = Convert.ToInt32(Console.ReadLine());

    if (op == 1)
    {
        Conta conta = new Conta(nconta, agencia, titular);
        do
        {
            Console.WriteLine("Escolha uma das seguintes opções: (saldo disponível: R$ " + conta.getSaldo() + " ) \r\n 1- Sacar \r\n 2- Depositar \r\n 3- Para trocar de conta \r\n 0- Para sair");
            op1 = Convert.ToInt32(Console.ReadLine());

            if (op1 == 1)
            {
                Console.Clear();
                Console.WriteLine("Digite o valor a ser sacado:");
                double sacar = Convert.ToDouble(Console.ReadLine());
                conta.Sacar(sacar);
            }
            if (op1 == 2)
            {
                Console.Clear();
                Console.WriteLine("Digite o valor a ser depositado:");
                double depositar = Convert.ToDouble(Console.ReadLine());
                conta.Depositar(depositar);
            }
            if (op1 <3 && op1 >0)
            {
                Console.Clear();
                Console.WriteLine("Digite: \r\n 1- Para fazer outra operação \r\n 2- Para trocar de conta \r\n 0- Para sair");
                op1 = Convert.ToInt32(Console.ReadLine());
            }
            if (op1 == 3) { op1 = 2; }

            if (op1 == 0) { Environment.Exit(0); }

        } while (op1 != 2);
    }
    if (op == 2)
    {
        Console.Clear();
        ContaEmpresarial contaEmpresarial = new ContaEmpresarial(nconta, agencia, titular);
        do
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das seguintes opções: (saldo disponível: R$ " + contaEmpresarial.getSaldo() + " ) \r\n 1- Sacar \r\n 2- Depositar \r\n 3- Para fazer um emprestimo \r\n 4- Para trocar de conta \r\n 0- Para sair");

            op2 = Convert.ToInt32(Console.ReadLine());

            if (op2 == 1)
            {
                Console.Clear();
                Console.WriteLine("Digite o valor a ser sacado: (OBS: valores acima de R$5000,00, é cobrado uma taxa de R$5,00 )");
                double sacar = Convert.ToDouble(Console.ReadLine());
                contaEmpresarial.Sacar(sacar);
            }
            if (op2 == 2)
            {
                Console.Clear();
                Console.WriteLine("Digite o valor a ser depositado:");
                double depositar = Convert.ToDouble(Console.ReadLine());
                contaEmpresarial.Depositar(depositar);
            }
            if (op2 == 3)
            {
                Console.Clear();
                if (contaEmpresarial.getLimiteEmprestimo() > 0)
                {
                    Console.WriteLine("Insira o valor a ser emprestado: (Limite : R$ " + contaEmpresarial.getLimiteEmprestimo() + ")");
                    double emprestimo = Convert.ToDouble(Console.ReadLine());
                    contaEmpresarial.fazerEmprestimo(emprestimo);
                }
                else
                {
                   
                    Console.WriteLine("Sem limite disponível, favor pagar emprestimos anteriores");
                    Console.ReadKey();
                }
            }
            if (op2 < 4 && op > 0)
            {
                Console.Clear();
                Console.WriteLine("Digite: \r\n 1- Para fazer outra operação \r\n 2- Para trocar de conta \r\n 0- Para sair");
                op2 = Convert.ToInt32(Console.ReadLine());
            }
            if (op2 == 4) { op2 = 2; }

            if (op2 == 0) { Environment.Exit(0); }

        } while (op2 != 2);
    }
    if (op == 3)
    {
        Console.Clear();
        Console.WriteLine("Insira o cpf");
        string cpf = Console.ReadLine();
        Console.WriteLine("Insira o nome da instituição");
        string nomeInstituição = Console.ReadLine();

        ContaEstudante contaEstudante = new ContaEstudante(nconta, agencia, titular, cpf, nomeInstituição);
        do
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das seguintes opções: (saldo disponível: R$ " + contaEstudante.getSaldo() + " ) \r\n 1- Sacar \r\n 2- Depositar \r\n 3- Para trocar de conta \r\n 0- Para sair");
            op3 = Convert.ToInt32(Console.ReadLine());

            if (op3 == 1)
            {
                Console.Clear();
                Console.WriteLine("Digite o valor a ser sacado ( Valor disponível cheque especial  R$ " + contaEstudante.getLimiteChequeEspecial() + " )");
                double sacar = Convert.ToDouble(Console.ReadLine());
                contaEstudante.Sacar(sacar);
            }
            if (op3 == 2)
            {
                Console.Clear();
                Console.WriteLine("Digite o valor a ser depositado:");
                double depositar = Convert.ToDouble(Console.ReadLine());
                contaEstudante.Depositar(depositar);
                
            }
            if (op3 < 3 && op3 > 0)
            {
                Console.Clear();
                Console.WriteLine("Digite: \r\n 1- Para fazer outra operação \r\n 2- Para trocar de conta \r\n 0- Para sair");
                op3 = Convert.ToInt32(Console.ReadLine());
            }
            if (op3 == 3) { op3 = 2; }

            if (op3 == 0) { Environment.Exit(0); }
        } while (op3 != 2);

    }
} while (op != 0);