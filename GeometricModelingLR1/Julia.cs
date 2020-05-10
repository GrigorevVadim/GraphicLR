using System;

namespace GeometricModeling
{
    public static class Julia
    {
        public static void Draw(Action<double, double, int> action)
        {
            const int maxiter = 255;
            const double cX = 0.36;
            const double cY = 0.36;

            for (var x = -0.9; x < 0.9; x += 0.001)
            {
                for (var y = -1.1; y < 1.0; y += 0.001)
                {
                    var zx = x;
                    var zy = y;
                    var i = maxiter;
                    while (zx * zx + zy * zy < 4 && i > 1)
                    {
                        var tmp = zx * zx - zy * zy + cX;
                        zy = 2.0 * zx * zy + cY;
                        zx = tmp;
                        i -= 1;
                    }

                    action(x, y, i);
                }
            }
        }
    }
}
