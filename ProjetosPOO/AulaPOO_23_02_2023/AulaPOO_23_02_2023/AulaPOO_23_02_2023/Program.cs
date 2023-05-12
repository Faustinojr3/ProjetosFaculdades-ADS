
double valor1 = 0;
double valor2 = 0;
int i = 1;

string op;

do
{
    Calc1 calc = new Calc1();
    Console.WriteLine("Bem vindo ao software de calculos, por favor insira os valores e a operação a ser feito \r\n '+' Para somar, '-' Para subtrair, 'x' Para multiplicar  e '/' para dividir \r\n 0 - para sair ");
        valor1 = Convert.ToDouble(Console.ReadLine());
        op = Console.ReadLine();
        valor2= Convert.ToDouble(Console.ReadLine());   

        switch (op){
            case ("+"):

                Console.WriteLine("O valor é = " + calc.Soma(valor1, valor2)); 
                
                break;
               case ("-"):
                Console.WriteLine("O valor é = " + calc.Subtração(valor1, valor2)); 
                break;

            case ("X"):
                Console.WriteLine("O valor é = " + calc.Multiplicação(valor1, valor2));
                break;

            case ("/"):
                Console.WriteLine("O valor é = "+ calc.Divisão(valor1, valor2));
                break;
        }

    Console.WriteLine("Digite: \r\n 1 - Para outra operação \r\n 0 - para sair");
      i= Convert.ToInt32(Console.ReadLine());

}while(i != 0 );


Console.ReadKey();