using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
// A)
        string text = File.ReadAllText("tekst.txt"); // Odczytanie całego pliku
        string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            
        MatrixAddition(2); 
        MatrixAddition(3); 
        MatrixAddition(4); 
        MatrixAddition(5);  

// B)
        string text2 = File.ReadAllText("tekst2.txt"); // Odczytanie całego pliku
        string[] words2 = text2.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        MatrixMultiplication(2);
        MatrixMultiplication(3);
        MatrixMultiplication(4);
        MatrixMultiplication(5);
    {
    }

    //sortowanie algorytmy operacji na macierzy
    static int MatrixAddition(int n)
    {
        int steps = 0; // Zmienna do zliczania kroków
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                //C[i, j] = A[i, j] + B[i, j]; 
                // Dodawanie elementów macierzy A i B i przypisanie do C
                steps += 1; // Zliczanie kroków
        Console.WriteLine("Liczba kroków dla macierzy " + n + "x" + n + ": " + steps);
        return steps; // Zwracanie liczby kroków
    }

    static int MatrixMultiplication(int n)
    {
        int steps = 0; // Zmienna do zliczania kroków
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                //C[i, j] = A[i, j] + B[i, j]; 
                // Dodawanie elementów macierzy A i B i przypisanie do C
                steps += 1; // Zliczanie kroków
        Console.WriteLine("Liczba kroków dla macierzy " + n + "x" + n + ": " + steps);
        return steps; // Zwracanie liczby kroków
    }
}
