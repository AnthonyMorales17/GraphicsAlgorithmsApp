using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace GraphicsAlgorithmsApp
{
    class CMidPoint
    {
        private Graphics g;
        private Brush brush = Brushes.Blue;
        private DataGridView dgv;
        private int width, height;

        public CMidPoint(Graphics g, DataGridView dgv, int width, int height)
        {
            this.g = g;
            this.dgv = dgv;
            this.width = width;
            this.height = height;
            dgv.Rows.Clear();
        }

        public void DrawCircle(int radius)
        {
            int xc = 0, yc = 0;
            int x = 0, y = radius;
            int p = 1 - radius;
            int step = 1;

            PlotAll(xc, yc, x, y, step++, p);

            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                PlotAll(xc, yc, x, y, step++, p);
            }
        }

        private void PlotAll(int xc, int yc, int x, int y, int step, int pk)
        {
            Plot(xc + x, yc + y, step, pk);
            Plot(xc - x, yc + y, step, pk);
            Plot(xc + x, yc - y, step, pk);
            Plot(xc - x, yc - y, step, pk);
            Plot(xc + y, yc + x, step, pk);
            Plot(xc - y, yc + x, step, pk);
            Plot(xc + y, yc - x, step, pk);
            Plot(xc - y, yc - x, step, pk);
        }

        private void Plot(int x, int y, int step, int pk)
        {
            Point p = CCoordinate.ToPixel(x, y, width, height);
            g.FillRectangle(brush, p.X, p.Y, CCoordinate.Scale, CCoordinate.Scale);
            dgv.Rows.Add(step, x, y);
        }
    }
}
