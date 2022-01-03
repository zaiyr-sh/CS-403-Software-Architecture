namespace ExtraLab
{
    class Task2
    {

        private int[,] matrix;
        private int n;

        public Task2(int[,] matrix, int n)
        {
            this.matrix = matrix;
            this.n = n;
        }

        // Returns true if matrix[N][N]
        // is symmetric, else false
        public bool isSymmetric()
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (matrix[i, j] != matrix[j, i])
                        return false;
            return true;
        }

    }
}
