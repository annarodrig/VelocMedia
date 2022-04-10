double d, t, v;

Console.Write("Distância percorrida (m):");
d = Convert.ToDouble (Console.ReadLine());

Console.Write("Tempo gasto (s):");
t = Convert.ToDouble (Console.ReadLine());

v = d / t;

Console.WriteLine($"Velocidade média:{v:N2}m/s");