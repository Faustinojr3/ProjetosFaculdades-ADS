/*2.Crie uma classe terreno que possui os seguintes atributos: largura, comprimento. Os
atributos devem ser privados e serem acessados por meio de encapsulamento. Além
disso, a classe deve possuir um método construtor que obriga informar os valores dos
atributos na criação do objeto.
a) Crie um método que calcule e retorne a área desse terreno.
b) Crie um método que recebe por parâmetro o valor por metro² e retorne o valor estimado
do terreno*/

using Exercicio2;


Terreno terreno= new Terreno(50,60);

Console.WriteLine( terreno.Area()+ "m²");

Console.WriteLine( "R$"+terreno.valor(2.5));



