namespace Calificaciones
{
    public class TransformarCalificaciones
    {
        public static void ActualizarCalificaciones(string[] calificaciones, string[] calificacionesRespaldo)
        {
            //Cadena de calificaciones
            string[] numeroCalificaciones = { "4", "5", "6", "7", "8", "9" };

            try
            {
                for (int i = 0; i < calificaciones.Length; i++)
                {
                    calificaciones[i] = numeroCalificaciones[i];
                }
                //Manda a llamar metodo de imprimir calificaciones
                Imprimir.ImprimirCalificaciones(calificaciones, calificacionesRespaldo);
            }catch (Exception ex)
            {
                Console.WriteLine($"El siguiente error es: {ex.ToString()}");
            }

        }
    }
}
