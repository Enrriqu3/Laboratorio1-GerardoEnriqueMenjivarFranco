using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio1__GerardoEnriqueMenjivarFranco.Entidades;

namespace Laboratorio1__GerardoEnriqueMenjivarFranco.Negocio
{
    public class ClsPersona
    {
        public string calcularIMC(Persona persona)
        {
            double proo = persona.Peso / Math.Pow(persona.Altura, 2);
            if (proo <= 24)
            {
                return $"{persona.Nombre} usted tiene un peso ideal";
            }
            return $"{persona.Nombre} usted tiene sobre peso";
        }

        public string EsMayorDeEdad(Persona edad)
        {
            if (edad.Edad < 18)
            {
                return $"{edad.Nombre} usted es menor de edad";
            }
            return $"{edad.Nombre} usted es mayor de edad";
        }

    }
}