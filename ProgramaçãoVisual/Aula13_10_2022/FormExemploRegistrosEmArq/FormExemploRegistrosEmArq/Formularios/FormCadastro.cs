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
    public partial class FormCadastro : Form
    {
        private int id; 
        public FormCadastro()
        {
            InitializeComponent();
            BuscarUltimoID();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            id++;
            StreamWriter sw = new StreamWriter("cad_veiculo.csv", true );
            string registro = id + ";" + txtModelo.Text + ";" + txtPlaca.Text.ToUpper() + ";" + txtAno.Text;

            sw.WriteLine(registro); 
            MessageBox.Show("SALVO COM SUCESSO", //MENSAGENS
                             "ADS 2P", //TITULO
                             MessageBoxButtons.OK,//BOTÕES
                             MessageBoxIcon.Information //ICONE
                             );

            sw.Close(); 
            txtAno.Clear();txtModelo.Clear(); txtPlaca.Clear();

        }

        private void BuscarUltimoID()
        {
            StreamReader sr = new StreamReader("cad_veiculo.csv");
            while (!sr.EndOfStream)
            {
                string[] registro = sr.ReadLine().Split(';');
                if (registro[0].ToUpper()!= "ID") id = Convert.ToInt32(registro[0]);
            }
            sr.Close();

            //ToUpper() PAra ler tudo em maiusculo
            
        }
        
    }
}
