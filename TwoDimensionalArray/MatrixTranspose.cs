public class MatrixTranspose
{
    public static void doMatrixTranspose()
    {
        int i, j, r, c;
        int[,] matrix1 = new int[50, 50];
        int[,] matrix2 = new int[50, 50];


        Console.Write("\n\nTranspose of a Matrix :\n");
        Console.Write("---------------------------\n");

        Console.Write("\nInput the number of rows and columns of the matrix :\n");
        Console.Write("Rows : ");
        r = Convert.ToInt32(Console.ReadLine());
        Console.Write("Columns : ");
        c = Convert.ToInt32(Console.ReadLine());


        Console.Write("Input elements in the matrix :\n");
        for (i = 0; i < r; i++)
        {
            for (j = 0; j < c; j++)
            {
                Console.Write("element - [{0}],[{1}] : ", i, j);
                matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.Write("\nThe First matrix is :\n");
        for (i = 0; i < r; i++)
        {
            Console.Write("\n");
            for (j = 0; j < c; j++)
                Console.Write("{0}\t", matrix1[i, j]);
        }

        for (i = 0; i < r; i++)
        {
            for (j = 0; j < c; j++)
            {

                matrix2[j, i] = matrix1[i, j];
            }
        }

        Console.Write("\n\nThe Transpose of a matrix is : ");
        for (i = 0; i < c; i++)
        {
            Console.Write("\n");
            for (j = 0; j < r; j++)
            {
                Console.Write("{0}\t", matrix2[i, j]);
            }
        }
        Console.Write("\n\n");
    }
}
