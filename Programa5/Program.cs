


int numero=0;
bool correcto = false;  


while  (!correcto)
{
    Console.Write("Ingrese un numero: ");

   if (int.TryParse(Console.ReadLine(), out numero))
    {

        correcto = true;

    }
   else
    {
        Console.Write("No es numero entero");
    }

}

Console.WriteLine("Es numero entero");

if (numero % 2 == 0)
{
    Console.Write("Es par ");
}
else
{
    Console.Write("Es impar");
}

Console.ReadKey();