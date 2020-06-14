using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace GeometricModeling.libs
{
    public static class Glut
    {
        private const string Lib = "freeglut.dll";

        private static DisplayCallback _displayCallback;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void DisplayCallback();

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Lib)]
        private static extern void glutDisplayFunc(DisplayCallback func);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Lib)]
        private static extern void glutInit(ref int argcp, StringBuilder[] argv);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Lib)]
        public static extern int glutCreateWindow(string name);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Lib)]
        public static extern void glutInitWindowSize(int width, int height);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Lib)]
        public static extern void glutInitWindowPosition(int x, int y);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Lib)]
        public static extern void glutMainLoop();

        public static void GlutDisplayFunc([In] DisplayCallback func)
        {
            _displayCallback = func;
            glutDisplayFunc(_displayCallback);
        }

        public static void GlutInit()
        {
            var comLine = Environment.GetCommandLineArgs();
            var length = comLine.Length;
            var str = new StringBuilder[length];
            for (var i = 0; i < length; i++)
                str[i] = new StringBuilder(comLine[i], comLine[i].Length);
            glutInit(ref length, str);
        }
    }
}