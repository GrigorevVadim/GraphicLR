using LR3.enums;

namespace LR3.Figures
{
    public class Cube : Figure
    {
        public Cube()
        {
            OffsetY = -0.25f;
            Mode = PolygonMode.Fill;
            const float dimen = 0.3f;

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
    }
}