using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimoGenetico.Class
{
    public class GeneticAlgorithm
    {
        private double CrossOverTax;
        private double MutationTax;


        public GeneticAlgorithm(double crossOverTax, double mutationTax)
        {
            CrossOverTax = crossOverTax;
            MutationTax = mutationTax;
        }

        public Population Execute(Population population)
        {
            //Inicio
            //Avaliação da população
            Population newPopulation = new Population();
            List<Individual> indBuffer = new List<Individual>();

            for (int i = 0; i < Constants.sizePopulation / 2; i++)
            {
                //selecionar pais para cruzamento
                Individual father = Roulette(population);
                Individual mother = Roulette(population);

                //realizar o cruzamento
                Individual[] children = CrossOverIndividual(father, mother);

                //aplicar a mutação
                Individual firstChild = Mutation(children[0]);
                Individual secondChild = Mutation(children[1]);

                indBuffer.Add(firstChild);
                indBuffer.Add(secondChild);
            }

            //inserir novos membros
            for (int i = 0; i < Constants.sizePopulation; i++)
            {
                newPopulation.SetIndividual(i, indBuffer[i]);
            }

            //apagar os velhos membros
            indBuffer = null;

            //reavaliar a populacao
            newPopulation.UpdateValues();

            return newPopulation;

        }

        public Individual[] CrossOverIndividual(Individual father, Individual mother)
        {
            Individual[] newInd = new Individual[2];
            int cutPoint = Constants.random.Next(0, Constants.sizeChromosome - 1);

            Individual fatherBuffer = new Individual();
            Individual motherBuffer = new Individual();

            newInd[0] = new Individual();
            newInd[1] = new Individual();

            for (int i = 0; i < Constants.sizeChromosome; i++)
            {
                fatherBuffer.SetGene(i, father.GetGene(i));
                motherBuffer.SetGene(i, mother.GetGene(i));

                newInd[0].SetGene(i, father.GetGene(i));
                newInd[1].SetGene(i, mother.GetGene(i));
            }

            if (Constants.random.NextDouble() < CrossOverTax)
            {
                for (int i = cutPoint; i < Constants.sizeChromosome; i++)
                {
                    newInd[0].SetGene(i, motherBuffer.GetGene(i));
                    newInd[1].SetGene(i, fatherBuffer.GetGene(i));
                }
            }

            return newInd;
        }

        public Individual Mutation(Individual originalInd)
        {
            if(Constants.random.NextDouble() <= MutationTax)
            {
                int genePosition = Constants.random.Next(0, Constants.sizeChromosome);
                originalInd.GeneMutation(genePosition);
                return originalInd;
            }

            return originalInd;
        }

        public Individual Roulette(Population population)
        {
            double numberDrawn = Constants.random.NextDouble() * 100;

            foreach (Individual ind in population.GetPopulation())
            {
                if(numberDrawn >= ind.getRouletteRange()[0] && numberDrawn <= ind.getRouletteRange()[1])
                {
                    return ind;
                }
            }

            return null;
        }
    }
}
