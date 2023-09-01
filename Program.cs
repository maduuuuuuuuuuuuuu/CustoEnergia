﻿﻿Console.Clear();
Console.WriteLine("Estime o seu Custo de Energia");
Console.WriteLine("Por quantas horas diárias você usa o aparelho?");
double h;
h = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Qual o consumo do aparelho em kWh por mês?");
double kWh;
kWh = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Qual o custo de kWh por hora)");
double rs;
rs = Convert.ToDouble(Console.ReadLine()!);
double custo;
custo = h * kWh * rs;
double valortotal;
valortotal = Math.Round(custo, 2);
Console.WriteLine("--Custo de Energia--");
Console.WriteLine($"Consumo do aparelho (em kWh/mês)...: {kWh}");
Console.WriteLine($"Horas de uso por dia...............: {h}");
Console.WriteLine($"Custo da energia (em R$/kWh).......: {rs}");
Console.WriteLine("");
Console.WriteLine($"Custo estimado: {valortotal}");
