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
                //calcula a apitidão do individuo
                this.population[i].SetFitness(
                    Constants.CalcFunction(this.population[i].GetGene(0), this.population[i].GetGene(1))
                );
            }
        }

        public void FitnessPercentageCalculation()
        {
            double sumFitness = 0;

            //somatoria de todos os valores de aptidão
            for (int i = 0; i < Constants.sizePopulation; i++)
            {
                sumFitness += population[i].GetFitness();
            }

            for (int i = 0; i < Constants.sizePopulation; i++)
            {
                double value = (population[i].GetFitness() * 1000) / sumFitness;
                population[i].SetFitnessPercentage(
                    value
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
                    population[i].setRoulleteRange(sum, 100f);
                }
                else
                {
                    double newSum = sum + population[i].GetFitnessPercentage();
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
            foreach (Individual ind in population)
            {
                sum += ind.GetFitness();
            }

            return sum / Constants.sizePopulation;
        }

        public void UpdateValues()
        {
            //calcular o fitness
            FitnessCalculation();
            //calcular o fitness percent
            FitnessPercentageCalculation();
            //calcular o range da roleta
            RangeRouletteCalculation();
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
                result = result + population[i].PrintIndividual() + "\n";
                //+ "     |   GENES:   "
                //+ population[i].GetGene(0).ToString() +  " - " + population[i].GetGene(1).ToString()  + "     | FITNESS:    "
                //+ population[i].GetFitness().ToString() + "    | PORCENTAGEM FITNESS:     "
                //+ population[i].GetFitnessPercentage().ToString() + "     | RANGE DA ROLETA GENE1:    "
                //+ population[i].getRouletteRange()[0].ToString() + " RANGE DA ROLETA GENE2: "
                //+ population[i].getRouletteRange()[1].ToString() + "\n";
            }

            return result;
        }

    }
}
