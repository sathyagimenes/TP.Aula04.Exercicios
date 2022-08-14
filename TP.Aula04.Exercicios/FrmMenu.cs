﻿using System;
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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            Exercicio1 tela1 = new Exercicio1();
            tela1.ShowDialog();
        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            Exercicio4 tela4 = new Exercicio4();
            tela4.ShowDialog();
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            Exercicio2 tela2 = new Exercicio2();
            tela2.ShowDialog();
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            Exercicio3 tela3 = new Exercicio3();
            tela3.ShowDialog();
        }
    }
}
