using System;
using LR3.enums;
using LR3.libs;

namespace LR3.Figures
{
    public abstract class Figure
    {
        protected float OffsetY;
        protected float[][] FigureVertices;
        protected Side[] Sides;
        protected PolygonMode Mode;
        
        public void CalculateRotation(Axis axis, float fi)
        {
            var d1 = axis == Axis.X ? 1 : 0;
            var d2 = axis == Axis.Z ? 1 : 2;
            
            for (var i = 0; i < FigureVertices.Length; i++)
            {
                var val1 = FigureVertices[i][d1];
                var val2 = FigureVertices[i][d2];

                FigureVertices[i][d1] = val1 * (float) Math.Cos(fi) - val2 * (float) Math.Sin(fi);
                FigureVertices[i][d2] = val1 * (float) Math.Sin(fi) + val2 * (float) Math.Cos(fi);
            }
        }

        public void Display()
        {
            Gl.glPolygonMode(MaterialFace.FrontAndBack, Mode);
            foreach (var side in Sides)
            {
                Gl.glColor3f(side.Color[0], side.Color[1], side.Color[2]);
                Gl.glBegin(GlPrimitiveType.GlPolygon);
                foreach (var vertex in side.Vertices)
                {
                    Gl.glVertex3f(vertex[0], vertex[1] + OffsetY, vertex[2]);
                }
                Gl.glEnd();
            }
        }
    }
}