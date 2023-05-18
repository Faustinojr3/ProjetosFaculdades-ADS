using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Sala__Pedágio_11_05_2023
{
    public class Utilitario: Veiculo
    {
        public Utilitario(string placa, int qtdEixo, int tipo) : base(placa, qtdEixo, tipo)
        {
            while (validacaoPlaca(placa) == true)
            {
                int cont = 0;
                if (cont == 0)
                {
                    Console.WriteLine("Placa errada!");
                }

                Console.WriteLine(" Digite: \r\n 1- para corrigir \r\n 2- Para sair ");

                try
                {
                    int op = Convert.ToInt32(Console.ReadLine());
                    if (verificador(op, 2) == true)
                    {
                        if (op == 1)
                        {
                            if (validacaoPlaca(placa) == true)
                            {
                                Console.WriteLine("Insira a placa desejada");
                                placa = Console.ReadLine();
                                this.placa = placa;
                            }
                        }
                        else { Environment.Exit(0); }
                    }
                }
                catch (Exception valorNIndetificado) { Console.WriteLine("Valor não indentificado, tente novamente."); }
                cont++;
            }
            if (validacaoPlaca(placa) == true) { this.placa = placa; }


            this.qtdEixo = qtdEixo;

            while (verificador(tipo, 3) == false)
            {
                int cont = 0; if (cont == 0) { Console.WriteLine("Tipo não indentificado tente novamente"); }
                try
                {



                    Console.WriteLine(" Digite: \r\n 1- para corrigir \r\n 2- Para sair ");

                    int op = Convert.ToInt32(Console.ReadLine());
                    if (verificador(op, 2) == true)
                    {
                        if (op == 1)
                        {
                            if (verificador(tipo, 3) == true)
                            {
                                Console.WriteLine("Insira o tipo desejado:");
                                tipo = Convert.ToInt32(Console.ReadLine());
                                this.tipo = tipo;
                            }
                        }
                        else { Environment.Exit(0); }

                    }
                }
                catch { Console.WriteLine("Tipo não indentificado tente novamente"); }
                cont++;
            }
        }
        public override void CalcularPedagio()
        {
           
            double _eixos = Convert.ToDouble(getqtdEixo());
            double _precoPedagio = 3.5 * _eixos;

            _precoPedagio = _precoPedagio + ((_precoPedagio / 100) * 2);

            setPrecoPedagio(_precoPedagio);
             Desconto(); 

        }


    }
}
