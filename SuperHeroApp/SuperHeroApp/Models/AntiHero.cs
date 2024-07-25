using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroApp.Models
{
    internal class AntiHero : SuperHeroe
    {
        public string RealizarAccionDeAntiHero(string accion)
        {
            return $"El AntiHero {NombreEIdentidadSecreta} ha realizado: {accion} ";
        }
    }
}
