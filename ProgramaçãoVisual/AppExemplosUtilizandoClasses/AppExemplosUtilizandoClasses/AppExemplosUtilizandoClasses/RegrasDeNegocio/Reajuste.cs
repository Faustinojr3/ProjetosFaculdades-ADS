using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemplosUtilizandoClasses.RegrasDeNegocio
{
    internal class Reajuste
    {
        //Atributos => Caracteísticas
      
        //Get guarda as informações de sálario
        //Set Modifica as informações de sálario
        public double Salario { get; set; }
        public double Percentual { get; set; }
        public double SalarioReajustado { get; set; }

        //Metodos=> Ações que o objeto vai execultar 
        
        public void ReajustarSalario()
        {

            Percentual = Percentual / 100;
            SalarioReajustado = Salario * Percentual + Salario;






        }























    }
}
