namespace Calificaciones
{
    public class Imprimir
    {
        public static void ImprimirCalificaciones(string[] numeroCalificacion, string[] calificacionesRespaldo)
        {
            //Imprimir resultados
            for (int i = 0; i < numeroCalificacion.Length; i++)
            {
                Console.WriteLine($"Las calificacion transformada de {calificacionesRespaldo[i]} en numero es: {numeroCalificacion[i]}");
            }
        }
    }
}
