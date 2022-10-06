using System;

int A = 0;
int B = 0;
int VF = 0;

Console.WriteLine("Digite o 1º valor:");
Console.WriteLine("Número:");
A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o 2º valor:");
B = Convert.ToInt32(Console.ReadLine());

VF = A - B;

if (VF >= 0)
{
    Console.WriteLine($"O resultado dos valores digitados é positivo! {VF}");
}

else
{
    Console.WriteLine($"O resultado dos valores digitados é negativo! {VF}");
}
