using System.Security.Cryptography.X509Certificates;

namespace Aividade2
/*Crie uma classe Gabarito, a qual possui um método RespostaQuestao que recebe
como parâmetro o número de uma questão e retorna a sua resposta correta,
proveniente de um gabarito.

Escreva uma classe classe Prova em que cada objeto representa uma prova feita
por um aluno.

Esta prova possui 15 questões de múltipla escolha (letras A a E).

As 10 primeiras questões valem 0,5 ponto e as 5 últimas questões valem 1 ponto.

Esta classe deverá controlar as questões respondidas pelo aluno. Para isto, a classe deve
implementar os métodos:

● Construtor: recebe como parâmetro um objeto da classe Gabarito contendo o
gabarito da prova;

● RespostaAluno: recebe como parâmetro a resposta dada pelo aluno a uma
questão; este método não recebe entre os parâmetros o número da questão, ele
mesmo deve estabelecer um controle interno de modo que as questões sejam
inseridas sequencialmente, ou seja, a primeira vez que o método é chamado, insere
a primeira questão, a segunda, insere a segunda questão, e assim por diante.

● Acertos: retorna a quantidade de questões que o aluno acertou

● Nota: retorna a nota que o aluno tirou na prova;

● Maior: recebe como parâmetro um outro objeto da classe Prova e retorna a nota do
aluno que acertou mais questões; se houver empate, retorna a maior nota; se
houver empate novamente, retorna a nota do aluno representado no objeto corrente*/

    internal class Prova
    {
    public string gabarito[] = new string[15];
     public string questoes[]= new string[15];
    public string nome_aluno;
    public string turma;
    public double nota;

    public class Prova gabarito()
    {

        this.gabarito[0] = "A";
        this.gabarito[1] = "B";
        this.gabarito[2] = "C";
        this.gabarito[3] = "D";
        this.gabarito[4] = "E";
        this.gabarito[5] = "E";
        this.gabarito[6] = "D";
        this.gabarito[7] = "C";
        this.gabarito[8] = "B";
        this.gabarito[9] = "A";
        this.gabarito[10] = "A";
        this.gabarito[11] = "B";
        this.gabarito[12] = "C";
        this.gabarito[13] = "D";
        this.gabarito[14] = "E";

    } 

    public Prova RespostaAluno(string Resposta)
    {
        int i = 0;
       
       this.questoes[i] = Resposta;

        i++;

    }









    }
}
