
Console.WriteLine("");

int fecha;

bool correcto= false;


while (!correcto)
{
    Console.WriteLine("Ingrese su fecha de nacimiento; ");

    if (int.TryParse(Console.ReadLine(), out fecha) && fecha<=2026 && fecha >1900)
    {
        Console.WriteLine("");
        correcto=true;
    }
    else
    {
        Console.WriteLine("Fecha invalida");
    }

}

Console.WriteLine("Fecha valida");