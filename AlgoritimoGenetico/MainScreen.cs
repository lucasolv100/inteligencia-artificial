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
using ZedGraph;

namespace AlgoritimoGenetico
{
    public partial class MainScreen : Form
    {
        private Population population;
        private GraphPane panePopulation;
        private GraphPane paneAveragePopulation;

        private PointPairList graphicCurve = new PointPairList();
        private PointPairList graphicPopulation = new PointPairList();
        private PointPairList graphicAveragePopulation = new PointPairList();

        public MainScreen()
        {
            InitializeComponent();
            btnAGBegin.Enabled = false;

            panePopulation = zedPopulation.GraphPane;
            panePopulation.Title.Text = "Evolução";
            panePopulation.XAxis.Title.Text = "Gerações";
            panePopulation.YAxis.Title.Text = "Individuos";
            zedPopulation.Refresh();

            paneAveragePopulation = zedPopulationAverage.GraphPane;
            paneAveragePopulation.Title.Text = "Média População";
            paneAveragePopulation.XAxis.Title.Text = "Gerações";
            paneAveragePopulation.YAxis.Title.Text = "Média Fitness";
            zedPopulationAverage.Refresh();

            for (int i = 0; i < Constants.functionXSize; i++)
            {
                graphicCurve.Add(i, Constants.Function1(i));
            }

            LineItem func = panePopulation.AddCurve("Função", graphicCurve, Color.Red, SymbolType.None);
            //LineItem func = panePopulation.AddCurve("Função", graphicCurve, Color.Red, SymbolType.None);
            zedPopulation.AxisChange();
            zedPopulation.Invalidate();
            zedPopulation.Refresh();

            zedPopulationAverage.AxisChange();
            zedPopulationAverage.Invalidate();
            zedPopulationAverage.Refresh();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void BtnPopulationGenerate_Click(object sender, EventArgs e)
        {
            btnAGBegin.Enabled = true;
            population = new Population();
            graphicPopulation = new PointPairList();

            for (int i = 0; i < Constants.sizePopulation; i++)
            {
                graphicPopulation.Add(population.GetPopulation()[i].getInt(), population.GetPopulation()[i].GetFitness());
            }

            LineItem inds = panePopulation.AddStick("Individuos", graphicPopulation, Color.Blue);
            zedPopulation.AxisChange();
            zedPopulation.Invalidate();
            zedPopulation.Refresh();
        }

        private void BtnAGBegin_Click(object sender, EventArgs e)
        {
            double crossOver = double.Parse(txtCrossOverMask.Text);
            double mutationTax = double.Parse(txtMutation.Text);
            double evolution = double.Parse(txtEvolution.Text);
            Console.Write(mutationTax.ToString() + "\n");
            Console.Write(crossOver.ToString() + "\n");
            Console.Write(evolution.ToString() + "\n");

            GeneticAlgorithm ga = new GeneticAlgorithm(
                crossOver,
                mutationTax
            );

            for (int i = 0; i < evolution; i++)
            {
                population = ga.Execute(population);

                graphicAveragePopulation.Add(i, population.GetPopulationAverage());

                zedPopulationAverage.GraphPane.CurveList.Clear();
                zedPopulationAverage.GraphPane.GraphObjList.Clear();

                zedPopulation.GraphPane.CurveList.Clear();
                zedPopulation.GraphPane.GraphObjList.Clear();

                graphicPopulation = new PointPairList();

                for (int j = 0; j < Constants.sizePopulation; j++)
                {
                    graphicPopulation.Add(population.GetPopulation()[j].getInt(), population.GetPopulation()[j].GetFitness());
                }

                LineItem media = paneAveragePopulation.AddCurve("Média", graphicAveragePopulation, Color.Red, SymbolType.None);
                LineItem func = panePopulation.AddCurve("Função", graphicCurve, Color.Red, SymbolType.None);
                LineItem inds = panePopulation.AddStick("Individuo", graphicPopulation, Color.Red);

                zedPopulation.AxisChange();
                zedPopulation.Invalidate();
                zedPopulation.Refresh();

                zedPopulationAverage.AxisChange();
                zedPopulationAverage.Invalidate();
                zedPopulationAverage.Refresh();
            }

            population.OrderPopulation();

            string worstInds = string.Empty;

            for (int i = 0; i < 10; i++)
            {
                worstInds += population.GetPopulation()[i].PrintIndividual() + "\n";
            }

            string best = string.Empty;

            for (int i = Constants.sizePopulation -1; i > Constants.sizePopulation -11 ; i--)
            {
                best += population.GetPopulation()[i].PrintIndividual() + "\n";
            }

            txtBestIndividuals.Text = best;
            txtWorstIndividuals.Text = worstInds;
        }
    }
}
