
Console.WriteLine("Array de Inteiros .\n");

int[] arrayInteiros = new int[4];

arrayInteiros[0] = 73;
arrayInteiros[1] = 11;
arrayInteiros[2] = 10;
arrayInteiros[3] = 9;

Console.WriteLine("Percorrendo o Array com o For");
for (int contador = 0 ; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"posicão N° {contador} - {arrayInteiros[contador]}");
}

Console.WriteLine("Percorrendo o Array com o Foreach");

int ContadorForeach = 0;
foreach(int valor in arrayInteiros)
{
    Console.WriteLine($"Posição N° {ContadorForeach} - {valor}");
    ContadorForeach ++;
}
