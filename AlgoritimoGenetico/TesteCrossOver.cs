﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgoritimoGenetico.Class;

namespace AlgoritimoGenetico
{
    public partial class TesteCrossOver : Form
    {
        public TesteCrossOver()
        {
            InitializeComponent();
        }

        private void BtnCrossOver_Click(object sender, EventArgs e)
        {
            GeneticAlgorithm ag = new GeneticAlgorithm(0.8f, 0);
            Individual ind1 = new Individual();
            Individual ind2 = new Individual();

            txtInd1.Text = ind1.PrintIndividual();
            txtInd2.Text = ind2.PrintIndividual();

            Individual[] children = ag.CrossOverIndividual(
                ind1,
                ind2
            );

            txtIndCross1.Text = children[0].PrintIndividual();
            txtIndCross2.Text = children[1].PrintIndividual();
        }
    }
}
