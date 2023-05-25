using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace BancoXX
{
    /* Esse tipo de conta também possui uma ação para realizar
 empréstimo, a qual deve receber um valor de empréstimo e verificar se o cliente
 possui limites para realizar tal empréstimo  
    Caso o cliente possui tal permissão, o
 saldo da conta e o total de empréstimo devem incrementar o valor de empréstimo e
 apresentar a mensagem dizendo que o empréstimo foi realizado com sucesso. Caso o
 cliente não possui tal permissão (pois o limite de empréstimo se excede com o valor),
 o sistema deve apresentar a mensagem dizendo que o valor de empréstimo não pode
 ser concedido. Por fim, a conta para empresa possui uma taxa para saques acima de
 R$ 5000,00 que é de R$ 5,00. */

    internal class ContaEmpresarial:Conta
    {
        private double anuidade;
        private double limiteEmprestimo; 
        private double  totalEmprestimo;

        public ContaEmpresarial(int nConta, string agencia, string titular):base(nConta, agencia, titular)
        {
            anuidade = 50;
            saldo = saldo - anuidade;
          
            limiteEmprestimo = 2000;
        }
        public void fazerEmprestimo(double valor)
        {
            if (valor > 0)
            {
                if (valor <= limiteEmprestimo && limiteEmprestimo > totalEmprestimo)
                {

                    if (valor + totalEmprestimo <= limiteEmprestimo)
                    {
                        saldo += valor;
                        totalEmprestimo += valor;
                        limiteEmprestimo -= totalEmprestimo;
                    }

                }
            }
        }

        public override void Sacar(double valor)
        {
            if (valor > 0)
            {

                if (valor <= saldo)
                {

                    if (valor >= 5000 && (saldo - (valor + 5) >= 0))
                    {
                        saldo -= (valor + 5);
                    }
                    else
                    {

                        if (valor < 5000) { saldo -= valor; }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Valor acima do disponível");
                            Console.ReadKey();
                        }
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Valor acima do disponível");
                    Console.ReadKey();
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Valor negativo!");
                Console.ReadKey();

            }
        }

        public double getAnuidade() { return anuidade; }
        public double getLimiteEmprestimo() {  return limiteEmprestimo; }
        public double getTotalEmprestimo() { return totalEmprestimo; }

        public void setAnuidade(double anuidade) { this.anuidade = anuidade; }
        public void setLimiteEmprestimo(double limiteEmprestimo) { this.limiteEmprestimo=limiteEmprestimo; }

        public void setTotalEmprestimo(double totalEmprestimo) { this.totalEmprestimo=totalEmprestimo; }
    }
}
