using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSP
{
    public partial class Form1 : Form
    {

        Graphics g; //desenha elementos na tela
        int count = 0; //verifica a quantidade de pontos na tela
        int pointCount = 0; //sequenciador para impressão do número do ponto na tela
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            //Criar um lapis
            Pen blackPen = new Pen(Color.Red, 3);
            int x = e.X;
            int y = e.Y;

            Rectangle rect = new Rectangle(x - 5, y - 5, 10, 10);
            g.DrawEllipse(blackPen, rect);
            g.DrawString((pointCount + 1).ToString(), new Font("Arial Black", 11), Brushes.Black, x + 3, y);
            g.DrawString("X: " + x.ToString(), new Font("Arial Black", 6), Brushes.Black, x -20, y-25);
            g.DrawString("Y: " + y.ToString(), new Font("Arial Black", 6), Brushes.Black, x - 20, y - 18);

            pointCount++;
            lbQtyCities.Text = pointCount.ToString();
            lbDifficulty.Text = Fatorial((ulong)pointCount).ToString();

            if (++count > 3)
            {
                btnPopulationGenerate.Enabled = true;
            }
            if(++count > 1)
            {
                btnClean.Enabled = true;
            }
            
        }

        //private void plotPoints()
        //{
        //    if(TablePoints.pointcount > 0)
        //    {
        //        for (int i = 0; i < TablePoints.pointcount; i++)
        //        {
        //            Pen blackPen = new Pen(Color.Red, 3);
        //            int[] coo = TablePoints.getCoordinates(i); //vetor de cordenadas;
        //            Rectangle rect = new Rectangle(coo[0] - 5, coo[1] - 5, 10, 10);
        //            g.DrawEllipse(blackPen, rect);
        //            g.DrawString((i + 1).ToString(), new Font("Arial Black", 11), Brushes.Black, coo[0] + 3, coo[1]);
        //            g.DrawString("X: " + coo[0].ToString(), new Font("Arial Black", 6), Brushes.Black, coo[0] - 20, coo[1] - 25);
        //            g.DrawString("Y: " + coo[1].ToString(), new Font("Arial Black", 6), Brushes.Black, coo[0] - 20, coo[1] - 18);
        //        }
        //    }
        //}

        public ulong Fatorial(ulong number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * Fatorial(number - 1);
            }
        }
    }
}
