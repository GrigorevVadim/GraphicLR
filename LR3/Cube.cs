using System;
using LR3.enums;

namespace LR3
{
    public class Cube
    {
        public float[][] FigureVertices;
        public Side[] Sides;
        public GlPrimitiveType PrimitiveType;

        public Cube()
        {
            const float dimen = 0.3f;
            PrimitiveType = GlPrimitiveType.GlPolygon;

            FigureVertices = new[]
            {
                new[] {-dimen, dimen, dimen},
                new[] {-dimen, dimen, -dimen},
                new[] {-dimen, -dimen, dimen},
                new[] {-dimen, -dimen, -dimen},
                new[] {dimen, -dimen, dimen},
                new[] {dimen, -dimen, -dimen},
                new[] {dimen, dimen, dimen},
                new[] {dimen, dimen, -dimen},
            };

            Sides = new[]
            {
                new Side
                {
                    Color = new[] {1.0f, 0.0f, 0.0f},
                    Vertices = new[]
                    {
                        FigureVertices[1],
                        FigureVertices[0],
                        FigureVertices[2],
                        FigureVertices[3]
                    }
                },
                new Side
                {
                    Color = new[] {1.0f, 1.0f, 0.0f},
                    Vertices = new[]
                    {
                        FigureVertices[5],
                        FigureVertices[4],
                        FigureVertices[6],
                        FigureVertices[7]
                    }
                },
                new Side
                {
                    Color = new[] {0.0f, 1.0f, 0.0f},
                    Vertices = new[]
                    {
                        FigureVertices[0],
                        FigureVertices[1],
                        FigureVertices[7],
                        FigureVertices[6]
                    }
                },
                new Side
                {
                    Color = new[] {0.0f, 1.0f, 1.0f},
                    Vertices = new[]
                    {
                        FigureVertices[2],
                        FigureVertices[3],
                        FigureVertices[5],
                        FigureVertices[4]
                    }
                },
                new Side
                {
                    Color = new[] {0.0f, 0.0f, 1.0f},
                    Vertices = new[]
                    {
                        FigureVertices[0],
                        FigureVertices[2],
                        FigureVertices[4],
                        FigureVertices[6]
                    }
                },
                new Side
                {
                    Color = new[] {1.0f, 0.0f, 1.0f},
                    Vertices = new[]
                    {
                        FigureVertices[1],
                        FigureVertices[3],
                        FigureVertices[5],
                        FigureVertices[7]
                    }
                }
            };
        }

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
    }
}