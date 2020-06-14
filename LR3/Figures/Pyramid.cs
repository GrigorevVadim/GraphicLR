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
                new[] {-0.4f, -0.9f, -0.9f},
                new[] {0.4f, -0.9f, -0.9f},
                new[] {0.9f, -0.7f, -0.3f},
                new[] {0.0f, -0.6f, 0.9f},
                new[] {-0.9f, -0.7f, -0.3f}
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
                        FigureVertices[2],
                        FigureVertices[3]
                    }
                },
                new Side
                {
                    Color = color,
                    Vertices = new[]
                    {
                        FigureVertices[0],
                        FigureVertices[3],
                        FigureVertices[4]
                    }
                },
                new Side
                {
                    Color = color,
                    Vertices = new[]
                    {
                        FigureVertices[0],
                        FigureVertices[4],
                        FigureVertices[5]
                    }
                },
                new Side
                {
                    Color = color,
                    Vertices = new[]
                    {
                        FigureVertices[0],
                        FigureVertices[5],
                        FigureVertices[1]
                    }
                }
            };
        }
    }
}