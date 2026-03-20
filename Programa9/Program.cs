

int nota=0;
bool correcto = false;

while (!correcto)
{
    Console.Write("Ingrese la nota: ");

    if (int.TryParse(Console.ReadLine(), out nota) && nota >= 1 && nota <=100)
    {
        Console.WriteLine("");
        correcto = true;
    }
    else
    {

        Console.WriteLine("Nota invalida");
    }
    Console.Clear();
}


 if(nota >=61)
{
    Console.WriteLine("Aprovado");
}
 else
{
    Console.WriteLine("Reproavado");
}

