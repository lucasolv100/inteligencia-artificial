using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSP.GA;
using ZedGraph;

namespace TSP
{
    public partial class Form1 : Form
    {

        Graphics g; //desenha elementos na tela
        int count = 0; //verifica a quantidade de pontos na tela
        int pointCount = 0; //sequenciador para impressão do número do ponto na tela
        Population pop;
        int evolucoes = 0;
        int i = 0;
        int itemp = 0;
        double bestAux = double.PositiveInfinity;

        private GraphPane paneMedia;
        private PointPairList mediaPopulation = new PointPairList();

        public Form1()
        {
            InitializeComponent();
            paneMedia = zedMedia.GraphPane;
            paneMedia.Title.Text = "Média da população";
            paneMedia.XAxis.Title.Text = "Evolução";
            paneMedia.YAxis.Title.Text = "Média Fitness";
            zedMedia.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            //Criar um lapis
            Pen blackPen = new Pen(Color.Red, 3);
            int x = e.X;
            int y = e.Y;

            TablePoints.addPoint(x, y);

            Rectangle rect = new Rectangle(x - 5, y - 5, 10, 10);
            g.DrawEllipse(blackPen, rect);
            g.DrawString((pointCount + 1).ToString(), new Font("Arial Black", 11), Brushes.Black, x + 3, y);
            g.DrawString("X: " + x.ToString(), new Font("Arial Black", 6), Brushes.Black, x -20, y-25);
            g.DrawString("Y: " + y.ToString(), new Font("Arial Black", 6), Brushes.Black, x - 20, y - 18);

            pointCount++;
            lbQtyCities.Text = pointCount.ToString();
            lbDifficulty.Text = Fatorial((ulong)pointCount).ToString();

            if (++count > 3)
            {
                btnPopulationGenerate.Enabled = true;
            }
            if(++count > 1)
            {
                btnClean.Enabled = true;
            }

        }

        private void plotLines(Population population, Color color)
        {
            Pen penBestIndividual = new Pen(color, 4);
            int genA, genB;

            Individual best = population.GetBestIndividual();

            for (int i = 0; i < ConfigurationGA.sizeChromossome; i++)
            {
                if (i < ConfigurationGA.sizeChromossome - 1)
                {
                    genA = best.GetGene(i);
                    genB = best.GetGene(i + 1);
                }
                else
                {
                    genA = best.GetGene(i);
                    genB = best.GetGene(0);
                }

                int[] vetA = TablePoints.getCoordinates(genA);
                int[] vetB = TablePoints.getCoordinates(genB);

                g.DrawLine(penBestIndividual, vetA[0], vetA[1], vetB[0], vetB[1]);
            }

        }

        private void plotPoints()
        {
            if (TablePoints.pointCount > 0)
            {
                for (int i = 0; i < TablePoints.pointCount; i++)
                {
                    Pen blackPen = new Pen(Color.Red, 3);
                    int[] coo = TablePoints.getCoordinates(i); //vetor de cordenadas;
                    Rectangle rect = new Rectangle(coo[0] - 5, coo[1] - 5, 10, 10);
                    g.DrawEllipse(blackPen, rect);
                    g.DrawString((i + 1).ToString(), new Font("Arial Black", 11), Brushes.Black, coo[0] + 3, coo[1]);
                    g.DrawString("X: " + coo[0].ToString(), new Font("Arial Black", 6), Brushes.Black, coo[0] - 20, coo[1] - 25);
                    g.DrawString("Y: " + coo[1].ToString(), new Font("Arial Black", 6), Brushes.Black, coo[0] - 20, coo[1] - 18);
                }
            }
        }

        public ulong Fatorial(ulong number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * Fatorial(number - 1);
            }
        }

        private void BtnPopulationGenerate_Click(object sender, EventArgs e)
        {
            ConfigurationGA.sizePopulation = int.Parse(txtPopulationSize.Text);
            ConfigurationGA.tournamentCompetitors = int.Parse(txtFight.Text);
            
            pop = new Population();
            btnExecute.Enabled = true;


            GeneticAlgorithm ag = new GeneticAlgorithm();

            Console.WriteLine(ag.Tornament(pop));
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            ConfigurationGA.sizePopulation = 0;
            count = 0;
            pointCount = 0;

            TablePoints.clear();
            pop = null;
            lbQtyCities.Text = "--";
            lbDifficulty.Text = "0";

            i = 0;
            itemp = 0;
            evolucoes = 0;
            lbEvolucoes.Text = "00";

            btnExecute.Enabled = false;
            btnPopulationGenerate.Enabled = false;
            btnClean.Enabled = false;
            g.Clear(Color.White);

            mediaPopulation.Clear();
            zedMedia.Refresh();
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            btnPopulationGenerate.Enabled = false;

            ConfigurationGA.rateCrossOver = float.Parse(txtCrossOverTax.Text);
            ConfigurationGA.rateMutation = float.Parse(txtMutationTax.Text);
            ConfigurationGA.tournamentCompetitors = int.Parse(txtFight.Text);
            evolucoes += int.Parse(txtEvolution.Text);
            
            if (rbNewInd.Checked)
            {
                ConfigurationGA.mutationType = Mutation.NewIndividual;
            }
            else if (rbPopulation.Checked)
            {
                ConfigurationGA.mutationType = Mutation.InPopulation;
            }

            if (chElitsm.Checked)
            {
                ConfigurationGA.elitism = true;
                ConfigurationGA.sizeElitism = int.Parse(txtQtyElitsm.Text);
            }
            else
            {
                ConfigurationGA.elitism = false;
            }

            GeneticAlgorithm ag = new GeneticAlgorithm();

            for (i = itemp; i < evolucoes; i++)
            {
                itemp++;
                lbEvolucoes.Text = i.ToString();
                lbEvolucoes.Refresh();

                pop = ag.ExecuteGA(pop);

                zedMedia.GraphPane.CurveList.Clear();
                zedMedia.GraphPane.GraphObjList.Clear();

                double mediaPop = pop.GetAveragePopulation();
                double bestFitness = pop.GetBestIndividual().GetFitness();

                mediaPopulation.Add(i, mediaPop);
                lbDistance.Text = bestFitness.ToString();
                lbDistance.Refresh();

                LineItem media = paneMedia.AddCurve("Média", mediaPopulation, Color.Red, SymbolType.None);

                if(i % 6 == 0 && bestFitness < bestAux)
                {
                    bestAux = bestFitness;
                    g.Clear(Color.White);
                    plotLines(pop, Color.Blue);
                    plotPoints();
                }

                zedMedia.AxisChange();
                zedMedia.Invalidate();
                zedMedia.Refresh();

            }

            g.Clear(Color.White);
            plotLines(pop, Color.Blue);
            plotPoints();

        }
    }
}
