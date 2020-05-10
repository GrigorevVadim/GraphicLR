using GeometricModeling.enums;
using GeometricModeling.libs;

namespace LR3
{
    internal class Program
    {
        private static void Main()
        {
            Glut.GlutInit();
            Glut.glutCreateWindow("3d graphic");
            Glut.glutInitWindowSize(300, 300);
            Glut.glutInitWindowPosition(0, 0);
            Glut.GlutDisplayFunc(Display3);
            Glut.glutMainLoop();
        }

        private static void Display3()
        {
            Gl.glClear(ClearBufferMask.ColorBufferBit);
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glBegin(GlPrimitiveType.GlLineLoop);
                //Gl.glVertex3f(point[0] * 0.1f, point[1] * 0.1f, 0f);
            Gl.glEnd();
            Gl.glFlush();
        }
    }
}