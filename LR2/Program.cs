using System;
using System.Text;
using LR2.enums;
using LR2.libs;

namespace LR2
{
    internal static class Program
    {
        private static float[][] Points { get; set; }
        
        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Для применения аффинных преобразований используются следующие клавиши:\n" +
                              "- \"q\", \"e\" - для поворота;\n" +
                              "- \"w\", \"s\", \"a\", \"d\" - для переноса;\n" +
                              "- \"r\" - для отражения;\n" +
                              "- стрелки - для масштабирования.\n" +
                              "Следует удостовериться что ввод на английском языке.\n" +
                              "Для запуска нажмите любой символ на клавиатуре.");
            Console.ReadKey();
            
            Points = SourceData.GetSourcePoints();
            
            Glut.GlutInit();
            Glut.glutCreateWindow("GeometricModelingLR2");
            Glut.glutInitWindowSize(300, 300);
            Glut.glutInitWindowPosition(0, 0);
            Glut.GlutDisplayFunc(Display);
            Glut.GlutKeyboardFunc(ClickKeyboardKeys);
            Glut.GlutSpecialFunc(ClickSpecialKeys);
            Glut.glutMainLoop();
        }

        private static void ClickSpecialKeys(int key, int x, int y)
        {
            var matrix = new float[0,0];
            
            switch (key)
            {
                case 100: matrix = Matrices.GetDilatationMatrix(0.9f, 1.0f); break;
                case 102: matrix = Matrices.GetDilatationMatrix(1.1f, 1.0f); break;
                case 103: matrix = Matrices.GetDilatationMatrix(1.0f, 0.9f); break;
                case 101: matrix = Matrices.GetDilatationMatrix(1.0f, 1.1f); break;
                default: return;
            }
            
            Calculator.CalculatePoints(Points, matrix);
            Glut.glutPostRedisplay();
        }

        private static void ClickKeyboardKeys(byte key, int x, int y)
        {
            var matrix = new float[0,0];
            
            switch (key)
            {
                case 113: matrix = Matrices.GetRotationMatrix(0.1f); break;
                case 101: matrix = Matrices.GetRotationMatrix(-0.1f); break;
                case 119: matrix = Matrices.GetTranslationMatrix(0.0f, 1.0f); break;
                case 115: matrix = Matrices.GetTranslationMatrix(0.0f, -1.0f); break;
                case 100: matrix = Matrices.GetTranslationMatrix(1.0f, 0.0f); break;
                case 97:  matrix = Matrices.GetTranslationMatrix(-1.0f, 0.0f); break;
                case 114: matrix = Matrices.GetMirrorReflectionMatrix(); break;
                default: return;
            }
            
            Calculator.CalculatePoints(Points, matrix);
            Glut.glutPostRedisplay();
        }

        private static void Display()
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