using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppExemplosUtilizandoClasses.Formularios;

namespace AppExemplosUtilizandoClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOperacoes_Click(object sender, EventArgs e)
        {
            FormReaizarOperacoes form = new FormReaizarOperacoes(); 
            form.ShowDialog();
        }

        private void btReajuste_Click(object sender, EventArgs e)
        {
            FormCalcurarReajuste form = new FormCalcurarReajuste();
            form.ShowDialog();

        }

        private void btCalcularJuros_Click(object sender, EventArgs e)
        {
            FormCalcularJuros form = new FormCalcularJuros();   
            form.ShowDialog();  
        }
    }
}
