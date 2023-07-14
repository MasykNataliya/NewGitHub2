using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   public static double (int figure, double perimeter, double square)
    {
    Console.WriteLine("Оберіть фігуру: 1- коло, 2- трикутник, 3- чотирикутник");
    figure = Console.ReadLine();
    switch (figure)
    { case 1:
            double radius;
            Console.Write(" Введіть радіус кола");
            radius = Console.ReadLine();
            double Pi;
            Pi = 3.1415926;
            perimeter = 2 * Pi * radius;
            square = Pi * (radius * radius);
            Console.WriteLine($"Площа кола = {square}; переметр = {perimeter}");
            break;
        case 2:
            double OneSide;
            double SecondSide;
            Console.Write(" Введіть першу сторону чотирикутника");
            radius = Console.ReadLine();
            perimeter = 2*OneSide +2*SecondSide;
            square = OneSide *SecondSide;
            Console.WriteLine($"Площа чотирикутника = {square}; переметр = {perimeter}");
            break;
        case 3:
            double OneSide;
            double SecondSide;
            Console.Write(" Введіть першу сторону чотирикутника");
            radius = Console.ReadLine();
            perimeter = 2 * OneSide * SecondSide;
            square = Pi * (radius * radius);
            Console.WriteLine($"Площа чотирикутника = {square}; переметр = {perimeter}");
            break;
    }
    }

