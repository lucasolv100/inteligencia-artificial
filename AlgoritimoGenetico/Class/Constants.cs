using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimoGenetico.Class
{
    public abstract class Constants
    {
        static public int sizeChromosome = 9;
        static public int sizePopulation = 300;
        static public int functionXSize = (int)Math.Pow(2, sizeChromosome);
        public static Random random = new Random((int)DateTime.Now.Ticks);

        public static double Function1(double x)
        {
            return (double)(100 + Math.Abs(x * Math.Sin(Math.Sqrt(Math.Abs(x)))));
        }
    }
}
