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
    public partial class FormConsultar : Form
    {
        public FormConsultar()
        {
            InitializeComponent();
        }

       private void BuscarVeículo()
        {
            int cont = 0; // Contar os clientes encontrados 
            StreamReader sr = new StreamReader("cad_veiculo.csv");
            while(!sr.EndOfStream)
            {
                string[] registro = sr.ReadLine().Split(';');
                if (registro[0] != "ID")
                {
                    if (registro[1].ToUpper()==txtModelo.Text.ToUpper())
                    {
                        dgvTabela.Rows.Add(registro[0], //ID
                                           registro[1], //Modelo
                                           registro[2] // Ano
                                           );
                        cont++;
                    }

                }

                }
            sr.Close();
            if (cont == 0)    MessageBox.Show("Não Encontrado",//Mensagens
                                              "ADS 2P",
                                              MessageBoxButtons.OK,//Botões
                                              MessageBoxIcon.Information//ícone
                                              );

      
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Clear();
            BuscarVeículo();
        }
    }
}
