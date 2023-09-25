namespace preacica_clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new("gustavo", "somoza", "E00001");
            Estudiante estudiante2 = new("ivana", "somza", "E00002");
            Estudiante estudiante3 = new("ariel", "somoza", "E00003");

            estudiante1.SetNotaPrimerParcial(5);
            estudiante1.SetNotaSegundoParcial(7);
            
            estudiante2.SetNotaPrimerParcial(4);
            estudiante2.SetNotaSegundoParcial(4);
            
            estudiante3.SetNotaPrimerParcial(8);
            estudiante3.SetNotaSegundoParcial(1);

            estudiante1.Mostrar();
            estudiante2.Mostrar();
            estudiante3.Mostrar();




        }
        /*  Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
            Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
            Mostrar los datos de todos los alumnos.

            */
    }
}