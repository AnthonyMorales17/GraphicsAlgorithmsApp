using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAlgorithmsApp
{
    class CCoordinate
    {
        public static int Scale { get; set; } = 10; // Escala de representación

        // Convierte coordenadas cartesianas (x, y) a coordenadas de píxeles dentro del canvas
        public static Point ToLogical(int pixelX, int pixelY, int width, int height)
        {
            int centerX = width / 2;
            int centerY = height / 2;
            int x = (pixelX - centerX) / Scale;
            int y = (centerY - pixelY) / Scale;
            return new Point(x, y);
        }

        public static Point ToPixel(int logicalX, int logicalY, int width, int height)
        {
            int centerX = width / 2;
            int centerY = height / 2;
            int pixelX = centerX + logicalX * Scale;
            int pixelY = centerY - logicalY * Scale;
            return new Point(pixelX, pixelY);
        }

    }
}
