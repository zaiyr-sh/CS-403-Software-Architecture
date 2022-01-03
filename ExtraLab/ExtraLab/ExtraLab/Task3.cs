using System;
namespace ExtraLab
{
    class Task3
    {
        private int[,] matrix;
        private int row;
        private int column;
        private int[] maxArr = new int[3];
        private int[] minArr = new int[3];

        public Task3(int[,] matrix, int row, int column)
        {
            this.matrix = matrix;
            this.row = row;
            this.column = column;
        }

        private void findMaxElement()
        {
            int max = matrix[0, 0];
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                        maxArr[0] = max;
                        maxArr[1] = i;
                        maxArr[2] = j;
                    }
                }
            }
        }

        private void findMinElement()
        {
            int min = matrix[0, 0];
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                        minArr[0] = min;
                        minArr[1] = i;
                        minArr[2] = j;
                    }
                }
            }
        }

        public int[,] replace()
        {
            findMaxElement();
            findMinElement();
            matrix[minArr[1], minArr[2]] = maxArr[0];
            matrix[maxArr[1], maxArr[2]] = minArr[0];
            return matrix;
        }

    }
}

