using System;
using System.Collections;
using System.Linq;
using System.Net;
using System.Security.Cryptography;

namespace LinqToObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList provinciasArgentina = new ArrayList()
        {
            "Buenos Aires",
            "Catamarca",
            "Chaco",
            "Chubut",
            "Córdoba",
            "Corrientes",
            "Entre Ríos",
            "Formosa",
            "Jujuy",
            "La Pampa",
            "La Rioja",
            "Mendoza",
            "Misiones",
            "Neuquén",
            "Río Negro",
            "Salta",
            "San Juan",
            "San Luis",
            "Santa Cruz",
            "Santa Fe",
            "Santiago del Estero",
            "Tierra del Fuego",
            "Tucumán"
        };

            var misProvincias = provinciasArgentina.Cast<string>().Where(p => p.StartsWith("S") || p.StartsWith("T"));

            foreach (var p in misProvincias)
            {
                Console.WriteLine(p);
            }

        }
    }
}
