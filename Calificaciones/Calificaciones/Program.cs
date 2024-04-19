namespace Calificaciones
{
     class Program
    {
       public static string[] calificacionesRespaldo = { "A", "B", "C", "D", "E", "F" };
        static void Main(string[] args)
        {
            string[] calificaciones = { "A", "B", "C", "D", "E", "F" };

            TransformarCalificaciones.ActualizarCalificaciones(calificaciones, calificacionesRespaldo);

            Console.ReadLine();
            
        }

     }
}
