using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroApp.Interfaces
{
    internal interface ISuperHero
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string IdentidadSecreta { get; set; }
    }
}
