using GeometricModeling.enums;
using GeometricModeling.libs;

namespace LR2
{
    internal static class Program
    {
        private static float[][] Points { get; set; }
        
        private static void Main()
        {
            Points = SourceData.GetSourcePoints();
            
            Glut.GlutInit();
            Glut.glutCreateWindow("2d graphic");
            Glut.glutInitWindowSize(300, 300);
            Glut.glutInitWindowPosition(0, 0);
            Glut.GlutDisplayFunc(Display3);
            Glut.GlutKeyboardFunc(Func);
            Glut.glutMainLoop();
        }

        private static void Func(byte key, int x, int y)
        {
            Calculator.CalculatePoints(Points, Matrices.GetRotationMatrix(0.1f));
            Glut.glutPostRedisplay();
        }

        private static void Display3()
        {
            Gl.glClear(ClearBufferMask.ColorBufferBit);
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glBegin(GlPrimitiveType.GlLineLoop);
            foreach (var point in Points) 
                Gl.glVertex3f(point[0] * 0.1f, point[1] * 0.1f, 0f);
            Gl.glEnd();
            Gl.glFlush();
        }
    }
}