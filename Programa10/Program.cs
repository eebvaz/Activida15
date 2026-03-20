
int cantidad, producto;
bool correcto = false;
string productos = "";

while (!correcto)
{
    Console.Write("Ingrese una cantidad de productos: ");

    if (int.TryParse(Console.ReadLine(), out cantidad) && cantidad > 0)
    {
        Console.WriteLine("");
        correcto = true;
    }
    else
    {

        Console.WriteLine("Cantidad incorrecta");
        Console.ReadKey();
    }
    Console.Clear();
}

Console.WriteLine("Ingrese el producto");
productos = Console.ReadLine();

