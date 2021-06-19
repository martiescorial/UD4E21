using System;

namespace UD4E21
{
    class Program
    {
        static void Main(string[] args)
        {
            String dia = "Introduce un dia de la semana";

            switch (dia)
            {
                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("Es un dia laboral");
                    break;
                case "sabado":
                case "domingo":
                    Console.WriteLine("Es un dia festivo");
                    goto default;
                default:
                    Console.WriteLine("Introduce un dia de la semana");
                    break;
            }
        }
    }
}
