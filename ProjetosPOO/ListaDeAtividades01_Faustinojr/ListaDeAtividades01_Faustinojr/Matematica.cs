using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.Crie uma classe matemática com os seguintes métodos:
a) Métodos somar, que deve receber dois valores por parâmetro e retornar a soma dos
valores;
b) Métodos maio, recebe dois valores por parâmetro e retorne o maior entre os dois, caso
seja igual retorne apenas o valor.
c) Métodos raiz quadrada, recebe por parâmetro um número e verifica e retorna a raiz
quadrada desse número.
d) Na classe Program, crie uma instância da classe matemática e realize o teste dos três
métodos acima.*/
namespace ListaDeAtividades01_Faustinojr
{
    internal class Matematica
    {
        public double valor1;
        public double valor2;
        public double resultado;

        public double Soma( double valor1, double valor2)
        {
          this.resultado=valor1 + valor2;


            return resultado;
        }

        public double Maior (double valor1, double valor2) { 
        
        if(valor1 < valor2)
            {
               return this.resultado = valor2;

            }
            else { return this.resultado=  valor1;}
        //Caso seja igual de todo modo ele retorna o valor
        
       
          }



        public double Raiz(double Valor1)
        {

           return this.resultado=Math.Sqrt(Valor1);



        }
    }
}
