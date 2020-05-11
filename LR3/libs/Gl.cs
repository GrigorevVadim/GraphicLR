using System;
using System.Runtime.InteropServices;
using LR3.enums;

namespace LR3.libs
{
    public static class Gl
    {
        private const string Lib = "opengl32.dll";

        [DllImport(Lib, ExactSpelling = true)]
        internal static extern void glClearColor(Single red, Single green, Single blue, Single alpha);

        [DllImport(Lib, ExactSpelling = true)]
        internal static extern void glClear(ClearBufferMask mask);

        [DllImport(Lib)]
        public static extern void glBegin(GlPrimitiveType primitive);

        [DllImport(Lib)]
        public static extern void glEnd();

        [DllImport(Lib)]
        public static extern void glFlush();
        
        [DllImport(Lib)]
        public static extern void glColor3f(float red, float green, float blue);
        
        [DllImport(Lib)]
        public static extern void glVertex2f(float x, float y);
        
        [DllImport(Lib)]
        public static extern void glVertex3f(float x, float y, float z);
        
        [DllImport(Lib, ExactSpelling = true)]
        internal static extern void glPointSize(Single size);
        
        [DllImport(Lib, ExactSpelling = true)]
        internal static extern void glPolygonMode(MaterialFace face, PolygonMode mode);
        
        [DllImport(Lib, ExactSpelling = true)]
        internal static extern void glEnable(EnableCap cap);
        
        [DllImport(Lib, ExactSpelling = true)]
        internal static extern void glDisable(EnableCap cap);
    }
}