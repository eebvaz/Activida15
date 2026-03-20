

DateTime fecha;

bool correcto = false;

while (!correcto)
{
    Console.Write("Ingrese una fecha con el formato (dia/mes/año): ");

    if (DateTime.TryParse(Console.ReadLine(), out fecha))
    {
        correcto = true;
    }
    else
    {

        Console.WriteLine("Fecha incorrecto");
    }
    Console.Clear();
}

Console.WriteLine($"Fecha validada correctamente");