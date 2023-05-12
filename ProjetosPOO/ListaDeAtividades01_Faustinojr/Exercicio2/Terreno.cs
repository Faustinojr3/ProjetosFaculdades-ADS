using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{/*2.Crie uma classe terreno que possui os seguintes atributos: largura, comprimento. Os
atributos devem ser privados e serem acessados por meio de encapsulamento. Além
disso, a classe deve possuir um método construtor que obriga informar os valores dos
atributos na criação do objeto.
a) Crie um método que calcule e retorne a área desse terreno.
b) Crie um método que recebe por parâmetro o valor por metro² e retorne o valor estimado
do terreno*/

    internal class Terreno
    {
        private double largura;
        private double altura;
        public double area;

        public Terreno(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;


        }
       
        public double Area() { 
        
        return this.area = this.largura*this.altura;
        
        
        }
        
    
       public double valor(double valor)
       {

           return this.area*valor;
       }

       


}
}

