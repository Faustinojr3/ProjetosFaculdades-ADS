using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_04_05_2022
{
    internal static class Validacoes
    {
        public static int[] cpf1 = new int[11];
        public static int cont;
        public static int soma;
        public static int dig_correto;

        public static bool ValidaCpf(string cpf)
        {

            cpf = cpf.Replace(".", "");
            cpf = cpf.Replace("-", "");
            cont = 10;
            soma = 0;

            //verificando a quantidade de caracteres            

            if (cpf.Length != 11)
            {
                return false;
            }

            for (int i = 0; i < 11; i++)
            {
                cpf1[i] = Convert.ToInt32(cpf[i].ToString());

            }

            //verificando o primeiro número veificador

            for (int i = 0; i < 9; i++)
            {

                soma = soma + (cont * cpf1[i]);

                cont--;
                
                
            }
            if (soma == 0) return false;

            if (soma % 11 < 2)
            {

                if (cpf1[9] == 0)
                {

                    soma = 0;
                    cont = 11;
                    for (int i = 0; i < 10; i++)
                    {

                        soma += cont * cpf1[i];

                        cont--;
                    }


                    if (soma % 11 < 2)
                    {
                        if (cpf1[10] == 0)
                        {
                            return true;

                        }
                    }
                    else
                    {

                        if (soma % 11 >= 2)
                        {

                            dig_correto = 11 - soma % 11;

                            if (dig_correto == cpf1[10])
                            {
                                return true;
                            }

                        }

                    }
                    return false;

                }

            }

            else
            {
                if (soma % 11 >= 2)
                {
                   dig_correto = 11 - soma % 11;

                    if (dig_correto == cpf1[9])
                    {

                        soma = 0;
                        cont = 11;
                        for (int i = 0; i < 10; i++)
                        {

                            soma += cont * cpf1[i];

                            cont--;
                        }


                        if (soma % 11 < 2)
                        {
                            if (cpf1[10] == 0)
                            {
                                return true;

                            }
                        }
                        else
                        {

                            if (soma % 11 >= 2)
                            {

                                dig_correto = 11 - soma % 11;

                                if (dig_correto == cpf1[10])
                                {
                                    return true;
                                }

                            }

                        }
                        return false;

                    }

                }
                   
            }
             return false;

        }



    }
}

