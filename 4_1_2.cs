using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 16
            //Console.Write("Введите координату x точки: ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("Введите координату y точки: ");
            //double y = double.Parse(Console.ReadLine());
            //Console.Write("Введите внутренний радиус тора r: ");
            //double r = double.Parse(Console.ReadLine());
            //Console.Write("Введите внешний радиус тора R: ");
            //double R = double.Parse(Console.ReadLine());

            //double distance = Math.Sqrt(x * x + y * y);

            //if (distance >= r && distance <= R)
            //{
            //    Console.WriteLine("Точка лежит внутри тора.");
            //}
            //else
            //{
            //    Console.WriteLine("Точка не лежит внутри тора.");
            //}

            //17
            //Console.Write("Введите координату x точки: ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("Введите координату y точки: ");
            //double y = double.Parse(Console.ReadLine());

            //if (x > 0 && y < 0)
            //{
            //    Console.WriteLine("Точка лежит в четвёртой четверти.");
            //}
            //else
            //{
            //    Console.WriteLine("Точка не лежит в четвёртой четверти.");
            //}

            //18
            //Console.Write("Введите сторону a: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Введите сторону b: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Введите сторону c: ");
            //double c = double.Parse(Console.ReadLine());

            //if (a == b || a == c || b == c)
            //{
            //    Console.WriteLine("Треугольник является равнобедренным.");
            //}
            //else
            //{
            //    Console.WriteLine("Треугольник не является равнобедренным.");
            //}

            //19
            //Console.Write("Введите число a: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Введите число b: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Введите число c: ");
            //double c = double.Parse(Console.ReadLine());

            //if (c * c == a * a + b * b || a * a == b * b + c * c || b * b == a * a + c * c)
            //{
            //    Console.WriteLine("Числа являются тройкой Пифагора.");
            //}
            //else
            //{
            //    Console.WriteLine("Числа не являются тройкой Пифагора.");
            //}

            //20
            //double speed1 = 1.0 / 1000;
            //double speed2 = 1e7 / 60;

            //if (speed1 > speed2)
            //{
            //    Console.WriteLine("Скорость 1 л/с больше.");
            //}
            //else
            //{
            //    Console.WriteLine("Скорость 10^7 м³/мин больше.");
            //}

            //21
            //Console.Write("Введите площадь круга: ");
            //double circleArea = double.Parse(Console.ReadLine());
            //Console.Write("Введите площадь квадрата: ");
            //double squareArea = double.Parse(Console.ReadLine());

            //double circleRadius = Math.Sqrt(circleArea / Math.PI);
            //double squareSide = Math.Sqrt(squareArea);

            //if (circleRadius * 2 <= squareSide)
            //{
            //    Console.WriteLine("Круг умещается в квадрате.");
            //}
            //else
            //{
            //    Console.WriteLine("Круг не умещается в квадрате.");
            //}

            //if (Math.Sqrt(2) * squareSide / 2 <= circleRadius)
            //{
            //    Console.WriteLine("Квадрат умещается в круге.");
            //}
            //else
            //{
            //    Console.WriteLine("Квадрат не умещается в круге.");
            //}


            //22
            //Console.Write("Введите массу первого тела: ");
            //double mass1 = double.Parse(Console.ReadLine());
            //Console.Write("Введите объём первого тела: ");
            //double volume1 = double.Parse(Console.ReadLine());

            //Console.Write("Введите массу второго тела: ");
            //double mass2 = double.Parse(Console.ReadLine());
            //Console.Write("Введите объём второго тела: ");
            //double volume2 = double.Parse(Console.ReadLine());

            //double density1 = mass1 / volume1;
            //double density2 = mass2 / volume2;

            //if (density1 > density2)
            //{
            //    Console.WriteLine("Плотность материала первого тела больше.");
            //}
            //else if (density2 > density1)
            //{
            //    Console.WriteLine("Плотность материала второго тела больше.");
            //}
            //else
            //{
            //    Console.WriteLine("Плотности материалов тел равны.");
            //}

            //23
            //Console.Write("Введите скорость в км/ч: ");
            //double speedKmh = double.Parse(Console.ReadLine());
            //Console.Write("Введите скорость в м/с: ");
            //double speedMs = double.Parse(Console.ReadLine());

            //double speedKmhToMs = speedKmh * 1000 / 3600;

            //if (speedKmhToMs > speedMs)
            //{
            //    Console.WriteLine("Скорость в км/ч больше.");
            //}
            //else if (speedMs > speedKmhToMs)
            //{
            //    Console.WriteLine("Скорость в м/с больше.");
            //}
            //else
            //{
            //    Console.WriteLine("Скорости равны.");
            //}

            //24
            //Console.Write("Введите площадь равностороннего треугольника: ");
            //double triangleArea = double.Parse(Console.ReadLine());
            //Console.Write("Введите площадь круга: ");
            //double circleArea = double.Parse(Console.ReadLine());

            //double a = Math.Sqrt(triangleArea * 4 / Math.Sqrt(3));
            //double r = Math.Sqrt(circleArea / Math.PI);

            //double rInTriangle = a * Math.Sqrt(3) / 6;
            //if (r <= rInTriangle)
            //{
            //    Console.WriteLine("Круг умещается в треугольнике.");
            //}
            //else
            //{
            //    Console.WriteLine("Круг не умещается в треугольнике.");
            //}

            //double rAroundTriangle = a * Math.Sqrt(3) / 3;
            //if (r >= rAroundTriangle)
            //{
            //    Console.WriteLine("Треугольник умещается в круге.");
            //}
            //else
            //{
            //    Console.WriteLine("Треугольник не умещается в круге.");
            //}

            //25
            //Console.Write("Введите массу первой планеты (в кг): ");
            //double mass1 = double.Parse(Console.ReadLine());
            //Console.Write("Введите радиус первой планеты (в м): ");
            //double radius1 = double.Parse(Console.ReadLine());

            //Console.Write("Введите массу второй планеты (в кг): ");
            //double mass2 = double.Parse(Console.ReadLine());
            //Console.Write("Введите радиус второй планеты (в м): ");
            //double radius2 = double.Parse(Console.ReadLine());

            //double g1 = 6.67430e-11 * mass1 / (radius1 * radius1);
            //double g2 = 6.67430e-11 * mass2 / (radius2 * radius2);

            //if (g1 > g2)
            //{
            //    Console.WriteLine("Ускорение силы тяжести на первой планете больше.");
            //}
            //else if (g2 > g1)
            //{
            //    Console.WriteLine("Ускорение силы тяжести на второй планете больше.");
            //}
            //else
            //{
            //    Console.WriteLine("Ускорения силы тяжести на планетах равны.");
            //}

            //26
            //Console.Write("Введите текущий час (0-23): ");
            //int hour = int.Parse(Console.ReadLine());

            //if (hour >= 0 && hour < 12)
            //{
            //    Console.WriteLine("Сейчас pm.");
            //}
            //else
            //{
            //    Console.WriteLine("Сейчас am.");
            //}

            //27
            //Console.Write("Введите географическую долготу: ");
            //double longitude = double.Parse(Console.ReadLine());

            //if (longitude > 0)
            //{
            //    Console.WriteLine("Место находится в восточном полушарии.");
            //}
            //else if (longitude < 0)
            //{
            //    Console.WriteLine("Место находится в западном полушарии.");
            //}
            //else
            //{
            //    Console.WriteLine("Место находится на нулевом меридиане.");
            //}

            //28
            //double siriusDistanceKm = 8.14e12;
            //double arcturusDistancePc = 103;
            //double arcturusDistanceKm = arcturusDistancePc * 3.259 * 9.461e12;

            //if (siriusDistanceKm > arcturusDistanceKm)
            //{
            //    Console.WriteLine("Сириус находится дальше.");
            //}
            //else
            //{
            //    Console.WriteLine("Арктур находится дальше.");
            //}

            //29
            //Console.Write("Введите натуральное число: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0 || number % 10 == 7)
            //{
            //    Console.WriteLine("Число является чётным или оканчивается цифрой 7.");
            //}
            //else
            //{
            //    Console.WriteLine("Число не является чётным и не оканчивается цифрой 7.");
            //}

            //30
            //Console.Write("Введите натуральное число: ");
            //int number = int.Parse(Console.ReadLine());

            //bool isEven = number % 2 == 0;

            //bool endsWithSeven = number % 10 == 7;

            //if (isEven || endsWithSeven)
            //{
            //    Console.WriteLine("Число является чётным или оканчивается цифрой 7.");
            //}
            //else
            //{
            //    Console.WriteLine("Число не является чётным и не оканчивается цифрой 7.");
            //}

                Console.ReadKey();
        }
    }
}