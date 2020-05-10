namespace LR2
{
    public static class Calculator
    {
        public static void CalculatePoints(float[][] point, float[,] matrix)
        {
            for (var i = 0; i < point.Length; i++) 
                point[i] = Composition(point[i], matrix);
        }
        
        private static float[] Composition(float[] sourcePoint, float[,] matrix)
        {
            var point = new float[3];
            
            for (var i = 0; i < 3; i++)
                for (var j = 0; j < 3; j++)
                    point[i] += sourcePoint[j] * matrix[j, i];

            return point;
        }
    }
}