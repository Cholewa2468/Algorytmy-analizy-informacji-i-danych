using System;
using System.Data;
using System.Diagnostics;
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
        MiddlePoint(x1, x2, y1, y2);

        // Obliczanie kąta odcinka w układzie współrzędnych
        Angle(x1, x2, y1, y2);

        int xA = 1;
        int yA = 1;
        int xB = 4;
        int yB = 5;
        int xC = 7;
        int yC = 2;

        // Obliczanie powierzchni trójkąta
        TriangleArea(xA, yA, xB, yB, xC, yC);

        // Sprawdzanie, czy linia przechodzi przez okrąg
        CirceRelation(0, 0, 5, x1, y1, x2, y2);

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

    // C) polecenie nie napisane w języku polskim przystępnym do zrozumienia

    // D) Obliczanie powierzchni trójkąta
    static double TriangleArea(int xA, int yA, int xB, int yB, int xC, int yC)
    {
        double area = Math.Abs((xA * (yB - yC) + xB * (yC - yA) + xC * (yA - yB)) / 2.0);
        //  Wzór P = 1/2 * |xA(yB - yC) + xB(yC - yA) + xC(yA - yB)|
        Console.WriteLine($"Powierzchnia trójkąta o wierzchołkach A({xA}, {yA}), B({xB}, {yB}), C({xC}, {yC}) wynosi: {area}");
        return area;
    }


    // E) Sprawdzający, czy linia przechodzi, nie przechodzi lub styka się z okręgiem
    // dane okręgu: środek (x0, y0), promień r
    // dane odcinka: A(x1, y1), B(x2, y2)

    //              |(x2 - x1)(y1 - y0) - (x1 - x0)(y2 - y1)|
    // wzór: dist = -----------------------------------------
    //                   sqrt((x2 - x1)^2 + (y2 - y1)^2)

    static double CirceRelation(int x0, int y0, int r, int x1, int y1, int x2, int y2)
    {
        double dist = Math.Abs((x2-x1) * (y1 - y0) - (x1 - x0) * (y2 - y1))/Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        if (dist < r){
            Console.WriteLine($"Dystans odcinka do okręgu: {dist} < {r} -> przecina się");
        }     
        else if (Math.Abs(dist - r) < 1e-9){ // uwzględniamy błędy zaokrągleń
            Console.WriteLine($"Dystans odcinka do okręgu: {dist} = {r} -> styka się");
        }   
        else {
            Console.WriteLine($"Dystans odcinka do okręgu: {dist} > {r} -> nie przecina się");
        }
        return 0;
    }
}
