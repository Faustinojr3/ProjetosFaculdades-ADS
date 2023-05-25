using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXX
{
    internal class Conta
    { /*Além disso, as contas possuem as operações de saque (que verifica se há saldo
suficiente) e depósito. O banco possui dois tipos de contas diferenciadas, conta para
estudante e conta para empresa*/

        private int nConta;
        private string agencia;
        private string titular;
        protected double saldo;

        public Conta(int nConta, string agencia, string titular)
        {

            this.nConta = nConta;
            this.agencia = agencia;
            this.titular = titular;

            saldo = 1000;
        }
        public virtual void Sacar(double valor)
        {
            if (valor > 0)
            {
                if (valor <= saldo) { saldo = saldo - valor; }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Valor acima do disponível");
                    Console.ReadKey();
                }
                }
            else { Console.Clear();
                Console.WriteLine( "Valor negativo!");
                Console.ReadKey();

            }

        }
        public void Depositar(double valor) {

            if (valor > 0)
            {
                saldo = saldo + valor;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Valor negativo!");
                Console.ReadKey();

            }
        }



        //gets
        public int getNConta()
        {
         return nConta;
        }

        public string getAgencia()
        {
            return agencia;
        }

        public double getSaldo()
        {
            return saldo;
        }
        public string getTitular()
        {
            return titular;
        }

        //sets
        public void setNConta(int nConta) {
        this.nConta = nConta;
        }

        public void setAgencia(string agencia)
        {
            this.agencia = agencia;
        }
        
        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        public void setTitular(string titular)
        {
            this.titular = titular;
        }

    }
}
