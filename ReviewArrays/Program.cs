//arrays

string nome = "Livia";
Console.WriteLine($"Nome: {nome}");

string[] nomes = new string[4];

nomes[0] = "Amy Lee";
nomes[1] = "Eloysa";
nomes[2] = "Pedro Enzo";
nomes[3] = "Henrique";

Console.WriteLine();

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);
}
