using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Sala__Pedágio_11_05_2023
{
    public abstract class Veiculo
    {
        protected string placa;
        protected string tipo_de_placa;
        protected int qtdEixo;
        protected int tipo;
        protected double precoPedagio;
        protected double valorFinal;



        public abstract void CalcularPedagio();


        public Veiculo( string placa, int qtdEixo, int tipo)
        { 
            
            
            
                while (validacaoPlaca(placa) == true)
                {
                int cont=0;
                if (cont == 0)
                {
                    Console.WriteLine("Placa errada!");
                }

                Console.WriteLine(" Digite: \r\n 1- para corrigir \r\n 2- Para sair ");
                
                try {
                    int op = Convert.ToInt32(Console.ReadLine());
                    if (verificador(op, 2)== true)
                    {
                        if (op == 1) { if (validacaoPlaca(placa)==true){
                                Console.WriteLine("Insira a placa desejada");
                               placa= Console.ReadLine(); 
                                this.placa = placa; } }
                        else { Environment.Exit(0); }
                    } 
                   } 
                catch (Exception valorNIndetificado) { Console.WriteLine("Valor não indentificado, tente novamente."); }
                cont++;
                }
            if (validacaoPlaca(placa) == true) { this.placa = placa; }


            this.qtdEixo= qtdEixo;

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
        public void Desconto()
        {
            double _precoPedagio = getPrecoPedagio();
            if (getTipo() >= 2 && getTipo() <= 3)
            {
                if (getTipo() == 3) { setPrecoPedagio(0); }
                else
                {
                    _precoPedagio = _precoPedagio - ((_precoPedagio / 100) * 5);
                    setValorFinal(_precoPedagio);
                }
            }
            else { setValorFinal(getPrecoPedagio()); }
        }

        public static bool validacaoPlaca(string _placa)
        {
            string [] _placas = new string[7];
            _placa= _placa.Trim();
            _placa= _placa.Replace("-","");
            
            if(_placa.Length != 7)
            {
                return false;
            }
            if (_placa == "0000000") { return false; }

            var placas0 = int.TryParse(_placa, out var _placas0);
            if(placas0== true) { return false; }

            for(int i = 0; i < _placa.Length; i++)
            {
                _placas[i]= Convert.ToString(_placa[i]);

            }

            for (int i = 0;i < _placas.Length; i++)
            {

                var dig = int.TryParse(_placas[i], out var verdig);
                if (dig == false) { return false; }

                if (i < 5)
                {
                    


                    if (i < 4)
                    {
                        var dig4 = int.TryParse(_placas[i], out var verdig4);
                        if (dig == false) { return false; }

                    }
                    else {
                        if (i < 3)
                        {
                            var dig3 = int.TryParse(_placas[i], out var verdig3);
                            if (dig3 == true) { return false; }
                        }
                    }

                }

            }
            return true;
        }

        public void tipoPlaca()
        {
           
            string _placa = getPlaca();         
            _placa = _placa.Trim();
            _placa = _placa.Replace("-", "");
  
             string _placas = Convert.ToString(_placa[4]);

            var dig5 = int.TryParse(_placas, out var _verdig5);

            if (dig5== false) { setTipo_de_placa( "Placa Mercosul"); }
            else {  setTipo_de_placa( "Placa Antiga"); }
        }

        public static bool verificador(int tester, int ops)
        {  
            for (int i = 0; i < ops; i++){
                if (tester== i)return true;
            }
            Console.WriteLine("Opção não encontrada!");
            return false;
        }


        //Gets
        public string getPlaca() { return placa; }
        public int getqtdEixo() { return qtdEixo; }
        public int getTipo() {  return tipo; }
        public double getPrecoPedagio() {  return precoPedagio; }
        public double getValorFinal() {  return valorFinal; }
        public string getTipo_de_placa() { return tipo_de_placa; }

        //Sets
        public void setPlaca( string placa) { this.placa = placa; }
        public void setQtdEixo(int qtdEixo) { this.qtdEixo = qtdEixo; }
        public void setTipo(int tipo){this.tipo = tipo;}
        public void setPrecoPedagio(double precoPedagio) { this.precoPedagio = precoPedagio; }
        public void setValorFinal(double valorFinal) { this.valorFinal = valorFinal; }

        public void setTipo_de_placa(string _tipo_de_placa) { this.tipo_de_placa = _tipo_de_placa; }
        
       



    }
}
