using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_04_05_2022
{
    internal class Pessoa
    {
        private int idade;
        private string nome;
        private double peso;
        private string cpf;
        public string sexo;
        public double altura;


        public Pessoa (string idade, string nome, string peso, string cpf, string sexo, string altura) {
        
        this.idade= Convert.ToInt32(idade);
        this.nome=nome  ;
        this.peso=Convert.ToDouble(peso);
        this.cpf=cpf;
        this.altura=Convert.ToDouble(altura);
        this.sexo=sexo;
        
        }

        public double IMC()
        {
        double IMC = this.peso / (this.altura*this.altura);

            return IMC;

        }
        
        public void Classificacoes() {

           double imc=  IMC();

           if (imc <= 29.9)
            {
                if (imc > 25.0) { MessageBox.Show( imc + "    SOBREPESO - Obesidae grau I" ); }
                else {

                if(imc > 18.5) {
                    MessageBox.Show(imc+ "    NORMAL - Obesidade grau 0");
                }
                else { MessageBox.Show(imc + "   Magreza - Obesidade grau 0"); }

                }
            }
            else
            {
                if (imc <= 39.9)
                {
                    MessageBox.Show(imc + "   Obesidade - Obesidade grau II");

                }
                else
                {
                    MessageBox.Show(imc + "   Obesidade Grave - Obesidade grau III");

                }

            }
        
        
        }

        //Metodos get
        public int getIdade(int idade)
        {
            return this.idade=idade;
          
        }

        public string getNome(string nome )
        {
            return this.nome = nome;

        }

        public double getPeso(int peso)
        {
            return this.peso = peso;

        }

        public string getCpf(string cpf)
        {
            return this.cpf = cpf;

        }

        public string getSexo(string sexo)
        {
            return this.sexo = sexo;

        }

        public double getAltura(double altura)
        {
            return this.altura = altura;

        }
        //Metodos sets

        void setIdade(int idade) {
            this.idade = idade;
        }

        void setNome(string nome)
        {
            this.nome = nome;

        }
        void setPeso(double peso) {
        this.peso= peso;
        }
        void setCpf(string cpf) {
        this.cpf= cpf;

        }
        void setSexo(string sexo) {
        this.sexo= sexo;
        }
        void setAltura(double altura) {
        this.altura= altura;
        }
        
        

    }
}
