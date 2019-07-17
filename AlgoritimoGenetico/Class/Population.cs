using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimoGenetico.Class
{
    public class Population
    {
        public Individual[] population; //grupo de individuos
        
        //criação da população de individuos
        public Population() 
        {
            this.population = new Individual[Constants.sizePopulation];
            for (int i = 0; i < Constants.sizePopulation; i++)
            {
                population[i] = new Individual();
            }
        }

        public void fitnessCalculation()
        {
            for (int i = 0; i < Constants.sizePopulation; i++)
            {
                //para calcular precisa aplicar o valor inteiro do individuo na função de aptidão
                this.population[i].SetFitness(
                    Constants.Function1(this.population[i].getInt())
                );
            }
        }

        public void fitnessPercentageCalculation()
        {
            double sumFitness = 0;

            //somatoria de todos os valores de aptidão
            for (int i = 0; i < Constants.sizePopulation; i++)
            {
                sumFitness += this.population[i].GetFitness();
            }

            for (int i = 0; i < Constants.sizePopulation; i++)
            {
                this.population[i].SetFitnessPercentage(
                    (this.population[i].GetFitness() * 100) / sumFitness
                );
            }
        }

    }
}
