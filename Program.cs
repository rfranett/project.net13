Console.WriteLine("listas.\n");

List<string> listString = new List<string>();

listString.Add("Sp");
listString.Add("BA");
listString.Add("MG");
listString.Add("RJ");

Console.WriteLine($"Itens na minha LIsta: {listString.Count} - Capacidade:{listString.Capacity}");

listString.Add("SC");

Console.WriteLine($"itens na minha lista: {listString.Count} - capacidade: {listString.Capacity}");

listString.Remove("MG");

Console.WriteLine($"itens na minha lista: {listString.Count} - capacidade: {listString.Capacity}");





/*
Console.WriteLine("Array de Inteiros .\n");

int[] arrayInteiros = new int[4];

arrayInteiros[0] = 73;
arrayInteiros[1] = 11;
arrayInteiros[2] = 10;
arrayInteiros[3] = 9;


//int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2]; aqui é criado e copiado e assim almentando o array quando criamos o arrayInteirosDobrados uzamos a Array.Copy para copiar o arrayInteiros.Length para ele.
//Array.Copy(arrayInteiros, arrayInteirosDobrados,arrayInteiros.Length);


//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); aqui dobra o tamanho de um array 


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
*/