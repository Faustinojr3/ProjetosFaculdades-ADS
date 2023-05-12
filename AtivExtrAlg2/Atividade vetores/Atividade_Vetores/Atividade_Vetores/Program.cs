using Atividade_Vetores;
string atividadeVetores;

Console.WriteLine("Digite a Atividade desejada:");
atividadeVetores = Console.ReadLine();

int atividadeVetores = 0;





//Fazer um Cw com o nome dos arquivos do menu
switch (atividadeVetores)
{
    case "2":
        //  2.	Dadas as temperaturas que foram regis- tradas, diariamente, durante uma semana, deseja-se determinar em quantos dias desta semana a temperatura esteve acima da média. A solução para este problema envolve os se- guintes passos:
        // a)	Obter os valores das temperaturas.
        // b)	Calcular a média desses valores.
        // c)	Verificar quantos deles sáo maiores que a média.


        Console.WriteLine("Seja bem vindo ao software para verificação das maiores temperaturas de acordo com a media semanal.\r\n ");
        double soma;
        double media;

        double[] temperaturas = new double[7];
        double[] acimaMedia = new double[7];

        System.Console.WriteLine("Por favor insira os valores semanal (lembrando, é necessário a inserção de 7 valores):");
        for (int i = 0; i < temperaturas.Lengh; i++)
        {
            Console.WriteLine("Temperatura Nº " + i + ":");
            atividadeVetores[i] = Convert.ToDouble32(Console.ReadLine());
            soma = atividadeVetores[i] + soma;


        }
        media = soma / 7;
        System.Console.WriteLine("Os valores encontrados acima da media são:");
        for (int a = 0; a < 7; a++)
        {
            if (temperaturas[a] > media)
            {
                acimaMedia[a] = temperaturas[a];
                System.Console.WriteLine(Convert.ToString(acimaMedia[a]));

            }



        }



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

        System.Console.WriteLine("Altura das Pessoas \r\n Insira os 10 valores necessários");
        for (int i = 0; i < alturas.Length; i++)
        {
            System.Console.WriteLine("Valor nº " + i + ":");
            alturas[i] = Convert.ToDouble32(ConsoleReadLine());

        }
        System.Console.WriteLine("Valores inseridos:");
        for (int i = 0; i < alturas.Length; i++)
        {
            System.Console.WriteLine(alturas[i]);

        }


        break;

    case "7":
        // 7.	Codifique um algoritmo Histograma, que exiba um histograma da variação da temperatura durante a semana. Por exemplo, se as  temperaturas  forem  19O C,   21 °C,    25°C, 22OC,  20°C,  17°C  e  l 5°C,  de  domingo  a sábado, respectivamente, o algoritmo deve- rá exibir:
        // D   :   ■■■■■■■■■■■■■■■■■■■
        // S   : ■■■■■■■■■■■■■■■■■M■■■
        // T : ■■■■■■■■■■■■■■■■■■■■■■■■■
        // Suponha que as temperaturas sejam todas positivas e que nenhuma seja maior que 80OC. Dica: crie uma rotina que exiba uma linha, com uma quantidade de caracteres de tamanho proporcional a temperatura


        break;




    case "8":

        // 8.	Faça um algoritmo que construa dois veto- res A e B de 10 elementos e, a partir de- les, crie um vetor C, composto pela soma dos elementos, sendo: C[1] A[1]
        // + B[10], C[2)   A[2) + B[9],
        // C[3] A[3] + B[8)etc.




        break;

    case "9":
        // 9.	Elabore um algoritmo que crie dois vetores A e B de 10 elementos e, a partir deles,
        //  crie um vetor C, composto pela uniáo dos elementos de A e B, dispostos em ordem crescente, exibindo o resultado.
       
       
       
       
       
       
       
       
       
       
       
       
       
       
        break;


    case "10":
        //  10.	A partir de cinco vetores de cinco elementos inteiros, fornecidos pelo usuario, crie uma matriz de cinco linhas e colunas e exiba
        //   seu conteúdo.
        System.Console.WriteLine("Esse software tem como objetivo ler os valores inseridos em cinco vetores, e colocalos dentro de uma matriz");

        double[] vetor1 = new double[5];
        double[] vetor2 = new double[5];
        double[] vetor3 = new double[5];
        double[] vetor4 = new double[5];
        double[] vetor5 = new double[5];

        double[][] vetores = new double[5][5];
        int i = 0;
        int j = 0;

        for (i < vetor1.Length; i++;)
        {
            System.Console.WriteLine("Insira os valores do vetor 1 \r\n valor nº " + i + ":");
            vetor1[i] = Convert.ToDouble32(Console.ReadLine());
            vetores[1][i] = vetor1[i];
        }

        for (i < vetor2.Length; i++;)
        {
            System.Console.WriteLine("Insira os valores do vetor 2\r\n valor nº " + i + ":");
            vetor2[i] = Convert.ToDouble32(Console.ReadLine());
            vetores[2][i] = vetor2[i];
        }

        for (i < vetor3.Length; i++;)
        {
            System.Console.WriteLine("Insira os valores do vetor 3 \r\n valor nº " + i + ":");
            vetor3[i] = Convert.ToDouble32(Console.ReadLine());
            vetores[3][i] = vetor3[i];
        }

        for (i < vetor4.Length; i++;)
        {
            System.Console.WriteLine("Insira os valores do vetor 4  \r\n valor nº " + i + ":");
            vetor4[i] = Convert.ToDouble32(Console.ReadLine());
            vetores[4][i] = vetor4[i];
        }

        for (i < vetor5.Length; i++;)
        {
            System.Console.WriteLine("Insira os valores do vetor 5 \r\n valor nº " + i + ":");
            vetor5[i] = Convert.ToDouble32(Console.ReadLine());
            vetores[5][i] = vetor5[i];
        }

        System.Console.WriteLine("Os valores inseridos foram:");
        for (j < vetores.Length; j++;)
        {
            for (i < vetores.Length; i++;)
            {
                System.Console.WriteLine(vetores[j][i]);
            }


        }


        break;




    default:


        break;

}




Console.ReadKey();