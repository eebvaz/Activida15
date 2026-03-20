

int cantidad;
bool correcto=false;

while (!correcto)
{
   
    Console.Write("Ingrese la cantidad de estudiantes: ");

    if (int.TryParse(Console.ReadLine(), out cantidad) && cantidad >0)
      {

        correcto = true;
    }
    else
    {
        Console.WriteLine("Numero erroneo vuelve a ingresar");
        Console.ReadKey();
    }
    Console.Clear();
}

Console.WriteLine("Se ha validado correctamente");
