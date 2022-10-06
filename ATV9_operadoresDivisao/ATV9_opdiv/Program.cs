using System;

int A = 0;
int B = 0;
int VF = 0;

Console.WriteLine("Digite dois valores desejados para que seja feito uma divisão e para que seja imprimido o resto da operação");

Console.WriteLine("Digite o 1º valor:");
A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o 2º valor:");
B = Convert.ToInt32(Console.ReadLine());

VF = A % B;

Console.WriteLine($"Veja o que sobrou da operação da divisão: {VF}");

