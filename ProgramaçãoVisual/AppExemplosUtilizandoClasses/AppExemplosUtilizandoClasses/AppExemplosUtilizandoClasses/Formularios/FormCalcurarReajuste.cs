using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppExemplosUtilizandoClasses.RegrasDeNegocio; //Chamendo as pastas para ulizar classe
namespace AppExemplosUtilizandoClasses.Formularios { 
    public partial class FormCalcurarReajuste : Form
{
    public FormCalcurarReajuste()
    {
        InitializeComponent();
    }

    private void btCalc_Click(object sender, EventArgs e)
    {
        //Criar Objeto


        //CRiando objeto 
        Reajuste objeto = new Reajuste();

            objeto.Salario = Convert.ToDouble(TxtSalAt.Text);
            objeto.Percentual = Convert.ToDouble(txtReaju.Text);

            //Realizar o processamento=>  ação de calcular
            objeto.ReajustarSalario();

            TxtReajustado.Text= objeto.SalarioReajustado.ToString();




    }

        private void FormCalcurarReajuste_Load(object sender, EventArgs e)
        {

        }
    }
}

