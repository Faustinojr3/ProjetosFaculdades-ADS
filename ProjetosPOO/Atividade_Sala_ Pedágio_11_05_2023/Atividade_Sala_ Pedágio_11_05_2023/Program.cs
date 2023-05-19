
using Atividade_Sala__Pedágio_11_05_2023;

Console.WriteLine("Bem vindo ao sistema respónsavel pelo o controle de pedagio, Betha S/A");
Console.WriteLine("Selecione a classificação do seu  de veiculo: \r\n Digite:\r\n 1- Carros de Passeio \r\n 2- Carros Utilitários\r\n 3- Ônibus \r\n 4-Caminhão");
int op= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o tipo do seu veículo: \r\n Tipo 1: Pessoa física \r\n Tipo 2: Pessoa Juridica \r\n Tipo 3-  Oficial");
int tipo= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira a placa do veículo:");
string placa= Console.ReadLine();

Console.WriteLine("Insira a quantidade de eixos do veiculo:");
    int qtdEixos = Convert.ToInt32(Console.ReadLine());

if (op == 1)
{
    Passeio passeio = new Passeio(placa,qtdEixos, tipo);
    passeio.CalcularPedagio();
    passeio.tipoPlaca();
    Console.WriteLine(passeio.getTipo_de_placa());
    Console.Clear(); 
    Console.WriteLine("O valor a ser pago é de R$ " + passeio.getValorFinal());
}
if(op == 2)
{
    Utilitario utilitario = new Utilitario(placa, qtdEixos, tipo);
    utilitario.CalcularPedagio();
    utilitario.tipoPlaca();
    Console.WriteLine(utilitario.getTipo_de_placa());
    Console.Clear();
    Console.WriteLine("O valor a ser pago é de R$ " + utilitario.getValorFinal());
}
if (op == 3)
{
    Onibus onibus = new Onibus(placa, qtdEixos, tipo);
    onibus.CalcularPedagio();
    onibus.tipoPlaca();
    Console.WriteLine(onibus.getTipo_de_placa());
    Console.Clear();
    Console.WriteLine("O valor a ser pago é de R$ " + onibus.getValorFinal());
}
if (op == 4)
{
    Caminhao caminhao = new Caminhao(placa, qtdEixos, tipo);
    caminhao.CalcularPedagio();
    caminhao.tipoPlaca();
    Console.WriteLine(caminhao.getTipo_de_placa());
    Console.Clear();
    Console.WriteLine("O valor a ser pago é de R$ " + caminhao.getValorFinal());
}
