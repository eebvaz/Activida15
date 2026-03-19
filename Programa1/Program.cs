
Console.WriteLine("Ingrese su edad: ");
int edad;


if (int.TryParse(Console.ReadLine(), out edad))
{
    Console.WriteLine("No es valido");
}


Console.ReadKey();
Console.WriteLine("Validad edad: ");

if (edad >= 1 && edad < 120)
{
    Console.WriteLine("Edad valida");
}
else
{
    Console.WriteLine("Edad no valida");
}

