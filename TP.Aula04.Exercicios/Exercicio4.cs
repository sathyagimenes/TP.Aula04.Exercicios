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
    public partial class Exercicio4 : Form
    {
        List<int> listaInteiros = new List<int>();
        public Exercicio4()
        {
            InitializeComponent();
            List<int> listaDefault = new List<int>() { 2, 4, -1, -3 };
            listaInteiros.AddRange(listaDefault);
            foreach (int num in listaInteiros)
            {
                lblListaInteiros.Text += (" " + num + ",");
            }
            lblListaInteiros.Text = lblListaInteiros.Text.Trim(',');
            EncontrarProxZero(listaInteiros);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exercicio4_Load(object sender, EventArgs e)
        {

        }

        private void btnCriarLista_Click(object sender, EventArgs e)
        {
            List<string> listaString = new List<string>();
            lblError.Text = String.Empty;
            lblListaInteiros.Text = String.Empty;
            lblProxZero.Text = String.Empty;
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
                EncontrarProxZero(listaInteiros);
            }
        }
        private bool ValidateInput(List<string> listaString)
        {
            int n = 0;
            foreach (string num in listaString)
            {
                if (!Int32.TryParse(num, out n))
                {
                    lblError.Text = "Lista de números inválida\n" +
                        "Exemplo de lista válida: 2, 4, -1, -3";
                    listaString.Clear();
                    return false;
                }
            }
            return true;
        }
        private void EncontrarProxZero(List<int> lista)
        {
            List<int> positivos = new List<int>();
            List<int> negativos = new List<int>();
            foreach (int i in lista)
            {
                if (i >= 0)
                    positivos.Add(i);
                else
                    negativos.Add(i);
            }
            if (negativos.Count() <= 0)
            {
                positivos.Sort();
                lblProxZero.Text = Convert.ToString(positivos.Min());
            }
            else if (positivos.Count <= 0)
            {
                negativos.Sort();
                lblProxZero.Text = Convert.ToString(negativos.Max());
            }
            else
            {
                positivos.Sort();
                negativos.Sort();
                if (positivos.Min() == (-1 * negativos.Max()))
                {
                    lblProxZero.Text = "Nenhum";
                }
                else if (positivos.Min() > (-1 * negativos.Max()))
                {
                    lblProxZero.Text = Convert.ToString(negativos.Max());
                }
                else
                {
                    lblProxZero.Text = Convert.ToString(positivos.Min());
                }
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
    }
}
