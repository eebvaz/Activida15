
Console.WriteLine("Ingrese su edad: ");
int edad =0;
bool correcto;


do
{
    if (int.TryParse(Console.ReadLine(), out edad))
    {
        Console.WriteLine("No es valido");
        Console.ReadKey();
    }

} while (!correcto);

Console.WriteLine("Es valido");

 Console.WriteLine("");
Console.WriteLine("Validad edad: ");

if (edad >= 1 && edad < 120)
{

    Console.WriteLine("Edad valida");

}
else
{
    Console.WriteLine("Edad no valida");
  
}

Console.ReadKey();