using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
// A) dodawanie macierzy
            
        MatrixAddition(2); 
        MatrixAddition(3); 
        MatrixAddition(4); 
        MatrixAddition(5);  

// B) mnożenie macierzy

        MatrixMultiplication(2,3,4); // Mnożenie macierzy 2x3 i 3x4
        MatrixMultiplication(3,4,5); // Mnożenie macierzy 3x4 i 4x5
        MatrixMultiplication(4,5,4); // Mnożenie macierzy 4x5 i 5x4
// C) Transpozycja macierzy

        int[,] original = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        Console.WriteLine("Oryginalna macierz (2x3):");
        PrintMatrix(original);

        int[,] transposed = TransposeMatrix(original);

        Console.WriteLine("\nTransponowana macierz (3x2):");
        PrintMatrix(transposed);

    }

    //algorytmy operacji na macierzy
    static int MatrixAddition(int n)
    {
        int steps = 0; // Zmienna do zliczania kroków
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                //C[i, j] = A[i, j] + B[i, j]; 
                // Dodawanie elementów macierzy A i B i przypisanie do C
                steps++;; // Zliczanie kroków
        Console.WriteLine("Liczba kroków dla macierzy " + n + "x" + n + ": " + steps);
        return steps; // Zwracanie liczby kroków
    }

    static int MatrixMultiplication(int rowsA, int colsA, int colsB)
    {
        int steps = 0;

        // Symulacja mnożenia macierzy A (rowsA x colsA) i B (colsA x colsB)
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                for (int k = 0; k < colsA; k++)
                {
                    // Symulujemy operację: C[i,j] += A[i,k] * B[k,j];
                    steps++;
                }
            }
        }

        Console.WriteLine($"Liczba kroków dla macierzy {rowsA}x{colsA} * {colsA}x{colsB}: {steps}");
        return steps;
    }

    // Funkcja wypisująca macierz
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0); // Liczba wierszy
        int cols = matrix.GetLength(1); // Liczba kolumn

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Funkcja transponująca macierz n×m → m×n
    static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0); // Liczba wierszy
        int cols = matrix.GetLength(1); // Liczba kolumn
        int[,] transposed = new int[cols, rows]; // Tworzenie nowej macierzy transponowanej

        // Transponowanie macierzy
        // Iteracja przez każdy element macierzy oryginalnej
        // i przypisanie go do odpowiedniego miejsca w macierzy transponowanej
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                transposed[j, i] = matrix[i, j];

        return transposed;
    }
}
