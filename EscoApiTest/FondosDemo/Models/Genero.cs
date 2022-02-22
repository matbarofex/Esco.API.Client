using EscoApiTest.FondosDemo.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.FondosDemo.Models
{
    public class Genero
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        public static List<Genero> GetGeneros() 
        {
            return new List<Genero>()
            {
                new Genero { Codigo = (int)Generos.Femenino, Descripcion = Generos.Femenino.ToString() },
                new Genero { Codigo = (int)Generos.Masculino, Descripcion = Generos.Masculino.ToString() }
            };
        }
    }
}
