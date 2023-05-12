
using System.Data;

public class Emprestimo
{
    Livro livro;
    Pessoa pessoa;
   public DateTime DataEHoraEmpr;
    public DateTime DataEHoraDev;

    public void emprestimo(Livro l,Pessoa p, DateTime DataEmp)
    {
        if (l.status==false) {

            Console.WriteLine("Livro emprestado");

        }
        else
        {
            l.status = false;
            this.livro = l;
            this.DataEHoraEmpr = DateTime.Now;
            Console.WriteLine("Livro Disponivel");

        }
       
    }
    public void Devolucao(Livro l,Pessoa p, DateTime Devolução)
    {
        if (l.status == false)
        {
            l.status= true;
            this.livro = l;
            this.DataEHoraEmpr = DateTime.Now;
            Console.WriteLine("Livro Devolvido");

        }
        else
        {
           
            Console.WriteLine("Livro Disponivel");

        }

    }
}


    public class Livro
{
    public string titulo;
    public string autor;
    public int ano_de_lançamento;
    public bool status;
    public int código;

}

public class Pessoa
{
    public string nome;
    public string CPF;
    public string email;


}