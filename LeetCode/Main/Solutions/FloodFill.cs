using System;

namespace LeetCode.Main.DesignSolutions
{
    public static class FloodFiller
    {
        public static int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            PaintPixels(image,sr,sc,newColor);
            return image;
        }

        private static void PaintPixels(int[][] image, int sr, int sc, int newColor)
        {
            var prevColor = image[sr][sc];
            image[sr][sc] = newColor;

            if (newColor == prevColor)
                return;
            
            if (sr + 1 <= image.Length - 1 && image[sr + 1][sc] == prevColor)
            {
                PaintPixels(image,sr+1,sc,newColor);
            }
            if (sr - 1 >= 0 && image[sr - 1][sc] == prevColor)
            {
                PaintPixels(image,sr - 1,sc,newColor);
            }
            if (sc + 1 <= image[0].Length - 1 && image[sr][sc + 1] == prevColor)
            {
                PaintPixels(image,sr,sc + 1,newColor);
            }
            if (sc - 1 >= 0 && image[sr][sc - 1] == prevColor)
            {
                PaintPixels(image,sr,sc - 1,newColor);
            }
        }
    }
}