using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            Persona p2 = new Persona();

            p1.Nombre = "Alfonso";
            p1.Apellido = "Moya";

            p2.Nombre = "Jocelyn";
            p2.Apellido = "Muñoz";

            ResgistroPersona reg = new ResgistroPersona();

            reg.Add(p1);
            reg.Add(p2);

            foreach (Persona p in reg){
                p.mostrarPersona();
            }

            Console.ReadLine();
        }
    }
}
