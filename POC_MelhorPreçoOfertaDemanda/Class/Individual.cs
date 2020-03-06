using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimoGenetico.Class
{
    public class Individual
    {
        private double[] chromosome; //vetor de bits, dois estados
        private double fitness; //nota de aptidão do individuo
        private double fitnessPercentage; //Percentual de aptidão do individuo
        private double[] rouletteZone = { 0, 0 }; //Faixa da roleta, em que o individuo pode ser selecionado

        public Individual()
        {
            //instancia o chromossomo com a quantidade de bits informado na classe constants
            this.chromosome = new double[Constants.sizeChromosome];

            //popula o chromossomo com os preços obtidos
            for (int i = 0; i < this.chromosome.Length; i++)
            {
                this.chromosome[i] = Constants.GeneratePrice();
            }
        }

        public double[] GetChromosome()
        {
            return this.chromosome;
        }

        public void SetGene(int position, double gene)
        {
            this.chromosome[position] = gene;
        }

        public double GetGene(int position)
        {
            return this.chromosome[position];
        }

        public void SetFitness(double fitness)
        {
            this.fitness = fitness;
        }

        public double GetFitness()
        {
            return this.fitness;
        }

        public void SetFitnessPercentage(double fitnessPercentage)
        {
            this.fitnessPercentage = fitnessPercentage;
        }

        public double GetFitnessPercentage()
        {
            return this.fitnessPercentage;
        }

        //public void GeneMutation(int position)
        //{
        //    if (position < this.chromosome.Length)
        //    {
        //        this.chromosome.Set(position, this.chromosome[position] == false ? true : false);
        //    }
        //}

        public void setRoulleteRange(double begin, double end)
        {
            rouletteZone[0] = begin;
            rouletteZone[1] = end;
        }

        public double[] getRouletteRange()
        {
            return this.rouletteZone;
        }

        public string PrintIndividual()
        {
            string result = string.Empty;
            //result += "VALOR: ";

            //for (int i = chromosome.Length -1; i >= 0; i--)
            //{
            //    result = result + (chromosome[i]);
            //}

            result += "CROMOSSOMO:     " +  GetChromosome()[0] + " - " + GetChromosome()[1] + "   APITIDÃO:   " + GetFitness() + "    PORCENTAGEM:      " + GetFitnessPercentage();
            return result;
        }
    }
}
