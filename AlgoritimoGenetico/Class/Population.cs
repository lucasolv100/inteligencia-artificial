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

            //Avaliação da população
            FitnessCalculation();
            FitnessPercentageCalculation();
            RangeRouletteCalculation();
        }

        public void FitnessCalculation()
        {
            for (int i = 0; i < Constants.sizePopulation; i++)
            {
                //para calcular precisa aplicar o valor inteiro do individuo na função de aptidão
                this.population[i].SetFitness(
                    Constants.Function1(this.population[i].getInt())
                );
            }
        }

        public void FitnessPercentageCalculation()
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

        //calcula o range da roleta em que o individuo faz parte
        public void RangeRouletteCalculation()
        {
            //primeiro ordenar os individuos
            OrderPopulation();
            double sum = 0;

            //setar o range da roleta
            for (int i = 0; i < Constants.sizePopulation; i++)
            {
                if(i == 0)
                {
                    sum += population[i].GetFitnessPercentage();
                    population[i].setRoulleteRange(0, sum);
                }
                else if(i == Constants.sizePopulation - 1)
                {
                    population[i].setRoulleteRange(sum, 100);
                }
                else
                {
                    var newSum = sum + population[i].GetFitnessPercentage();
                    population[i].setRoulleteRange(sum, newSum);
                    sum += population[i].GetFitnessPercentage();
                }
            }
        }

        public Individual[] GetPopulation()
        {
            return this.population;
        }

        public void SetIndividual(int position, Individual ind)
        {
            this.population[position] = ind;
        }

        public double GetPopulationAverage()
        {
            double sum = 0;
            foreach (var ind in population)
            {
                sum += ind.GetFitnessPercentage();
            }

            return sum / Constants.sizePopulation;
        }

        public void UpdateValues()
        {
            //calcular o fitness
            //calcular o fitness percent
            //calcular o range da roleta
        }

        public void OrderPopulation()
        {
            Individual ind = new Individual();

            for (int i = 0; i < Constants.sizePopulation; i++)
            {
                for (int j = 0; j < Constants.sizePopulation; j++)
                {
                    if(population[i].GetFitnessPercentage() < population[j].GetFitnessPercentage())
                    {
                        ind = population[i];
                        population[i] = population[j];
                        population[j] = ind;
                    }
                }
            }
        }

        public string PrintPopulation()
        {
            string result = string.Empty;

            for (int i = 0; i < Constants.sizePopulation; i++)
            {
                result = result + population[i].PrintIndividual() + "     |     "
                                + population[i].getInt().ToString() + "     |     "
                                + population[i].GetFitness().ToString() + "     |     "
                                + population[i].GetFitnessPercentage().ToString() + "     |     "
                                + population[i].getRouletteRange()[0].ToString() + " : "
                                + population[i].getRouletteRange()[1].ToString() + "\n";
            }

            return result;
        }

    }
}
