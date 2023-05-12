using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_dia_02_03_2023
{
    internal class Voos
    {
        public DateOnly Data_do_voo;
        public TimeOnly Horario_do_voo;
        public bool[] Assentos= new bool[100];

        public Voos Dados_do_voo(DateOnly data_do_voo, TimeOnly horario_do_voo)
        {
            this.Data_do_voo= data_do_voo;
            this.Horario_do_voo = horario_do_voo;

            return this; }

        public int ProximoLivre (int i)
        {
            i = 0;
            do
            {
                if (Assentos[i] ==true) {
                    i++;


                }
                else
                {
                    Assentos[i] = false;

                }

                return i;

            } while (Assentos[i] =false);


        }
        public void Verifica(int i)
        {
            if (Assentos[i] == false)
            {
                Console.WriteLine("Assento Livre");
            }
            else { Console.WriteLine("Assento ocupado"); }

            //Fazer no metódo get set
        }

        public void Ocupa(int i)
        {
            Assentos[i]= true;
   

        }

        public bool Vagas()
        {
            for (int i; Assentos[i]==false; i++)
            {


                int vagas;
                return vagas= i -100;
            }
        }
    }
}
