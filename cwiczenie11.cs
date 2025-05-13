using System;
using System.IO;
using System.Linq;

class Program
{

    static void Main()
    {
        
        int x1 = 2;
        int y1 = 5;
        int x2 = 4;
        int y2 = 9;

        // Obliczanie środka odcinka w układzie współrzędnych
        double Middle = MiddlePoint(x1, x2, y1, y2);

        // Obliczanie kąta odcinka w układzie współrzędnych
        double arc = Angle(x1, x2, y1, y2);

        

    }
    // A) Metoda obliczająca środek odcinka
    //    Wyszukiwania punktu środowego odcinka w przestrzeni 2D
    static double MiddlePoint(int x1, int y1, int x2, int y2)
    {
        double middleX = (x1 + x2) / 2.0;
        double middleY = (y1 + y2) / 2.0;

        Console.WriteLine($"Środek odcinka ({x1}, {y1}) <-> ({x2}, {y2}) to ({middleX}, {middleY})");
        return Math.Sqrt(Math.Pow(middleX, 2) + Math.Pow(middleY, 2));
    }

    // B) Obliczania kąta odcinka w przestrzeni 2D
    //    arctan to funkcja odwrotna do tangensa, która zwraca kąt w radianach
    static double Angle(int x1, int y1, int x2, int y2)
    {
        double angleDeg = Math.Atan2(x2 - x1, y2 - y1) * (180 / Math.PI); // konwersja radianów na stopnie

        Console.WriteLine($"Punkt A: ({x1}, {y1})");
        Console.WriteLine($"Punkt B: ({x2}, {y2})");
        Console.WriteLine($"Kąt odcinka względem osi X: {angleDeg:F2}°");
        return Math.Atan2(x2 - x1, y2 - y1) * (180 / Math.PI);
    }
}
