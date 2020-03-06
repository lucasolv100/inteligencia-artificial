using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimoGenetico.Class
{
    public abstract class Constants
    {
        static public int sizeChromosome = 2;
        static public double offerPrice = 2000.0f;
        public static double offerPriceRange = 0.1f;
        static public int sizePopulation = 1500;
        static public int functionXSize = (int)Math.Pow(2, sizeChromosome);
        public static Random random = new Random((int)DateTime.Now.Ticks);

        public static double GeneratePrice()
        {
            double max = offerPrice + (offerPrice * 0.4);
            double min = (offerPrice - (offerPrice * offerPriceRange));
            return random.NextDouble() * (max - min) + min;
        }

        public static double CalcFunction(double chromossomeOne, double chromossomeTwo)
        {
            return Math.Min(chromossomeOne, chromossomeTwo);
        }

        public static void SetOfferPrice(double OfferPrice)
        {
            offerPrice = OfferPrice;
        }
        public static void SetOfferPriceRange(double Range)
        {
            offerPriceRange = Range;
        }
        public static void SetSizeOfPopulation(int size)
        {
            if (size > 0)
                size = Convert.ToInt32(size / 2);

            sizePopulation = size;
        }
    }
}
