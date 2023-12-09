// дана прямоугольная матрица a, имеющей n строк и m столбцов. Исходная матрица состоит из нулей и единиц.
// Добавьте к матрице еще один столбец, каждый элемент которого делает количество единиц в каждой строке четным;

using System;
using System.Security.Cryptography.X509Certificates;

class work_6_5
{
    static void Main()
    {
        int n = 3; 
        int m = 4; 
        Random rand = new Random(); 
        int[,] originalMatrix = new int[n, m];  

        for (int iRow = 0; iRow < n; iRow++)
        {
            for (int iCol = 0; iCol < m; iCol++) 
            {
                originalMatrix[iRow, iCol] = rand.Next(0, 2); 
            }
        }

        int[,] newMatrix = new int[n, m + 1];

        for (int iRow = 0; iRow < n; iRow++)
        {
            for (int iCol = 0; iCol < m; iCol++)
            {
                newMatrix[iRow, iCol] = originalMatrix[iRow, iCol];
            }
        }

        for (int iRow = 0; iRow < n; iRow++)
        {
            int count = 0; 

            for (int iCol = 0; iCol < m; iCol++)
            {
                if (originalMatrix[iRow, iCol] == 1) 
                {
                    count++; 
                }
            }

            if (count % 2 != 0) 
            {
                newMatrix[iRow, m] = 1; 
            }
            else
            {
                newMatrix[iRow, m] = 0; 
            }
        }

        for (int iRow = 0; iRow < n; iRow++)
        {
            for (int iCol = 0; iCol < m + 1; iCol++)
            {
                Console.Write($"{newMatrix[iRow, iCol]} ");
            }
            Console.WriteLine(); 
        }
    }
}
