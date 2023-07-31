// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки в 3d пространстве: ");
Console.Write("X1: ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки в 3d пространстве: ");
Console.Write("Y1: ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки в 3d пространстве: ");
Console.Write("Z1: ");
int z1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки в 3d пространстве: ");
Console.Write("X2: ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки в 3d пространстве: ");
Console.Write("Y2: ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки в 3d пространстве: ");
Console.Write("Z2: ");
int z2Coordinate = Convert.ToInt32(Console.ReadLine());


double dist = Distance(x1Coordinate, y1Coordinate, z1Coordinate, x2Coordinate, y2Coordinate, z2Coordinate);
double distRound = Math.Round(dist, 2);

// double Distance (int x1, y1, z1, )
Console.WriteLine($"Расстояние между точками: {distRound}");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
   // int a1 = x1 - x2; 
   // int a2 = y1 - y2;
   // int a3 = z1 - z2;
   double distance = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
   return distance;
}


