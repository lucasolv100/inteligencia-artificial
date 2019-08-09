using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.GA
{
    public class Individual
    {
        private int[] Chromossome { get; set; }
        private double Fitness { get; set; }
        public int IndexOfArray { get; set; }

        public Individual()
        {
            Chromossome = new int[ConfigurationGA.sizeChromossome];
            List<int> genes = Utils.RandomNumbers(0, ConfigurationGA.sizeChromossome);

            for (int i = 0; i < ConfigurationGA.sizeChromossome; i++)
            {
                Chromossome[i] = genes[i];
            }

            CalcFitness();
        }

        public void Evaluate()
        {
            CalcFitness();
        }

        public int[] GetChromossome()
        {
            return Chromossome;
        }

        public void CalcFitness()
        {
            double totalDist = 0.0;

            for (int i = 0; i < ConfigurationGA.sizeChromossome; i++)
            {
                if(i < ConfigurationGA.sizeChromossome - 1)
                {
                    totalDist += TablePoints.getDist(GetGene(i), GetGene(i + 1));
                }
                else
                {
                    totalDist += TablePoints.getDist(GetGene(i), GetGene(0));
                }
            }

            Fitness = totalDist;

        }

        public void SetGene(int position, int gene)
        {
            Chromossome[position] = gene;
        }

        public void SetFitness(double fitness)
        {
            Fitness = fitness;
        }

        public int GetGene(int position)
        {
            return Chromossome[position];
        }

        public double GetFitness()
        {
            return Fitness;
        }

        public void Mutate(int one, int two)
        {
            if(one < ConfigurationGA.sizeChromossome && two < ConfigurationGA.sizeChromossome && one != two)
            {
                int temp = Chromossome[one];
                Chromossome[one] = Chromossome[two];
                Chromossome[two] = temp;
            }
        }

        public override string ToString()
        {
            base.ToString();
            string result = string.Empty;
            result += "Rota:           ";

            for (int i = 0; i < ConfigurationGA.sizeChromossome; i++)
            {
                result += (GetGene(i)+1).ToString() + " -> ";
            }

            result += "Distancia: " + GetFitness();


            return result;
        }

    }
}
