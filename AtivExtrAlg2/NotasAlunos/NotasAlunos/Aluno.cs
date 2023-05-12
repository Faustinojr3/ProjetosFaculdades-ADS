using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasAlunos
{
    public class Aluno
    {
        public string Nome;
       public int Matricula;
        public string Curso;
        public int QuantidadeDisc;
        public string[] Disciplina;
        public double [,]  NotasDisc;
        public Aluno? prox, ant;
        public double[] Soma;
        public double[] Medias;





    }
}
