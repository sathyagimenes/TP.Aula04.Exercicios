using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP.Aula04.Exercicios
{
    public partial class Exercicio3 : Form
    {
        List<int> listaInteiros = new List<int>();
        public Exercicio3()
        {
            InitializeComponent();
            List<int> listaDefault = new List<int>() { 1, 2, 3, -4 };
            listaInteiros.AddRange(listaDefault);
            foreach (int num in listaInteiros)
            {
                lblListaInteiros.Text += (" " + num + ",");
            }
            lblListaInteiros.Text = lblListaInteiros.Text.Trim(',');
            CalcularDiferenca(listaInteiros);
        }

        private void btnCriarLista_Click(object sender, EventArgs e)
        {
            List<string> listaString = new List<string>();
            lblError.Text = String.Empty;
            lblListaInteiros.Text = String.Empty;
            lblDiferenca.Text = String.Empty;
            listaInteiros.Clear();
            txbLista.Text = txbLista.Text.Trim(',');
            listaString.AddRange(txbLista.Text.Split(','));
            if (ValidateInput(listaString))
            {
                listaInteiros = MyConvertToInt(listaString);
                foreach (var num in listaInteiros)
                {
                    lblListaInteiros.Text += (" " + num + ",");
                }
                lblListaInteiros.Text = lblListaInteiros.Text.Trim(',');
                CalcularDiferenca(listaInteiros);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CalcularDiferenca(List<int> listaInteiros)
        {
            int min = listaInteiros.Min();
            int max = listaInteiros.Max();
            lblDiferenca.Text = Convert.ToString(max - min);
        }
        private bool ValidateInput(List<string> listaString)
        {
            int n = 0;
            foreach (string num in listaString)
            {
                if (!Int32.TryParse(num, out n))
                {
                    lblError.Text = "Lista de números inválida\n" +
                        "Exemplo de lista válida: 1, 2, 3, -4";
                    listaString.Clear();
                    return false;
                }
                else if (listaString.Count() < 2)
                {
                    lblError.Text = "Quantidade de números inválida\n" +
                        "Exemplo de lista válida: 1, 2, 3, -4";
                    listaString.Clear();
                    return false;
                }
            }
            return true;
        }
        private List<int> MyConvertToInt(List<string> lista)
        {
            List<int> ints = new List<int>();
            foreach (var elemento in lista)
            {
                ints.Add(Convert.ToInt32(elemento));
            }
            return ints;
        }

        private void gpbContagemPositivos_Enter(object sender, EventArgs e)
        {

        }
    }
}
