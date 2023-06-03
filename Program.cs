Console.WriteLine("  Tabuada ");

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("Digite um número: ");

Console.ForegroundColor = ConsoleColor.DarkBlue; 
int numeroDigitado = Convert.ToInt32(Console.ReadLine());
int multiplo = 1;
int resultado;


while ( multiplo <= 10)
{
    resultado = numeroDigitado * multiplo;
    Console.WriteLine($"{numeroDigitado} X {multiplo} = {resultado}");
    multiplo++;
}