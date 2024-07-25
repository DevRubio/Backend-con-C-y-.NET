using SuperHeroApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroApp
{
    internal class ImprimirInfo
    {
        public void ImprimirSuperHero(ISuperHero superHeroe)
        {
            Console.WriteLine($"Id: {superHeroe.Id}");
            Console.WriteLine($"Nombre: {superHeroe.Nombre}");
            Console.WriteLine($"IdentidadSecreta: {superHeroe.IdentidadSecreta}");
        }
        
    }
}
