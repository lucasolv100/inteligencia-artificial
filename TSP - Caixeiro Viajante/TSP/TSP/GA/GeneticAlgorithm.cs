using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.GA
{
    public class GeneticAlgorithm
    {
        private double MutationRate;
        private double CrossOverRate;

        public delegate Individual[] CrossOver(Individual father, Individual mother);
        public CrossOver crossover;
        public delegate Individual Selection(Population pop);
        public Selection selection;

        public GeneticAlgorithm()
        {
            crossover = CrossOverPMX;
            //selection = Selection.tornaiment;
            CrossOverRate = ConfigurationGA.rateCrossOver;
            MutationRate = ConfigurationGA.rateMutation;

        }

        public Population ExecuteGA(Population pop)
        {
            //criar a população
            //avaliar a população
            //verificar se utilizara elitismo
            //seleção dos pais
            //cruzamento dos pais
            //mutação
            //avaliação da população
            //inserir na nova população
            return null;
        }

        public Individual[] CrossOverPMX(Individual father, Individual mother)
        {
            //variavel de retorno
            Individual[] newInd = new Individual[2];

            int[] parent1 = new int[ConfigurationGA.sizeChromossome];
            int[] parent2 = new int[ConfigurationGA.sizeChromossome];

            int[] offSpringArray1 = new int[ConfigurationGA.sizeChromossome];
            int[] offSpringArray2 = new int[ConfigurationGA.sizeChromossome];

            int[] replacement1 = new int[ConfigurationGA.sizeChromossome];
            int[] replacement2 = new int[ConfigurationGA.sizeChromossome];

            //Seleção dos pontos para cruzamento
            int firstPoint = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromossome -1);
            int secondPoint = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromossome - 1);

            if(firstPoint == secondPoint)
                secondPoint = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromossome - 1);

            if(secondPoint < firstPoint)
            {
                int temp = firstPoint;
                firstPoint = secondPoint;
                secondPoint = temp;
            }

            Console.WriteLine("Ponto 1: " + firstPoint);
            Console.WriteLine("Ponto 2: " + secondPoint);

            newInd[0] = new Individual();
            newInd[1] = new Individual();

            //transferir os genes para os pais
            for (int i = 0; i < ConfigurationGA.sizeChromossome; i++)
            {
                parent1[i] = offSpringArray1[i] = father.GetGene(i);
                parent2[i] = offSpringArray2[i] = mother.GetGene(i);
            }

            //popular o replacement para valores abaixo de 0
            for (int i = 0; i < ConfigurationGA.sizeChromossome; i++)
            {
                replacement1[i] = replacement2[i] = -1;
            }

            //passo de cruzamento
            for (int i = firstPoint; i <= secondPoint; i++)
            {
                offSpringArray1[i] = parent2[i];
                offSpringArray2[i] = parent1[i];

                replacement1[parent2[i]] = parent1[i];
                replacement2[parent1[i]] = parent2[i];
            }

            //troca de genes repetidos

            for (int i = 0; i < ConfigurationGA.sizeChromossome; i++)
            {
                if ((i >= firstPoint) && (i <= secondPoint))
                    continue;

                int n1 = parent1[i];
                int m1 = replacement1[n1];

                int n2 = parent2[i];
                int m2 = replacement2[n2];

                while (m1 != -1)
                {
                    n1 = m1;
                    m1 = replacement1[n1];
                }
                while (m2 != -1)
                {
                    n2 = m2;
                    m2 = replacement2[n2];
                }

                offSpringArray1[i] = n1;
                offSpringArray2[i] = n2;
            }

            for (int i = 0; i < ConfigurationGA.sizeChromossome; i++)
            {
                newInd[0].SetGene(i, offSpringArray1[i]);
                newInd[1].SetGene(i, offSpringArray2[i]);
            }

            newInd[0].CalcFitness();
            newInd[1].CalcFitness();


            return newInd;
        }

        public Individual Mutation(Individual ind)
        {
            //verifica se vai mutar
            if(ConfigurationGA.random.NextDouble() <= MutationRate)
            {
                //mutação tipo swap
                int genePosition1 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromossome -1);
                int genePosition2 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromossome - 1);

                if(genePosition1 == genePosition2)
                {
                    if(genePosition2 < ConfigurationGA.sizeChromossome -2)
                    {
                        genePosition2++;
                    }
                }

                ind.Mutate(genePosition1, genePosition2);
            }

            return ind;
        }

        public Population MutationPopulation(Population pop)
        {
            for (int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                //verifica se vai mutar
                if (ConfigurationGA.random.NextDouble() <= MutationRate)
                {
                    //mutação tipo swap
                    int genePosition1 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromossome - 1);
                    int genePosition2 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromossome - 1);

                    if (genePosition1 == genePosition2)
                    {
                        if (genePosition2 < ConfigurationGA.sizeChromossome - 2)
                        {
                            genePosition2++;
                        }
                    }
                    else
                    {
                        genePosition2 -= -2;
                    }

                    pop.GetPopulation()[i].Mutate(genePosition1, genePosition2);
                }
            }

            return pop;
        }

        public Individual Tornament(Population pop)
        {
            return null;
        }
    }
}
