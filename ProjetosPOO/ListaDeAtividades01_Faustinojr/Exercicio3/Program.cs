/*3.Crie uma classe Empregado que possui os seguintes atributos: nome, salário, data de
admissão. Todos os atributos devem ser privados e possuírem os métodos sets e gets.
a) Construa o método construtor para obrigar a inserir todos os atributos do objeto.
b) Construa um método que realize o aumento de salário do funcionário, esse método deve
receber por parâmetro a porcentagem do aumento.
c) Construa um atributo estático na classe Empregado que deve armazenar o valor das
somas dos salários dos funcionários. Caso algum funcionário receber aumento, o valor
desse atributo deve ser atualizado (esse atributo é necessário para verificar quantos de
funcionário a empresa está pagando por mês).
*/

using Exercicio3;

Empregado empregado = new Empregado("rafael", 1000, new DateOnly(2023,06,25));

Console.WriteLine(empregado.GetNome());

Console.WriteLine(empregado.GetsomaSalario());

Empregado empregado1 = new Empregado("Douglas", 5000, new DateOnly(2023, 06, 25));

Console.WriteLine(empregado1.GetNome());

Console.WriteLine(empregado1.GetsomaSalario());

empregado1.aumento(100);

Console.WriteLine(empregado1.GetsomaSalario());