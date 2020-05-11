using LR3.enums;
using LR3.libs;

namespace LR3
{
    internal class Program
    {
        private static Pyramid pyramid;
        private static Cube cube;
        
        private static void Main()
        {
            pyramid = new Pyramid();
            cube = new Cube();
            
            Glut.GlutInit();
            Glut.glutCreateWindow("3d graphic");
            Glut.glutInitWindowSize(300, 300);
            Glut.glutInitWindowPosition(0, 0);
            Glut.GlutDisplayFunc(Display);
            Glut.glutMainLoop();
        }

        private static void Display()
        {
            Gl.glClear(ClearBufferMask.DepthBufferBit);
            
            Gl.glPolygonMode(MaterialFace.FrontAndBack, PolygonMode.Line);
            foreach (var pyramidSide in pyramid.Sides)
            {
                Gl.glColor3f(pyramidSide.Color[0], pyramidSide.Color[1], pyramidSide.Color[2]);
                Gl.glBegin(pyramid.PrimitiveType);
                foreach (var vertex in pyramidSide.Vertices)
                {
                    Gl.glVertex3f(vertex[0], vertex[1], vertex[2]);
                }
                Gl.glEnd();
            }

            Gl.glPolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
            foreach (var cubeSide in cube.Sides)
            {
                Gl.glColor3f(cubeSide.Color[0], cubeSide.Color[1], cubeSide.Color[2]);
                Gl.glBegin(cube.PrimitiveType);
                foreach (var vertex in cubeSide.Vertices)
                {
                    Gl.glVertex3f(vertex[0], vertex[1], vertex[2]);
                }
                Gl.glEnd();
            }
            
            Gl.glFlush();
        }
    }
}