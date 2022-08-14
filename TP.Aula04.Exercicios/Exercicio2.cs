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
    public partial class Exercicio2 : Form
    {
        List<int> listaInteiros = new List<int>();
        public Exercicio2()
        {
            InitializeComponent();
            List<int> listaDefault = new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            listaInteiros.AddRange(listaDefault);
            foreach (int num in listaInteiros)
            {
                lblListaInteiros.Text += (" " + num + ",");
            }
            lblListaInteiros.Text = lblListaInteiros.Text.Trim(',');
            ResultadoPositivosNegativos(listaInteiros);
        }

        private void lblEnunciado_Click(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            List<string> listaString = new List<string>();
            lblError.Text = String.Empty;
            lblListaInteiros.Text = String.Empty;
            lblContagemPositivos.Text = String.Empty;
            lblSomaNegativos.Text = String.Empty;
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
                ResultadoPositivosNegativos(listaInteiros);
            }
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
        private bool ValidateInput(List<string> listaString)
        {
            int n = 0;
            foreach (string num in listaString)
            {
                if (!Int32.TryParse(num, out n))
                {
                    lblError.Text = "Lista de números inválida\n" +
                        "Exemplo de lista válida: 10, 2, -10, 3, -2";
                    listaString.Clear();
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ResultadoPositivosNegativos(List<int> listaInteiros)
        {
            List<int> listaPositivos = new List<int>();
            List<int> listaNegativos = new List<int>();
            foreach (int numero in listaInteiros)
            {
                if (numero > 0)
                {
                    listaPositivos.Add(numero);
                }
                else if (numero < 0)
                {
                    listaNegativos.Add(numero);
                }
            }
            lblContagemPositivos.Text = Convert.ToString(listaPositivos.Count());
            lblSomaNegativos.Text = Convert.ToString(listaNegativos.Sum());
        }
    }
}
