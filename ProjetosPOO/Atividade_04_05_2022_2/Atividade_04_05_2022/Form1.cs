using System.Security.Cryptography.X509Certificates;

namespace Atividade_04_05_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {



            if (Validacoes.ValidaCpf(txtCPF.Text) == true)
            {

                Pessoa ps = new Pessoa(txtIdade.Text, txtNome.Text, txtPeso.Text, txtCPF.Text, txtSexo.Text, txtAltura.Text);
                ps.Classificacoes();
            }
            else
            {
                MessageBox.Show("              CPF INVÁLIDO!        \r\n cpf inválido favor verificar o mesmo ");

            }



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}