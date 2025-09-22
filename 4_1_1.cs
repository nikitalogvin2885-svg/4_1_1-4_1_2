using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.Write("Введите первое число: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Введите второе число: ");
            //double b = double.Parse(Console.ReadLine());

            //double sumSquares = a * a + b * b;
            //double squareSum = (a + b) * (a + b);

            //if (sumSquares > squareSum)
            //{
            //    Console.WriteLine("Сумма квадратов больше квадрата суммы.");
            //}
            //else if (sumSquares < squareSum)
            //{
            //    Console.WriteLine("Квадрат суммы больше суммы квадратов.");
            //}
            //else
            //{
            //    Console.WriteLine("Сумма квадратов равна квадрату суммы.");
            //}

            //2
            //Console.Write("Введите зарплату: ");
            //double salary = double.Parse(Console.ReadLine());
            //Console.Write("Введите стаж: ");
            //int experience = int.Parse(Console.ReadLine());

            //double bonus = 0;
            //if (experience >= 2 && experience < 5)
            //{
            //    bonus = salary * 0.02;
            //}
            //else if (experience >= 5 && experience <= 10)
            //{
            //    bonus = salary * 0.05;
            //}

            //double totalSalary = salary + bonus;
            //Console.WriteLine($"Надбавка: {bonus:F2}");
            //Console.WriteLine($"Сумма выплаты: {totalSalary:F2}");

            //3
            //Console.Write("Введите координату x точки A: ");
            //double x0 = double.Parse(Console.ReadLine());
            //Console.Write("Введите координату y точки A: ");
            //double y0 = double.Parse(Console.ReadLine());

            //Console.Write("Введите координату x точки B: ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("Введите координату y точки B: ");
            //double y1 = double.Parse(Console.ReadLine());

            //double distanceA = Math.Sqrt(x0 * x0 + y0 * y0);
            //double distanceB = Math.Sqrt(x1 * x1 + y1 * y1);

            //if (Math.Abs(distanceA - distanceB) < 0.0001)
            //{
            //    Console.WriteLine("Точки A и B находятся на одинаковом расстоянии от начала координат.");
            //}
            //else if (distanceA > distanceB)
            //{
            //    Console.WriteLine("Точка A наиболее удалена от начала координат.");
            //}
            //else
            //{
            //    Console.WriteLine("Точка B наиболее удалена от начала координат.");
            //}

            //4
            //Console.Write("Введите сторону a: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Введите сторону b: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Введите сторону c: ");
            //double c = double.Parse(Console.ReadLine());

            //bool isRightTriangle = false;
            //if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a))
            //{
            //    isRightTriangle = true;
            //}

            //if (isRightTriangle)
            //{
            //    Console.WriteLine("Треугольник является прямоугольным.");
            //}
            //else
            //{
            //    Console.WriteLine("Треугольник не является прямоугольным.");
            //}

            //5
            //Console.Write("Введите первое число: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Введите второе число: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Введите третье число: ");
            //double c = double.Parse(Console.ReadLine());

            //a = a > 0 ? a * a : a;
            //b = b > 0 ? b * b : b;
            //c = c > 0 ? c * c : c;

            //Console.WriteLine($"Результат: {a}, {b}, {c}");

            //6
            //Console.Write("Введите координату x точки: ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("Введите координату y точки: ");
            //double y = double.Parse(Console.ReadLine());

            //if (x > 0 && y > 0)
            //{
            //    Console.WriteLine("Точка лежит в первой четверти.");
            //}
            //else if (x < 0 && y > 0)
            //{
            //    Console.WriteLine("Точка лежит во второй четверти.");
            //}
            //else if (x < 0 && y < 0)
            //{
            //    Console.WriteLine("Точка лежит в третьей четверти.");
            //}
            //else if (x > 0 && y < 0)
            //{
            //    Console.WriteLine("Точка лежит в четвёртой четверти.");
            //}
            //else
            //{
            //    Console.WriteLine("Точка лежит на оси координат.");
            //}

            //7
            //Console.Write("Введите координату x точки: ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("Введите координату y точки: ");
            //double y = double.Parse(Console.ReadLine());
            //Console.Write("Введите радиус окружности: ");
            //double R = double.Parse(Console.ReadLine());

            //double distance = Math.Sqrt(x * x + y * y);

            //if (distance <= R)
            //{
            //    Console.WriteLine("Точка лежит внутри окружности.");
            //}
            //else
            //{
            //    Console.WriteLine("Точка не лежит внутри окружности.");
            //}

            //8
            //double CalculateTriangleArea(double a, double b, double c)
            //{
            //    double p = (a + b + c) / 2;
            //    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            //}

            //Console.Write("Введите сторону a1 первого треугольника: ");
            //double a1 = double.Parse(Console.ReadLine());
            //Console.Write("Введите сторону b1 первого треугольника: ");
            //double b1 = double.Parse(Console.ReadLine());
            //Console.Write("Введите сторону c1 первого треугольника: ");
            //double c1 = double.Parse(Console.ReadLine());

            //Console.Write("Введите сторону a2 второго треугольника: ");
            //double a2 = double.Parse(Console.ReadLine());
            //Console.Write("Введите сторону b2 второго треугольника: ");
            //double b2 = double.Parse(Console.ReadLine());
            //Console.Write("Введите сторону c2 второго треугольника: ");
            //double c2 = double.Parse(Console.ReadLine());

            //double area1 = CalculateTriangleArea(a1, b1, c1);
            //double area2 = CalculateTriangleArea(a2, b2, c2);

            //if (area1 > area2)
            //{
            //    Console.WriteLine("Площадь первого треугольника больше.");
            //}
            //else if (area2 > area1)
            //{
            //    Console.WriteLine("Площадь второго треугольника больше.");
            //}
            //else
            //{
            //    Console.WriteLine("Площади треугольников равны.");
            //}

            //9
            //Console.Write("Введите сторону квадрата a: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Введите радиус окружности R: ");
            //double R = double.Parse(Console.ReadLine());

            //double squareArea = a * a;
            //double circleArea = Math.PI * R * R;

            //if (squareArea > circleArea)
            //{
            //    Console.WriteLine("Площадь квадрата больше.");
            //}
            //else if (circleArea > squareArea)
            //{
            //    Console.WriteLine("Площадь окружности больше.");
            //}
            //else
            //{
            //    Console.WriteLine("Площади квадрата и окружности равны.");
            //}

            //10
            //Console.Write("Введите первое число: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Введите второе число: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Введите третье число: ");
            //double c = double.Parse(Console.ReadLine());

            //a = a > 0 ? a * a * a : 0;
            //b = b > 0 ? b * b * b : 0;
            //c = c > 0 ? c * c * c : 0;

            //Console.WriteLine($"Результат: {a}, {b}, {c}");

            //11
            //Console.Write("Введите натуральное число: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0 || number % 10 == 3)
            //{
            //    Console.WriteLine("Число является чётным или оканчивается цифрой 3.");
            //}
            //else
            //{
            //    Console.WriteLine("Число не является чётным и не оканчивается цифрой 3.");
            //}

            //12
            //Console.Write("Введите координату x точки: ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("Введите координату y точки: ");
            //double y = double.Parse(Console.ReadLine());

            //if (x > 0 && y > 0)
            //{
            //    Console.WriteLine("Точка лежит в первой четверти.");
            //}
            //else
            //{
            //    Console.WriteLine("Точка не лежит в первой четверти.");
            //}

            //13
            //Console.Write("Введите сумму вклада: ");
            //double deposit = double.Parse(Console.ReadLine());
            //Console.Write("Введите срок договора в месяцах: ");
            //int term = int.Parse(Console.ReadLine());

            //double monthlyPayment;
            //if (term == 6)
            //{
            //    monthlyPayment = deposit * (1 + 0.06 / 12);
            //}
            //else if (term == 12)
            //{
            //    monthlyPayment = deposit * (1 + 0.08 / 12);
            //}
            //else
            //{
            //    Console.WriteLine("Некорректный срок договора.");
            //    return;
            //}

            //Console.WriteLine($"Сумма ежемесячных выплат: {monthlyPayment:F2}");

            //14
            //Console.Write("Введите первое число: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Введите второе число: ");
            //double b = double.Parse(Console.ReadLine());

            //double sumSquares = a * a + b * b;
            //double absSquareDiff = Math.Abs((a - b) * (a - b));

            //if (sumSquares > absSquareDiff)
            //{
            //    Console.WriteLine("Сумма квадратов больше модуля квадрата разности.");
            //}
            //else if (sumSquares < absSquareDiff)
            //{
            //    Console.WriteLine("Модуль квадрата разности больше суммы квадратов.");
            //}
            //else
            //{
            //    Console.WriteLine("Сумма квадратов равна модулю квадрата разности.");
            //}

            //15
            //Console.Write("Введите координату x точки A: ");
            //double x0 = double.Parse(Console.ReadLine());
            //Console.Write("Введите координату y точки A: ");
            //double y0 = double.Parse(Console.ReadLine());

            //Console.Write("Введите координату x точки B: ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("Введите координату y точки B: ");
            //double y1 = double.Parse(Console.ReadLine());

            //double distanceA = Math.Sqrt(x0 * x0 + y0 * y0);
            //double distanceB = Math.Sqrt(x1 * x1 + y1 * y1);

            //if (Math.Abs(distanceA - distanceB) < 0.0001)
            //{
            //    Console.WriteLine("Точки A и B находятся на одинаковом расстоянии от начала координат.");
            //}
            //else if (distanceA < distanceB)
            //{
            //    Console.WriteLine("Точка A наименее удалена от начала координат.");
            //}
            //else
            //{
            //    Console.WriteLine("Точка B наименее удалена от начала координат.");
            //}


            Console.ReadKey();
        }
    }
}