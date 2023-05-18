using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Sala__Pedágio_11_05_2023
{
    public class Passeio : Veiculo
    {
        public Passeio(string placa, int qtdEixo, int tipo) : base(placa, qtdEixo, tipo)
        {
            this.placa = placa;
            this.qtdEixo = qtdEixo;
            this.tipo = tipo;
        }

        public override void CalcularPedagio()
        {
            double _eixos = Convert.ToDouble(getqtdEixo());
            double _precoPedagio = 3 * _eixos;

            setPrecoPedagio(_precoPedagio);
             Desconto(); 
        }

        
    }
}
