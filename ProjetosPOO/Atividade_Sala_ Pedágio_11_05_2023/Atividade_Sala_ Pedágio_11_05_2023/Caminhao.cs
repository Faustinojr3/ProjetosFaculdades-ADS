﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Sala__Pedágio_11_05_2023
{
    internal class Caminhao:Veiculo
    {
        public Caminhao(string placa, int qtdEixo, int tipo) :base( placa, qtdEixo, tipo)
        {
            this.placa = placa;
            this.qtdEixo = qtdEixo;
            this.tipo = tipo;
        }

        public override void CalcularPedagio()
        {
            double _eixos = Convert.ToDouble(getqtdEixo());
            double _precoPedagio = 7 * _eixos;

            _precoPedagio = _precoPedagio + ((_precoPedagio / 100) * 10);

            setPrecoPedagio(_precoPedagio);
             Desconto(); 

        }
        
    }
}
