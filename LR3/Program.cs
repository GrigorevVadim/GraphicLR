﻿using System;
using System.Text;
using LR3.enums;
using LR3.Figures;
using LR3.libs;

namespace LR3
{
    internal class Program
    {
        private static Pyramid pyramid;
        private static Cube cube;
        
        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Для применения поворота используются следующие клавиши:\n" +
                              "- \"w\", \"s\" - вокруг оси X;\n" +
                              "- \"a\", \"d\" - вокруг оси Y;\n" +
                              "- \"q\", \"e\" - вокруг оси Z.\n" +
                              "Следует удостовериться что ввод на английском языке.\n" +
                              "Для запуска нажмите любой символ на клавиатуре.");
            Console.ReadKey();
            
            pyramid = new Pyramid();
            cube = new Cube();
            
            Glut.GlutInit();
            Glut.glutCreateWindow("GeometricModelingLR3");
            Glut.glutInitWindowSize(300, 300);
            Glut.glutInitWindowPosition(0, 0);
            Glut.GlutDisplayFunc(Display);
            Glut.GlutKeyboardFunc(ClickKeyboardKeys);
            Glut.glutMainLoop();
        }

        private static void ClickKeyboardKeys(byte key, int x, int y)
        {
            Axis axis;
            float fi;
            
            switch (key)
            {
                case 119: axis = Axis.X; fi = 0.1f;  break;
                case 115: axis = Axis.X; fi = -0.1f; break;
                case 100: axis = Axis.Y; fi = 0.1f;  break;
                case 97:  axis = Axis.Y; fi = -0.1f; break;
                case 113: axis = Axis.Z; fi = 0.1f;  break;
                case 101: axis = Axis.Z; fi = -0.1f; break;
                default: return;
            }
            
            cube.CalculateRotation(axis, fi);
            Glut.glutPostRedisplay();
        }

        private static void Display()
        {
            Gl.glClear(ClearBufferMask.DepthBufferBit|ClearBufferMask.ColorBufferBit);
            Gl.glEnable(EnableCap.DepthTest);
            
            pyramid.Display();
            cube.Display();
            
            Gl.glDisable(EnableCap.DepthTest);
            Gl.glFlush();
        }
    }
}