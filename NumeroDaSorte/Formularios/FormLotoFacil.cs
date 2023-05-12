using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGeradorLoterias.RegrasdeNegocio;

namespace AppGeradorLoterias.Formularios
{
    public partial class FormLotoFacil : Form
    {
        List<NumeroDaSorte> listaNumeros = new List<NumeroDaSorte>();  
        public FormLotoFacil()
        {
            InitializeComponent();
            tabela.AutoGenerateColumns = false;
        }


        private void btGerar_Click(object sender, EventArgs e)
        {
            btGerar.Enabled = false;
            listaNumeros.Clear();
            int numero=0;
            int contador = 0;
            Random random = new Random();
            while (contador<15) {
                numero = random.Next(1, 26);
                //IF para verificar se a numeros iguais 
                if (listaNumeros.Count(n => n.Numero == numero) == 0)
                {
                    NumeroDaSorte num = new NumeroDaSorte();
                    num.Numero = numero;
                    listaNumeros.Add(num);
                    contador++;
                }
                

                
            
            }

            tabela.DataSource = listaNumeros.OrderBy(n => n.Numero).ToList();
            //Conectando a tabela e orden ando atravéz de ordebay 

            //Contar impares e pares
            int qtdPar= listaNumeros.Count(p=>p.Tipo=="Par");
            int qtdImpar= listaNumeros.Count(p => p.Tipo == "Ímpar");
            lbPar.Text = "PARES: " + qtdPar;
            lbImpar.Text = "IMPARES: " + qtdImpar;
            Classificar(qtdPar, qtdImpar);

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            btGerar.Enabled = true;
            listaNumeros.Clear();
            tabela.DataSource = listaNumeros;

            lbPar.Text = "PARES: 0" ;
            lbImpar.Text = "IMPARES: 0" ;
            lbClass.Text = "Classificação: ";
        }
        public void Classificar(int qtdPar, int qtdImpar)
        {
            lbClass.Text = "Classificação: Muito Baixo";
            if (qtdPar == 7 && qtdImpar == 8) lbClass.Text = "Classificação: Muito Alto";
            if (qtdPar == 8 && qtdImpar == 7) lbClass.Text = "Classificação: Alto";
            if (qtdPar == 6 && qtdImpar == 9) lbClass.Text = "Classificação: Média";
            if (qtdPar == 9 && qtdImpar == 6) lbClass.Text = "Classificação: Baixo";
           
        }
    }
}
