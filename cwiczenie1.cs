using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
            string text = File.ReadAllText("tekst.txt"); // Odczytanie całego pliku
            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            char litera = 'a';
            
            int steps = FindFirstWordStartingWithA(words, litera);

            if (steps != -1)
                Console.WriteLine($"Pierwsze słowo na '{litera}' lub '{char.ToUpper(litera)}' znalezione po {steps} krokach.");
            else
                Console.WriteLine("Brak słowa rozpoczynającego się na '{litera}' w pliku.");
    }

    static int FindFirstWordStartingWithA(string[] words, char litera)
    {
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i][0] == litera || words[i][0] == char.ToUpper(litera))// Sprawdzamy pierwszą literę
                return i + 1; // Liczymy kroki od 1
        }
        return -1; // Jeśli nie znaleziono
    }
}
