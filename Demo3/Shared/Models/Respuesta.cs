using System.Collections.Generic;

namespace Demo3.Shared.Models
{
    public class Respuesta<T>
    {
        public int Exito { get; set; }
        public string Mensaje { get; set; }
        public T List { get; set; }

        public Respuesta()
        {
            Exito = 0;
        }
    }
}
