


int precio;
bool correcto = false;

while (!correcto)
{
    Console.Write("Ingrese el precio: ");
    
    if (int.TryParse(Console.ReadLine(), out precio) && precio > 0)
    {
        Console.WriteLine(""); 
        correcto = true;
    }
    else
    {

        Console.WriteLine("Precio no es correcto");
    }
    Console.Clear();
}

Console.WriteLine("Validado correctamente");

