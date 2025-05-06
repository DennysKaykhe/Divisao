Console.Clear();

double nume, deno, divisor;

Console.Write("Digite o numerador....: ");
nume = Convert.ToDouble(Console.ReadLine())!;

Console.Write("Digite o denominador..: ");
deno = Convert.ToDouble(Console.ReadLine())!;

divisor = nume / deno;

if (deno <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Não é possível dividir por zero.");
            Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{nume} dividido por {deno} é {divisor}");
            Console.ResetColor();
}