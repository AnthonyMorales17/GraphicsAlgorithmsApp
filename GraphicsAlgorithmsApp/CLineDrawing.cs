using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAlgorithmsApp
{
    public abstract class CLineDrawing
    {
        protected Bitmap mCanvas;
        protected Pen mPen;
        public List<Point> Pixels { get; protected set; } = new List<Point>();

        public CLineDrawing(Bitmap canvas, Pen pen)
        {
            mCanvas = canvas;
            mPen = pen;
        }
    }

}
