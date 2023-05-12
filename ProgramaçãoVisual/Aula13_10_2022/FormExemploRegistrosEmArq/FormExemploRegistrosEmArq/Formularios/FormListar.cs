using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormExemploRegistrosEmArq.Formularios
{
    public partial class FormListar : Form
    {
        public FormListar()
        {
            InitializeComponent();
            CaarregarTabela();
           
        }
        private void CaarregarTabela()
        {
           
            StreamReader sr = new StreamReader("cad_veiculo.csv");
            while (!sr.EndOfStream)
            {
                string[] registro= sr.ReadLine().Split(';');
                if (registro[0]!= "ID")
                {dgvTabela.Rows.Add(registro[0],//ID
                                    registro[1],//Modelo
                                    registro[2],//Placa
                                    registro[3]//Ano
                                    );
                    
                    
                    


                }




            }
            sr.Close();
        }

       
    }
}
