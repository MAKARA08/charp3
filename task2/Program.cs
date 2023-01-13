Console.WriteLine("введите координаты x, y, z точки А");
int ax = Convert.ToInt32(Console.ReadLine());
int ay = Convert.ToInt32(Console.ReadLine());
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты x, y, z точки B");
int bx = Convert.ToInt32(Console.ReadLine());
int by = Convert.ToInt32(Console.ReadLine());
int bz = Convert.ToInt32(Console.ReadLine());

int countx = (bx - ax) * (bx - ax);
int county = (by - ay) * (by - ay);
int countz = (bz - az) * (bz - az);

double result = Math.Round(Math.Sqrt(countx + county + countz), 2);
Console.WriteLine(result);