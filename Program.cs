Console.Write("Digite a palavra que deseja inverter: ");
string palavra = Console.ReadLine();
char[] caracteres = palavra.ToCharArray();
int tamanho = palavra.Length;

for(int i = 0; i < tamanho / 2; i++)
{

    char temporaria = caracteres[i];
    caracteres[i] = caracteres[tamanho - 1 - i];
    caracteres[tamanho - 1 - i] = temporaria;

}

string PalavraInvertida = new string(caracteres);
Console.WriteLine($"A palavra invertida é: {PalavraInvertida}");