public class MatrixAddition
{
    public static void doMatrixAddition()
    {
        Console.WriteLine("Addition of two Matrices : ");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Input the size of the square matrix (less than 5): ");
        int matrixSize = Convert.ToInt32(Console.ReadLine());
        int[,] matrix1 = new int[matrixSize, matrixSize];
        Console.WriteLine("Input elements in the first matrix");
        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                Console.Write("element [{0},{1}] : ", i, j);
                matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int[,] matrix2 = new int[matrixSize, matrixSize];
        Console.WriteLine("Input elements in the second matrix");
        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                Console.Write("element [{0},{1}] : ", i, j);
                matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("The First matrix is:");
        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                Console.Write(matrix1[i, j] + "\t");
            }
            Console.Write("\n");
        }
        Console.WriteLine("The Second matrix is:");
        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                Console.Write(matrix2[i, j] + "\t");
            }
            Console.Write("\n");
        }
        int[,] matrixSum = new int[matrixSize, matrixSize];
        Console.WriteLine("The Addition of two matrix is:");
        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                int sum = matrix2[i, j] + matrix1[i, j];
                Console.Write(sum + "\t");
            }
            Console.Write("\n");
        }
    }
}

