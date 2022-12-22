// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.Write("Введите коррдинату x точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine()); 
System.Console.Write("Введите коррдинату y точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коррдинату z точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коордианту x точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine()); 
System.Console.Write("Введите коордианту y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коррдинату z точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2)),2); 
System.Console.WriteLine($"Расстояние между двумя точками: {result}");