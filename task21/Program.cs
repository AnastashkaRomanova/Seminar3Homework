//Задача 21: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7) ->15,84
//A (7,-5,0); B (1,-1,9) -> 11, 53

Console.WriteLine("ВВедите координату Х первой точки: ");
int userX1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите координату Y первой точки: ");
int userY1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите координату Z первой точки: ");
int userZ1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите координату Х второй точки: ");
int userX2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите координату Y второй точки: ");
int userY2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите координату Z второй точки: ");
int userZ2 = Convert.ToInt32(Console.ReadLine());


double segment = Math.Sqrt((userY2 - userY1) * (userY2 - userY1) + (userX2 - userX1) * (userX2 - userX1) + (userZ2 - userZ1) * (userZ2 - userZ1));
segment = Math.Round(segment, 3);
Console.WriteLine($"Расстояние между точками равно: {segment}");
