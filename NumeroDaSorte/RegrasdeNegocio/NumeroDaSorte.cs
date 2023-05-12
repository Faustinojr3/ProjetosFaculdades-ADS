using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGeradorLoterias.RegrasdeNegocio
{
    internal class NumeroDaSorte
    {
        //Pega e inseri
        public int Numero { get; set; }
        public string Tipo {
            get {
                //Fazer um tratamento no set
                string resultaddo="" ;
                if (Numero == 0) { resultaddo = "Nulo"; }
                else { 
                    if (Numero % 2 != 0) { resultaddo = "Ímpar"; }
                   
                    else { resultaddo = "Par"; }
                     }
                return resultaddo;            
                }
                           }



    }
}
