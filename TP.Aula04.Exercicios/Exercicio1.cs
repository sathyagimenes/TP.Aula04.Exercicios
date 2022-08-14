using System;
using System.Collections;
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
    public partial class Exercicio1 : Form
    {
        ArrayList listaElementos = new ArrayList();

        public Exercicio1()
        {
            InitializeComponent();
        }

        private void Exercicio1_Load(object sender, EventArgs e)
        {
            ArrayList listaDefault = new ArrayList() { 12, 13, 123,
                23, 123, 1, 2, 123 };
            listaElementos.AddRange(listaDefault);
            foreach (var elemento in listaElementos)
            {
                lblArrayList.Text += (" " + elemento + ",");
            }
            lblArrayList.Text = lblArrayList.Text.Trim(',');
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            lblError.Text = String.Empty;
            lblArrayList.Text = String.Empty;
            listaElementos.Clear();
            txbNovaLista.Text = txbNovaLista.Text.Trim(',');
            listaElementos.AddRange(txbNovaLista.Text.Split(','));
            if (ValidateInput(listaElementos))
            {
                foreach (var elemento in listaElementos)
                {
                    lblArrayList.Text += (" " + elemento + ",");
                }
                lblArrayList.Text = lblArrayList.Text.Trim(',');
            }
        }
        private bool ValidateInput(ArrayList ArrayInserted)
        {
            int n = 0;
            foreach (string num in ArrayInserted)
            {
                if (!Int32.TryParse(num, out n))
                {
                    lblError.Text = "Lista de números inválida\n" +
                        "Exemplo de lista válida: 10, 2, 10, 3, 2";
                    ArrayInserted.Clear();
                    return false;
                }
            }
            return true;
        }
        private bool ValidateNumber(string number)
        {
            int n = 0;
            if (!Int32.TryParse(number, out n))
            {
                lblError.Text = "Número Inválido\n" +
                        "Exemplo de número válido: (10)";
                return false;
            }
            return true;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            lblError.Text = String.Empty;
            ArrayList listaIndexes = new ArrayList();
            lblListaIndex.Text = string.Empty;
            if (ValidateNumber(txbProcurar.Text))
            {
                for (int i = 0; i < listaElementos.Count; i++)
                {
                    if (Convert.ToInt32(listaElementos[i]) == Convert.ToInt32(txbProcurar.Text))
                    {
                        listaIndexes.Add(i);
                    }
                }
                if (listaIndexes.Count == 0)
                {
                    lblListaIndex.Text = "Este número não está na lista";
                }
                else
                {
                    foreach (var i in listaIndexes)
                    {
                        lblListaIndex.Text += (" " + i + ",");
                    }
                    lblListaIndex.Text = lblListaIndex.Text.Trim(',');
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
