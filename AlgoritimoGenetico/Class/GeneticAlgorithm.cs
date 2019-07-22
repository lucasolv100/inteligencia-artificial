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
            //selecionar pais para cruzamento
            //realizar o cruzamento
            //aplicar a mutação
            //apagar os velhos membros
            //inserir novos membros
            //reavaliar a populacao
            return null;

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
    }
}
