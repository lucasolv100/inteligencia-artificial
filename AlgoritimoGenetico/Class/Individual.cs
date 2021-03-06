﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimoGenetico.Class
{
    public class Individual
    {
        private BitArray chromosome; //vetor de bits, dois estados
        private double fitness; //nota de aptidão do individuo
        private double fitnessPercentage; //Percentual de aptidão do individuo
        private double[] rouletteZone = { 0, 0 }; //Faixa da roleta, em que o individuo pode ser selecionado

        public Individual()
        {
            //instancia o chromossomo com a quantidade de bits informado na classe constants
            this.chromosome = new BitArray(Constants.sizeChromosome);

            for (int i = 0; i < this.chromosome.Length; i++)
            {
                this.chromosome[i] = (Constants.random.NextDouble() >= 0.5f) ? true : false;
            }
        }

        public BitArray GetChromosome()
        {
            return this.chromosome;
        }

        public void SetGene(int position, bool gene)
        {
            this.chromosome[position] = gene;
        }

        public bool GetGene(int position)
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

        public void GeneMutation(int position)
        {
            if (position < this.chromosome.Length)
            {
                this.chromosome.Set(position, this.chromosome[position] == false ? true : false);
            }
        }

        public void setRoulleteRange(double begin, double end)
        {
            rouletteZone[0] = begin;
            rouletteZone[1] = end;
        }

        public double[] getRouletteRange()
        {
            return this.rouletteZone;
        }

        public int getInt()
        {
            if (this.chromosome.Length > 32)
                throw new ArgumentException("O Comprimento do cromossomo deve ser no maximo 32 bits");

            int[] array = new int[1];
            this.chromosome.CopyTo(array, 0);

            return array[0];
        }

        public string PrintIndividual()
        {
            string result = string.Empty;
            result += "Bits: ";

            for (int i = chromosome.Length -1; i >= 0; i--)
            {
                result = result + (chromosome[i] == false ? "0" : "1");
            }

            result += "    INT:     " + getInt() + "   Apitidão:   " + GetFitness() + "    Porcentagem:      " + GetFitnessPercentage();
            return result;
        }
    }
}
