using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        int x, y, z;

        Console.WriteLine("Unesite dužinu stranice x:");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("Unesite dužinu stranice y:");
        y = int.Parse(Console.ReadLine());

        Console.WriteLine("Unesite dužinu stranice z:");
        z = int.Parse(Console.ReadLine());

        if (x <= 0 || y <= 0 || z <= 0)
        {
            Console.WriteLine("Svi unosi moraju biti veći od 0.");
        }
        else if (IsRightTriangle(x, y, z))
        {
            Console.WriteLine("Unesene stranice čine pravokutni trokut.");
        }
        else
        {
            Console.WriteLine("Unesene stranice ne čine pravokutni trokut.");
        }
        Console.ReadKey();
    }

    static bool IsRightTriangle(int a, int b, int c)
    {
        return (a * a + b * b == c * c) ||
               (a * a + c * c == b * b) ||
               (b * b + c * c == a * a);
    }
    
}
