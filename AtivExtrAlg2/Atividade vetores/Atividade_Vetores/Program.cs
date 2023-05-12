using Atividade_Vetores;
string atividadeVetores;


Console.WriteLine("Digite a Atividade desejada:");
atividadeVetores = Console.ReadLine();

int atividadeVetores = 0;





//Fazer um Cw com o nome dos arquivos do menu
switch (atividadeVetores)
{
    case "2":

        Console.WriteLine("Seja bem vindo ao software para verificação das maiores temperaturas de acordo com a media semanal.\r\n ");
        double soma = 0.0;
        double media = 0.0;


        double[] temperaturas = new double[8];
        double[] acimaMedia = new double[8];

        System.Console.WriteLine("Por favor insira os valores semanal (lembrando, é necessário a inserção de 7 valores):");
        for (int i = 1; i < temperaturas.Length; i++)
        {


            Console.WriteLine("Temperatura Nº " + i + ":");
            temperaturas[i] = Convert.ToDouble(Console.ReadLine());
            soma = temperaturas[i] + soma;


        }


        media = soma / 3;


        System.Console.WriteLine("Os valores encontrados acima da media são:");
        for (int a = 0; a < temperaturas.Length; a++)
        {
            if (temperaturas[a] > media)
            {
                Console.WriteLine(temperaturas[a]);
            }
        }







//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        break;
    case "3":
        // 3.	Crie vetores para armazenar:
        // a)	As vogais do alfabeto.
        // b)	As alturas de um grupo de dez pessoas.
        // c)	Os nomes dos meses do ano.
        System.Console.WriteLine("Esse software tem como objetivo salvar as vogais do alfabeto. Salvar a altura de 10 pessoas. E os nomes dos meses do ano");
        string[] vogais = new string[5];

        double[] alturas = new double[10];

        string[] meses = new string[12];


        System.Console.WriteLine("Vogais:");
        vogais[0] = "a";
        vogais[1] = "e";
        vogais[2] = "i";
        vogais[3] = "o";
        vogais[4] = "u";


        for (int vog = 0; vog < vogais.Length; vog++)
        {
            Console.WriteLine(vogais[vog]);

        }

        // altura 

        System.Console.WriteLine("Altura das Pessoas \r\n Insira os 10 valores necessários, em centimetros");
        for (int alt = 0; alt < alturas.Length; alt++)
        {
            int alt1 = alt + 1;
            System.Console.WriteLine("Valor nº " + alt1 + ":");
            alturas[alt] = Convert.ToDouble(Console.ReadLine());

        }
        System.Console.WriteLine("Valores inseridos:");
        for (int alt = 0; alt < alturas.Length; alt++)
        {
            System.Console.WriteLine(alturas[alt] + "cm");

        }

        //nome dos meses 

        Console.WriteLine("\r\nOs meses do ano são:");
        meses[0] = "Janeiro";
        meses[1] = "Fevereiro";
        meses[2] = "Março";
        meses[3] = "Maio";
        meses[4] = "Abril";
        meses[5] = "Junho";
        meses[6] = "Julho";
        meses[7] = "Agosto";
        meses[8] = "Setembro";
        meses[9] = "Outubro";
        meses[10] = "Novembro";
        meses[11] = "Desembro";

        for (int mes = 0; mes < meses.Length; mes++)
        {


            Console.WriteLine(meses[mes]);

        }


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
  
    case "7":
        // 7.	Codifique um algoritmo Histograma, que exiba um histograma da variação da temperatura durante a semana. Por exemplo, se as  temperaturas  forem  19O C,   21 °C,    25°C, 22OC,  20°C,  17°C  e  l 5°C,  de  domingo  a sábado, respectivamente, o algoritmo deve- rá exibir:
        // D   :   ■■■■■■■■■■■■■■■■■■■
        // S   : ■■■■■■■■■■■■■■■■■M■■■
        // T : ■■■■■■■■■■■■■■■■■■■■■■■■■    
        // Suponha que as temperaturas sejam todas positivas e que nenhuma seja maior que 80OC. Dica: crie uma rotina que exiba uma linha, com uma quantidade de caracteres de tamanho proporcional a temperatura

Console.WriteLine("Seja bem vindo ao historagrama por favor insira as tamperaturas dos seguintes dias:");

int[] historagrama = new int[7];
string[] dias = new string[7];


dias[0] = "Domingo: ";
dias[1] = "Segunda: ";
dias[2] = "Terça: ";
dias[3] = "Quarta: ";
dias[4] = "Quinta: ";
dias[5] = "Sexta: ";
dias[6] = "Sábado: ";

//--------------Adicionar valores historiograma---------------------------
for (int hist = 0; hist < dias.Length; hist++)
{

    Console.WriteLine(dias[hist]);
    historagrama[hist] = Convert.ToInt32(Console.ReadLine());
}





//-------------Convertendo para string e demostrando o historiograma----------------------
for (int hist = 0; hist < historagrama.Length; hist++)
{

    if (historagrama[hist] <= 80 && historagrama[hist] > 0)
    {



        string cp = "";
        // cp.PadRight (Quantidadde minima de caraceres, 'Simbolo a ser usado para completar os requisitos mínimos')
        cp = cp.PadRight(historagrama[hist],'°');
        System.Console.WriteLine(dias[hist] + cp);

    }

}



        break;



////////////////////////////////////////////////////////////////////////////////////////////////
    case "8":

  // 8.	Faça um algoritmo que construa dois veto- res A e B de 10 elementos e, a partir de- les, crie um vetor C, composto pela soma dos elementos, sendo: C[1]= A[1] + B[10], C[2) =  A[2) + B[9],
// C[3]= A[3] + B[8)etc.

double[] A = new double[10];
double[] B = new double[10];
double[] C = new double[10];
int a1 = 0;
int b1 = 0;
//      --Valores do Vetor A--
for (int a = 0; a < A.Length; a++)
{
   
    a1++;
    Console.WriteLine(" VALORES VETOR A \r\n" + a1 + "º Valor ");
    A[a] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\r\n");

}
//      --Valores do Vetor B--
for (int b = 0; b < B.Length; b++)
{

    b1++;

    Console.WriteLine(" VALORES VETOR B \r\n" + b1 + "º Valor \r\n");
    B[b] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\r\n");


}
//      --Valores do Vetor C--
for (int c = 0; c < C.Length; c++)
{

    int c2 = 9;


    C[c] = A[c] + B[c2];
    c2--;
}

//      --Resultados  Vetor C--

for (int c = 0; c < C.Length; c++)
{
   int p = 1;
    p++;
    Console.WriteLine(" Os recultados encontrados no vetor C são: \r\n" + p + "º Valor encontrado é:\r\n" + C[c]);


}
        
        break;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    case "9":
        // 9.	Elabore um algoritmo que crie dois vetores A e B de 10 elementos e, a partir deles,
        //  crie um vetor C, composto pela uniáo dos elementos de A e B, dispostos em ordem crescente, exibindo o resultado.

        double[] D = new double[20];
       
        Random aleatorio = new Random();


       //      --Valores do Vetor A--
        for(int a=0; a<A.Length; a++)
        {
            int a1 = 1;
            a1++;
            Console.WriteLine(" VALORES VETOR A \r\n"+a1+ "º Valor" );
            A[a] = Convert.ToDouble(Console.Readline());


        }
 //      --Valores do Vetor B--
         for(int b=0; b<B.Length; b++)
        {
            int b1 = 1;
            b1++;

            Console.WriteLine(" VALORES VETOR A \r\n"+b1+ "º Valor" );
            B[b] = Convert.ToDouble(Console.Readline());


        }

        //      --Valores do Vetor C--

        for (int d = 0; d =9; d++)
        {
            int E = 10;

            D[d] = A[d];
            D[E]=B[d];

            E++;
        }

        
            Console.WriteLine("OS valores do vetor C são: "  );
        for (int d = 0; d > d.Length; d++)
        {

       Console.WriteLine(D[d]);

        }








            //      --Tratamento valores de C--



            int i, j, min, x;
for (i = 1; i <= ; i++)
{
    min = i;
    for (j = i + 1; j <= n; j++)
    {
        if (D[j] < D[min])
            min = j;
    }
    x = vet[min];
    vet[min] = vet[i];
    vet[i] = x;
}










//      --Resultados  Vetor C--

for (int c=0; c<D.Length; c++){
p=1;
p++;
Console.WriteLine(" Os recultados encontrados no vetor C são: \r\n"+p+ "º Valor encontrado é:\r\n"+ D[c]);


}





        break;

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    case "10":
    

        //  10.	A partir de cinco vetores de cinco elementos inteiros, fornecidos pelo usuario, crie uma matriz de cinco linhas e colunas e exiba
        //   seu conteúdo.
       Console.WriteLine("Esse software tem como objetivo ler os valores inseridos em cinco vetores, e colocalos dentro de uma matriz");

double[] vetor1 = new double[5];
double[] vetor2 = new double[5];
double[] vetor3 = new double[5];
double[] vetor4 = new double[5];
double[] vetor5 = new double[5];

double[,] vetores = new double [5,5];


for (int i = 0;  i < vetor1.Length; i++)
{
    System.Console.WriteLine("Insira os valores do vetor 1 \r\n valor nº " + i + ":");
    vetor1[i] = Convert.ToDouble(Console.ReadLine());
    vetores[0,i] = vetor1[i];
}

for (int i = 0; i < vetor2.Length; i++)
{
    System.Console.WriteLine("Insira os valores do vetor 2\r\n valor nº " + i + ":");
    vetor2[i] = Convert.ToDouble(Console.ReadLine());
    vetores[1,i] = vetor2[i];
}

for (int i = 0; i < vetor3.Length; i++)
{
    System.Console.WriteLine("Insira os valores do vetor 3 \r\n valor nº " + i + ":");
    vetor3[i] = Convert.ToDouble(Console.ReadLine());
    vetores[2,i] = vetor3[i];
}

for (int i=0;i < vetor4.Length; i++)
{
    System.Console.WriteLine("Insira os valores do vetor 4  \r\n valor nº " + i + ":");
    vetor4[i] = Convert.ToDouble(Console.ReadLine());
    vetores[3,i] = vetor4[i];
}

for (int i = 0; i < vetor5.Length; i++)
{
    System.Console.WriteLine("Insira os valores do vetor 5 \r\n valor nº " + i + ":");
    vetor5[i] = Convert.ToDouble(Console.ReadLine());
    vetores[4, i] = vetor5[i];
}

System.Console.WriteLine("Os valores inseridos foram:");
for (int j=0; j< 5; j++)
{
    for (int i=0; i  < 5; i++)
    {
        Console.WriteLine(vetores[j,i]);
    }
    

}



        break;




    default:


        break;

}




Console.ReadKey();