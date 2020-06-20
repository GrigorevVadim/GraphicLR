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
                new Side(FigureVertices, new[] { 0, 1, 2 }, color),
                new Side(FigureVertices, new[] { 0, 2, 3 }, color),
                new Side(FigureVertices, new[] { 0, 3, 4 }, color),
                new Side(FigureVertices, new[] { 0, 4, 5 }, color),
                new Side(FigureVertices, new[] { 0, 5, 1 }, color)
            };
        }
    }
}