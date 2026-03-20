
Console.WriteLine("Ingrese su edad: ");
int edad =0;
bool correcto=false;


do
{
    if (int.TryParse(Console.ReadLine(), out edad))
    {
     correcto = true;
    }
    else
    {
        Console.WriteLine("No es valido");
        Console.ReadKey();
    }

} while (!correcto);

Console.WriteLine("Es valido");

 Console.WriteLine("");


if (edad >= 1 && edad < 120)
{

    Console.WriteLine("Edad valida");

}
else
{
    Console.WriteLine("Edad no valida");
  
}

Console.ReadKey();