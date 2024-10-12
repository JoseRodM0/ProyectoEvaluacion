namespace ProyectoEvaluacionn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calificacion Final");
            decimal Calificacion = decimal.Parse(Console.ReadLine());

            // Evaluar la calificación
            if (Calificacion >= 70)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"La calificacion es de {Calificacion}, aprobado");
            }

            else if (Calificacion <= 50)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"La calificación es de {Calificacion}, reprobado debe volver a cursar");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"La calificación es de {Calificacion}, reprobado con derecho a regularizar");
            }
        }


        /*else
        {
            Console.WriteLine("Por favor, ingrese una calificación válida.");
        }
        */
    }
}
