using System.Linq;

namespace LR3.Figures
{
    public class Side
    {
        public float[] Color;
        public float[][] Vertices;

        public Side(float[][] figureVertices, int[] numbers, float[] color)
        {
            Color = color;
            Vertices = new float[numbers.Length][];

            for (int i = 0; i < numbers.Length; i++)
            {
                Vertices[i] = figureVertices[numbers[i]];
            }
        }
    }
}