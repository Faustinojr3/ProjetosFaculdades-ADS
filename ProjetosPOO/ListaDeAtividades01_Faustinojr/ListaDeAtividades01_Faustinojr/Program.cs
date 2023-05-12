/*1.Crie uma classe matemática com os seguintes métodos:
a) Métodos somar, que deve receber dois valores por parâmetro e retornar a soma dos
valores;
b) Métodos maio, recebe dois valores por parâmetro e retorne o maior entre os dois, caso
seja igual retorne apenas o valor.
c) Métodos raiz quadrada, recebe por parâmetro um número e verifica e retorna a raiz
quadrada desse número.
d) Na classe Program, crie uma instância da classe matemática e realize o teste dos três
métodos acima.*/

using ListaDeAtividades01_Faustinojr;
using System.Runtime.InteropServices;

Matematica operacao= new Matematica();


Console.WriteLine(operacao.Soma(3,2));
Console.WriteLine(operacao.Maior(51,50));
Console.WriteLine(operacao.Raiz(25));

