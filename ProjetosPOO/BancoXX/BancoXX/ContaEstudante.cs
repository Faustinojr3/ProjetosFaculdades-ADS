using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXX
{
    internal class ContaEstudante:Conta
    {/*  A conta para estudante possui todos os atributos de uma conta, além de um limite de
cheque especial. A operação de sacar nesse tipo de conta pode exceder o saldo em
conta até o limite do cheque especial. Além disso, esse tipo de conta possui o CPF e o
nome da instituição de ensino a qual o cliente/estudante está vinculado.  */

        private double limiteChequeEspecial;
        private string cpf;
        private string nomeInstituicao;

        public ContaEstudante(int nConta, string agencia, string titular, string cpf, string nomeinstrutor) : base(nConta, agencia, titular)
        {
            this.cpf = cpf;
            this.nomeInstituicao = nomeinstrutor;

            limiteChequeEspecial = 1000;
        }
       
        public override void Sacar(double valor)
        {
            if (valor <= limiteChequeEspecial+saldo) { 
               if(saldo-valor==0) { saldo = saldo - valor; }                
               if(saldo-valor<0 && valor<saldo+limiteChequeEspecial) {
                    
                    valor = valor - saldo;
                    
                   
                    if (valor > 0) { 
                        limiteChequeEspecial = limiteChequeEspecial - valor;
                        saldo -= valor; 
                    }
                
                }
            
            
            
            }
            else { Console.WriteLine("Valor acima do disponível"); }


        }

        //gets
        public double getLimiteChequeEspecial() { return limiteChequeEspecial; }
        public string getCpf() { return cpf;}
        public string getNomeInstituicao() {  return nomeInstituicao;}


        //sets

        public void setLimiteChequeEspescial(double limiteChequeEspecial) { this.limiteChequeEspecial = limiteChequeEspecial; }
        public void setCpf(string cpf) {  this.cpf = cpf;}
        public void setNomeInstituicao(string nomeInstituicao) { this.nomeInstituicao = nomeInstituicao;}
    }
}
