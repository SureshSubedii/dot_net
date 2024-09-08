// Hello.cs
namespace NewProject
{
    public  class MatrixMult
    {
        public static void SumMatrix()
        {
            int[,] firstMatrix = new int[,]{
                {1,2},
                {3,4}
            };
            int[,] secondMatrix = new int[,]{
                {2,4},
                {1,5}
            };
            int [,] Sum = new int[2,2];
            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < firstMatrix.GetLength(1); j++){
                    int sum = 0;
                    for (int k = 0; k < 2 ; k++){
                        sum += firstMatrix[i,k] * secondMatrix[k, j];

                    }
                    Sum[i,j] = sum;

                
            }
        }
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(Sum[i,j] + " ");
                
            }
            Console.WriteLine();
            
        }
    }
}
}