namespace LeetCode.Main.Solutions
{
    public class SubrectangleQueries
    {
        private int[][] rectangle;
        public SubrectangleQueries(int[][] rectangle)
        {
            this.rectangle = rectangle;
        }
    
        public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue) 
        {
            for (int i = 0; i < rectangle.Length; i++)
            {
                for (int j = 0; j < rectangle[i].Length; j++)
                {
                    if (i >= row1 && i <= row2)
                    {
                        if (j >= col1 && j <= col2)
                        {
                            rectangle[i][j] = newValue;
                        }
                    }
                }
            }
        }
    
        public int GetValue(int row, int col)
        {
            return rectangle[row][col];
        }
    }
}