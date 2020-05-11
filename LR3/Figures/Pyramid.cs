using LR3.enums;

namespace LR3.Figures
{
    public class Pyramid : Figure
    {
        public Pyramid()
        {
            OffsetY = 0.0f;
            Mode = PolygonMode.Line;
            var color = new[] {1.0f, 1.0f, 1.0f};

            FigureVertices = new[]
            {
                new[] {0.0f, 0.9f, 0.0f},
                new[] {-0.9f, -0.6f, 0.9f},
                new[] {0.0f, -0.9f, -0.9f},
                new[] {0.9f, -0.6f, 0.9f}
            };

            Sides = new[]
            {
                new Side
                {
                    Color = color,
                    Vertices = new[]
                    {
                        FigureVertices[0],
                        FigureVertices[1],
                        FigureVertices[2]
                    }
                },
                new Side
                {
                    Color = color,
                    Vertices = new[]
                    {
                        FigureVertices[0],
                        FigureVertices[1],
                        FigureVertices[3]
                    }
                },
                new Side
                {
                    Color = color,
                    Vertices = new[]
                    {
                        FigureVertices[0],
                        FigureVertices[2],
                        FigureVertices[3]
                    }
                },
                new Side
                {
                    Color = color,
                    Vertices = new[]
                    {
                        FigureVertices[1],
                        FigureVertices[2],
                        FigureVertices[3]
                    }
                }
            };
        }
    }
}