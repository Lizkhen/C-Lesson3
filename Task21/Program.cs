Console.WriteLine ("Введите координаты x1, y1, z1 и x2, y2, z2");
double ab = 0;
double [] point = new double [6];
for (int i = 0; i < point.Length; i++)
    point [i] = Convert.ToDouble (Console.ReadLine());
ab = Math.Sqrt ((point[3]-point[0])*(point[3]-point[0]) + (point[4]-point[1])*(point[4]-point[1]) + 
(point[5]-point[2])*(point[5]-point[2]));
Console.WriteLine (ab); 