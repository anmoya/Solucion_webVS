using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Persona
    {
        public string nombre;
        public string apellido;

        public Persona()
        {
            Init();
        }

        public void Init()
        {
            this.nombre = string.Empty;
            this.apellido = string.Empty;
        }



        
    }
}
