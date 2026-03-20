

double salario=0;

bool correcto = false;

while (!correcto)
{
    Console.Write("Ingrese Su Salario: ");

    if (double.TryParse(Console.ReadLine(), out salario) && salario >=0)
    {
        Console.WriteLine("");
        correcto = true;
    }
    else
    {
        Console.WriteLine("Numero invalido");
    }
    Console.Clear();
}

Console.WriteLine("Salario Correcto: Q"+salario);