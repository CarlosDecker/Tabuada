System.Console.WriteLine("---- Tabuada ----");
Console.ForegroundColor = ConsoleColor.Red;
System.Console.Write("Digite o número desejado para saber a tabuada do mesmo: ");


int numeroDigitado = Convert.ToInt32(Console.ReadLine());
int multiplo = 1;
int resultado;

Console.ForegroundColor = ConsoleColor.White;
while ( multiplo <= 10)
{
    resultado = numeroDigitado * multiplo;
    System.Console.WriteLine($"{numeroDigitado} X {multiplo} = {resultado}");
    multiplo++;
}
Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write("Pressione uma tecla para fechar...");
Console.ReadKey();
Console.ResetColor();