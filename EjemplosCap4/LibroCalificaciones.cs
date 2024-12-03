using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosCap4
{
    internal class LibroCalificaciones
    {
        private string _nombreCurso;
        public LibroCalificaciones(string nombre)
        {
            NombreCurso = nombre; // inicializa nombreCurso usando la propiedad
        }

        // propiedad para obtener (get) y establecer (set) el nombre del curso
        public string NombreCurso
        {
            get
            {
                return _nombreCurso;
            }
            set
            {
                _nombreCurso = value;
            }
        }


        public void MostrarMensaje()
        {
            Console.WriteLine("¡Bienvenido al libro de calificaciones para\n{0}!", NombreCurso);

        }
    }
}
