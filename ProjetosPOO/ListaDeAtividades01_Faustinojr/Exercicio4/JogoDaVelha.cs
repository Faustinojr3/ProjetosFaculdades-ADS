using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/*4. Escreva um programa completo para jogar o jogo da velha. Para tanto crie uma classe
JogoDaVelha:
a) a classe deve conter como dados privados um array bidimensional 3x3 para representar
a grade do jogo
b) crie uma enumeração para representar as possibilidades de ocupação de uma casa na
grade (vazia, jogador 1 ou jogador 2)
c) o construtor deve inicializar a grade como vazia
d) forneça um método para exibir a grade
e) permita dois jogadores humanos
f) forneça um método para jogar o jogo; todo movimento deve ocorrer em uma casa vazia;
depois de cada movimento, determine se houve uma derrota ou um empate.*/
namespace Exercicio4
{
    internal class JogoDaVelha
    {
        private string[,] jogo = new string[3, 3];

        public JogoDaVelha()
        {


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    jogo[i, j] = " ";

                }

            }

        }
        public string GetJogo(int coluna, int linha)
        {

            return jogo[coluna, linha];

        }

        public string getLayoutJogo(JogoDaVelha jogoDaVelha)
        {
            string layout = "    1 2 3\r\n" +
                 "1  (" + jogoDaVelha.GetJogo(0, 0) + ")" + "(" + jogoDaVelha.GetJogo(0, 1) + ")" + "(" + jogoDaVelha.GetJogo(0, 2) + ") \r\n" +
                 "2  (" + jogoDaVelha.GetJogo(1, 0) + ")" + "(" + jogoDaVelha.GetJogo(1, 1) + ")" + "(" + jogoDaVelha.GetJogo(1, 2) + ") \r\n" +
                 "3  (" + jogoDaVelha.GetJogo(2, 0) + ")" + "(" + jogoDaVelha.GetJogo(2, 1) + ")" + "(" + jogoDaVelha.GetJogo(2, 2) + ") \r\n";

            return layout;

        }

        public string JogaroJogo()
        {
            string vitoriaJ1 = "Vitoria do Jogador1";
            string vitoriaJ2 = "Vitoria do Jogador2";
            string empate = "Empate";
            //Possiveis vitorias da primeira linha 



            for (int l = 0; l < 10; l++)
            {
                getLayoutJogo(JogoDaVelha);
                if (jogo[0, 0] == jogo[0, 1] && jogo[0, 1] == jogo[0, 2])
                {
                    if (jogo[0, 0] == "X") { return vitoriaJ1 ; }
                    else { return vitoriaJ2 ; }
                    break;
                }
                //Possiveis vitorias da segunda linha 
                if (jogo[1, 0] == jogo[1, 1] && jogo[1, 1] == jogo[1, 2])
                {
                    if (jogo[1, 0] == "X") { return vitoriaJ1 ; }
                    else { return vitoriaJ2 ; }
                    break;
                }
                //Possiveis vitorias da terceira linha 
                if (jogo[2, 0] == jogo[2, 1] && jogo[2, 1] == jogo[2, 2])
                {
                    if (jogo[2, 0] == "X") { return vitoriaJ1 ; }
                    else { if (jogo[2, 0] == "O") { return vitoriaJ2 ; } }
                    break;
                }



                //Possiveis vitorias da Primeira Coluna
                if (jogo[0, 0] == jogo[1, 0] && jogo[1, 0] == jogo[2, 0])
                {
                    if (jogo[0, 0] == "X") { return vitoriaJ1 ; }
                    else { if (jogo[0, 0] == "O") { return vitoriaJ2 ; } }
                    break;
                }
                //Possiveis vitorias da segunda Coluna
                if (jogo[0, 1] == jogo[1, 1] && jogo[1, 1] == jogo[2, 1])
                {
                    if (jogo[0, 1] == "X") { return vitoriaJ1 ; }
                    else { if (jogo[0, 1] == "O") { return vitoriaJ2 ; } }
                    break;
                }
                //Possiveis vitorias da terceira Coluna
                if (jogo[0, 2] == jogo[1, 2] && jogo[1, 2] == jogo[2, 2])
                {
                    if (jogo[0, 2] == "X") { return vitoriaJ1 ; }
                    else { if (jogo[0, 2] == "O") { return vitoriaJ2 ; } }
                    break;
                }


                //Possiveis vitorias nas transversais 
                if (jogo[0, 0] == jogo[1, 1] && jogo[1, 2] == jogo[2, 2])
                {
                    if (jogo[0, 0] == "X") { return vitoriaJ1 ; }
                    else { if (jogo[0, 0] == "O") { return vitoriaJ2 ; } }
                    break;
                }
                if (jogo[0, 2] == jogo[1, 1] && jogo[2, 0] == jogo[2, 2])
                {
                    if (jogo[0, 2] == "X") { return vitoriaJ1 ; }
                    else { if (jogo[0, 2] == "O") { return vitoriaJ2 ; } }
                    break;
                }

                //Empates 

                if (l == 9) { return empate; break; }


                return "Jogo em Andamento";

            }
        }
    }
}
