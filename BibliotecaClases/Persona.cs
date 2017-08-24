using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public Persona()
        {
            Init();
        }

        public void Init()
        {
            this.nombre = string.Empty;
            this.apellido = string.Empty;
        }

        public String mostrarPersona()
        {
            string persona = ($"Nombre: {Nombre} - Apellido: {Apellido}");
            Console.WriteLine($"Nombre: {Nombre} - Apellido: {Apellido}");
            return persona;
        }

        
    }
}
