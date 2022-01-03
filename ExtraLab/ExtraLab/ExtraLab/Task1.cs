namespace ExtraLab
{
    class Task1
    {
        private int[,] matrix;
        private int row;
        private int column;

        public Task1(int[,] matrix, int row, int column)
        {
            this.matrix = matrix;
            this.row = row;
            this.column = column;
        }

        public int findMaxElement()
        {
            int max = matrix[0, 0];
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }
    }
}
