using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.GA
{
    public static class ConfigurationGA
    {
        public static int sizeChromossome = 0;
        public static int sizePopulation = 100;
        public static Random random = new Random((int)DateTime.Now.Ticks);
        public static bool elitism = false;
        public static int sizeElitism = 3;
        public static double rateCrossOver = 0.8;
        public static double rateMutation = 0.01;
        public static int tournamentCompetitors = 3;
        public static Mutation mutationType = Mutation.NewIndividual;
    }

    public enum Mutation
    {
        NewIndividual,
        InPopulation,
        InGenesPopulation
    }
}
