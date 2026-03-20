

int numero=0;
bool correcto = false;
double raiz;
while (!correcto)
{
    Console.Write("Ingrese Un Numero: ");

    if (int.TryParse(Console.ReadLine(), out numero) && numero >= 0)
    {
        Console.WriteLine("");
        correcto = true;
    }
    else
    {

        Console.WriteLine("Numero no es correcto");
    }
    Console.Clear();
}

Console.WriteLine("Validado correctamente" );

raiz = Math.Sqrt(numero);

Console.WriteLine($"Raiz del numero: {raiz:F4}");

Console.ReadKey();