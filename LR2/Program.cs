using GeometricModeling.enums;
using GeometricModeling.libs;

namespace LR2
{
    internal static class Program
    {
        private static Point[] Points { get; set; }
        
        private static void Main()
        {
            InitCoordinate();
            
            Glut.GlutInit();
            Glut.glutCreateWindow("2d graphic");
            Glut.glutInitWindowSize(300, 300);
            Glut.glutInitWindowPosition(0, 0);
            Glut.GlutDisplayFunc(Display3);
            Glut.glutMainLoop();
        }

        private static void InitCoordinate()
        {
            Points = new []
            {
                new Point { X = -2f, Y = -1f, Z = 1f }, 
                new Point { X = -2f, Y = 1f, Z = 1f }, 
                new Point { X = -3f, Y = 2f, Z = 1f }, 
                new Point { X = 3f, Y = 2f, Z = 1f }, 
            };
        }

        private static void Display3()
        {
            Gl.glClear(ClearBufferMask.ColorBufferBit);
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glBegin(GlPrimitiveType.GlLineLoop);
            foreach (var point in Points) 
                Gl.glVertex3f(point.X * 0.3f, point.Y * 0.3f, 0f);
            Gl.glEnd();
            Gl.glFlush();
        }
    }

    internal class Point
    {
        public float X;
        public float Y;
        public float Z;
    }
}