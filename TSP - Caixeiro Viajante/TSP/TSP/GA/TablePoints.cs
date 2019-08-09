using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.GA
{
    public static class TablePoints
    {
        private static ArrayList X = new ArrayList(); //Valores x
        private static ArrayList Y = new ArrayList(); //Valores y

        private static double[,] tableDist; //tabela com distancia entre os pontos
        public static int pointCount = 0;

        public static void addPoint(int x, int y)
        {
            X.Add(x);
            Y.Add(y);
            pointCount++;
            generateTable();
        }

        public static void generateTable()
        {
            tableDist = new double[pointCount, pointCount];

            for (int i = 0; i < pointCount; i++) //for para x
            {
                for (int j = 0; j < pointCount; j++) //for para y
                {
                    //calculo de distancia entre dois pontos no plano
                    tableDist[i, j] = Math.Sqrt(
                        Math.Pow((int.Parse(X[i].ToString()) - int.Parse(X[j].ToString())), 2)
                        + Math.Pow((int.Parse(Y[i].ToString()) - int.Parse(Y[j].ToString())), 2));
                }
            }

            //atualizar o tamanho do chromossome
            ConfigurationGA.sizeChromossome = pointCount;
        }

        public static double[,] getTableDist()
        {
            return tableDist;
        }

        public static double getDist(int pointOne, int pointTwo)
        {
            return tableDist[pointOne, pointTwo];
        }

        public static int count()
        {
            return pointCount;
        }

        public static string print()
        {
            string data = string.Empty;

            for (int i = 0; i < pointCount; i++)
            {
                for (int j = 0; j < pointCount; j++)
                {
                    data += string.Format("{0:0.#}", double.Parse(tableDist[i, j].ToString())) + "             ";
                }

                data += Environment.NewLine;
            }

            data += Environment.NewLine + "---------------------------" + Environment.NewLine;

            return data;
        }

        //retorna a coordenada de um ponto
        public static int[] getCoordinates(int point)
        {
            int[] arrayCoordinates = new int[2];
            arrayCoordinates[0] = int.Parse(X[point].ToString());
            arrayCoordinates[1] = int.Parse(Y[point].ToString());

            return arrayCoordinates;
        }

        public static void clear()
        {
            X.Clear();
            Y.Clear();
            pointCount = 0;
            tableDist = null;
        }
    }
}
