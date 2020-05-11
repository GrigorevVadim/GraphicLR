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
            const float yOffset = -0.25f;
            PrimitiveType = GlPrimitiveType.GlPolygon;

            FigureVertices = new[]
            {
                new[] {-dimen, dimen + yOffset, dimen},
                new[] {-dimen, dimen + yOffset, -dimen},
                new[] {-dimen, -dimen + yOffset, dimen},
                new[] {-dimen, -dimen + yOffset, -dimen},
                new[] {dimen, -dimen + yOffset, dimen},
                new[] {dimen, -dimen + yOffset, -dimen},
                new[] {dimen, dimen + yOffset, dimen},
                new[] {dimen, dimen + yOffset, -dimen},
            };

            Sides = new[]
            {
                new Side
                {
                    Color = new[] {1.0f, 0.0f, 0.0f},
                    Vertices = new[]
                    {
                        FigureVertices[0],
                        FigureVertices[1],
                        FigureVertices[2],
                        FigureVertices[3]
                    }
                },
                new Side
                {
                    Color = new[] {1.0f, 1.0f, 0.0f},
                    Vertices = new[]
                    {
                        FigureVertices[4],
                        FigureVertices[5],
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
                        FigureVertices[6],
                        FigureVertices[7]
                    }
                },
                new Side
                {
                    Color = new[] {0.0f, 1.0f, 1.0f},
                    Vertices = new[]
                    {
                        FigureVertices[2],
                        FigureVertices[3],
                        FigureVertices[4],
                        FigureVertices[5]
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
    }
}