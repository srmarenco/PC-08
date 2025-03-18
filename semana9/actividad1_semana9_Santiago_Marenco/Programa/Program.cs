// Santiago Marenco | 1273525
// Programa: Program.cs
// Descripción: el programa obtiene un número integer del usuario y verifica si es primo o no, dividiendolo por todos los números entre él y el 1
// Lenguaje: C#
// fecha: 13/03/2025
class Actividad1_Semana9
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número natural menor a 6 cifras:");

        if (!int.TryParse(Console.ReadLine(), out int num) || num <= 0)
        {
            Console.WriteLine("Debe ingresar un número natural válido.");
        }

        else if (num > 999999)
        {
            Console.WriteLine("El valor es mayor a 6 cifras.");
        }

        else
        {
            for (int i = 2; i < num; i++)  // Optimización: Solo hasta raíz cuadrada
            {
                if (num % i == 0)
                {
                    Console.WriteLine("El número ingresado no es primo");
                    return;
                }
        }
            Console.WriteLine("El número ingresado es primo");
        }

    }
}
// miku