using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsAlgorithmsApp
{
    class CBresenham : CLineDrawing
    {
        public CBresenham(Bitmap canvas, Pen pen) : base(canvas, pen) { }

        public List<StepData> GetLineSteps(int x1, int y1, int x2, int y2, int width, int height)
        {
            List<StepData> steps = new List<StepData>();

            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);

            int sx = x1 < x2 ? 1 : -1;
            int sy = y1 < y2 ? 1 : -1;

            int err = dx - dy;

            int x = x1;
            int y = y1;

            int step = 0;

            while (true)
            {
                Point p = CCoordinate.ToPixel(x, y, width, height);

                string decision;
                string accion;

                if (x == x2 && y == y2)
                {
                    decision = "Fin";
                    accion = "Terminado";
                }
                else
                {
                    if (err > 0)
                    {
                        decision = "Pk > 0";
                        x += sx;
                        err -= dy;
                        accion = "Avanza en X";
                    }
                    else if (err < 0)
                    {
                        decision = "Pk < 0";
                        y += sy;
                        err += dx;
                        accion = "Avanza en Y";
                    }
                    else // err == 0
                    {
                        decision = "Pk = 0";
                        x += sx;
                        y += sy;
                        err += dx - dy;
                        accion = "Avanza en X e Y";
                    }
                }

                steps.Add(new StepData
                {
                    Pasos = step,
                    X = x,
                    Y = y,
                    Pk = err,
                    Decision = decision,
                    Accion = accion,
                    Pixel = p
                });

                step++;

                if (x == x2 && y == y2)
                    break;
            }

            return steps;
        }

        public class StepData
        {
            public int Pasos { get; set; }
            public int X { get; set; }
            public int Y { get; set; }
            public int Pk { get; set; }
            public string Decision { get; set; }
            public string Accion { get; set; }
            public Point Pixel { get; set; }
        }
    }
}
