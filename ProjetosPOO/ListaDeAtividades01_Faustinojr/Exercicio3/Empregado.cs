using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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

namespace Exercicio3
{
    internal class Empregado
    {
        private string nome;
        private double salario;
        private DateOnly data_de_admissao;
        static double somaSalarios=0;

        public double GetsomaSalario()
        {

            return somaSalarios;
        }

        public string GetNome()
        {

            return nome;
        }

        public double GetSalario()
        {

            return salario;
        }

        public DateOnly GetData_de_admissao()
        {

            return data_de_admissao;
        }

         void Setnome(string nome)
        {
            this.nome= nome;

        }

        void SetSalario(double salario)
        {
            this.salario = salario;

        }

        void SetData_de_admisao(DateOnly data_de_admissao)
        {
            this.data_de_admissao = data_de_admissao;

        }

        public Empregado(string nome, double salario, DateOnly data_de_admisao){

         this.nome= nome ;           
        this.salario= salario ;
            this.data_de_admissao= data_de_admissao ;

            somaSalarios= this.salario+ somaSalarios;
        }

        public double aumento( double porcentagem)
        {
            somaSalarios = somaSalarios+((this.salario / 100) * porcentagem);
            return this.salario= ((this.salario / 100) * porcentagem)+this.salario;
            

        }

      


    }
}
