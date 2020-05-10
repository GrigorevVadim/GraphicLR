using GeometricModeling.enums;
using GeometricModeling.libs;

namespace GeometricModeling
{
    internal static class Program
    {
        private static void Main()
        {
            Glut.GlutInit();
            Glut.glutCreateWindow("Julia");
            Glut.glutInitWindowSize(300, 300);
            Glut.glutInitWindowPosition(0, 0);
            Glut.GlutDisplayFunc(Display3);
            Glut.glutMainLoop();
        }

        private static void Display3()
        {
            Gl.glClear(ClearBufferMask.ColorBufferBit);
            Gl.glPointSize(1.0f);
            Gl.glBegin(GlPrimitiveType.GlPoints);
            Julia.Draw(DrawJuliaFractal);
            Gl.glEnd();
            Gl.glFlush();
        }

        private static void DrawJuliaFractal(double arg1, double arg2, int arg3)
        {
            var color = (float)(255 - arg3) % 255 / 255;
            Gl.glColor3f(color * 0.7f, color * 0.5f, color);
            Gl.glVertex3f((float)(arg1 * 0.9), (float)(arg2 * 0.9 + 0.05), 0.0f);
        }
    }
}
