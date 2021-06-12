using System;
//Tipos de Triangulo
class Desafio
{

    public static void Main()
    {
        string[] s = Console.ReadLine().Split(' ');
        double a = double.Parse(s[0]);
        double b = double.Parse(s[1]);
        double c = double.Parse(s[2]);
        double aux;

        if (b > a && b > c)
        {
            aux = a;
            a = b;
            b = aux;
        }
        else if (c > a)
        {
            aux = a;
            a = c;
            c = aux;
        }

        if (a >= (b + c))
            Console.WriteLine("NAO FORMA TRIANGULO");
        else if (a * a == (b * b) + (c * c))
            Console.WriteLine("TRIANGULO RETANGULO");
        else if (a * a > (b * b) + (c * c))
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        else if (a * a < (b * b) + (c * c))
            Console.WriteLine("TRIANGULO ACUTANGULO");
        if (a == b && a == c)
            Console.WriteLine("TRIANGULO EQUILATERO");
        if ((a == b && a != c) || (a == c && a != b) || (b == c && b != a))
            Console.WriteLine("TRIANGULO ISOSCELES");

        Console.ReadLine();
    }
}