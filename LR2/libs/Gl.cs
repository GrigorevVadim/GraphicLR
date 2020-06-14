using System.Runtime.InteropServices;
using LR2.enums;

namespace LR2.libs
{
    public static class Gl
    {
        private const string Lib = "opengl32.dll";

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
        public static extern void glVertex3f(float x, float y, float z);
    }
}