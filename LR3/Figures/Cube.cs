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
                new Side(FigureVertices, new[] { 1, 0, 2, 3 }, new[] { 1.0f, 0.0f, 0.0f }),
                new Side(FigureVertices, new[] { 5, 4, 6, 7 }, new[] { 1.0f, 1.0f, 0.0f }),
                new Side(FigureVertices, new[] { 0, 1, 7, 6 }, new[] { 0.0f, 1.0f, 0.0f }),
                new Side(FigureVertices, new[] { 2, 3, 5, 4 }, new[] { 0.0f, 1.0f, 1.0f }),
                new Side(FigureVertices, new[] { 0, 2, 4, 6 }, new[] { 0.0f, 0.0f, 1.0f }),
                new Side(FigureVertices, new[] { 1, 3, 5, 7 }, new[] { 1.0f, 0.0f, 1.0f })
            };
        }
    }
}