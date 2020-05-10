using System;

namespace LR2
{
    public static class Matrices
    {
        public static float[,] GetRotationMatrix(float fi)
        {
            return new[,]
            {
                {(float)Math.Cos(fi), (float)Math.Sin(fi), 0.0f}, 
                {-(float)Math.Sin(fi), (float)Math.Cos(fi), 0.0f}, 
                {0.0f, 0.0f, 1.0f}
            };
        }
        
        public static float[,] GetDilatationMatrix(float alpha, float delta)
        {
            if (alpha <= 0 || delta <= 0)
                throw new ArgumentException($"alpha:{alpha}, delta:{delta}");
            
            return new[,]
            {
                {alpha, 0.0f, 0.0f}, 
                {0.0f, delta, 0.0f}, 
                {0.0f, 0.0f, 1.0f}
            };
        }
        
        public static float[,] GetMirrorReflectionMatrix()
        {
            return new[,]
            {
                {1.0f, 0.0f, 0.0f}, 
                {0.0f, -1.0f, 0.0f}, 
                {0.0f, 0.0f, 1.0f}
            };
        }
        
        public static float[,] GetTranslationMatrix(float lambda, float mu)
        {
            return new[,]
            {
                {1.0f, 0.0f, 0.0f}, 
                {0.0f, 1.0f, 0.0f}, 
                {lambda, mu, 1.0f}
            };
        }
    }
}