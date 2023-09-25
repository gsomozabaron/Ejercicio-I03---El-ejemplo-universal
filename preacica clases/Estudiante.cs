using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace preacica_clases
{
    internal class Estudiante
    {
        private string _nombre;
        private string _apellido;
        private string _legajo;
        private float _notaPrimerParcial;
        private float _notaSegundoParcial;
            
    
        public Estudiante(string nombre, string apellido, string legajo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._legajo = legajo;
        }
        public static Random random = new Random();

        public void SetNotaPrimerParcial(int nota)
        {
            this._notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this._notaSegundoParcial = nota;
        }
        private float CalcularPromedio()
        {
            return (_notaPrimerParcial + _notaSegundoParcial) / 2;
        }
        public float CalcularNotaFinal() 
        {
            if (_notaPrimerParcial > 3 && _notaSegundoParcial > 3)
            {
                return random.Next(6, 11);
            }
            else
            {
                return -1;
            }
        }
        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine ($"nombre: {_nombre}, apellido: {_apellido}, legajo # {_legajo}");
            sb.AppendLine($"nota primer parcial {_notaPrimerParcial}, nota segundo parcial {_notaSegundoParcial}");
            sb.AppendLine($"promedio: {CalcularPromedio()}");
            if (CalcularNotaFinal() != -1)
            {
                sb.AppendLine($"nota final: {CalcularNotaFinal()}");
            }
            else 
            {
                sb.AppendLine($"alumno desaprovado");
            }
            Console.WriteLine(sb.ToString());
        }
        /*    Tendrá un constructor estático que inicializará el atributo estático random.
            Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
            El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
            El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
            El método privado CalcularPromedio retornará el promedio de las dos notas.
            El método CalcularNotaFinal deberá retornar la nota del final con un número aleatorio entre 6 y 10 incluidos 
            siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, 
            caso contrario la inicializará con el valor -1.

            El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
            Nombre, apellido y legajo.
            Nota del primer y segundo parcial.
            Promedio.
            Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".

            Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
            Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
            Mostrar los datos de todos los alumnos.

            */
















    }

}
