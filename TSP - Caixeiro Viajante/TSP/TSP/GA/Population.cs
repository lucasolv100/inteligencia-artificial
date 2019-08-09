using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.GA
{
    public class Population
    {
        public Individual[] population;

        public Population()
        {
            population = new Individual[ConfigurationGA.sizePopulation];

            for (int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                population[i] = new Individual();
                population[i].IndexOfArray = i;
            }

            //Avaliar a população
            FitnessCalculation();
        }

        public void FitnessCalculation()
        {
            for (int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                population[i].CalcFitness(); 
            }
        }

        public void Evaluate()
        {
            RefreshIndexOfIndividual();
            FitnessCalculation();
        }

        public void RefreshIndexOfIndividual()
        {
            for (int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                population[i].IndexOfArray = i;
            }
        }

        public Individual[] GetPopulation()
        {
            return population;
        }

        public void SetIndividual(int position, Individual ind)
        {
            population[position] = ind;
        }

        public double GetAveragePopulation()
        {
            double sum = 0;

            foreach (var ind in population)
            {
                sum += ind.GetFitness();
            }

            return sum / ConfigurationGA.sizePopulation;
        }

        public void Ordenate()
        {
            Individual aux;

            for (int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                for (int j = 0; j < ConfigurationGA.sizePopulation; j++)
                {
                    if(population[i].GetFitness() < population[j].GetFitness())
                    {
                        aux = population[i];
                        population[i] = population[j];
                        population[j] = aux;
                    }
                }
            }
        }

        public Individual GetBestIndividual()
        {
            Ordenate();
            return population[0];
        }

        public Individual GetWorstIndividual()
        {
            Ordenate();
            return population[ConfigurationGA.sizePopulation -1];
        }

        public override string ToString()
        {
            base.ToString();
            string result = string.Empty;


            for (int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                result += population[i].ToString() + "\n";
            }

            return result;
        }
    }
}
