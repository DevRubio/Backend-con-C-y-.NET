
using System.Text;
using SuperHeroApp.Models;

Console.WriteLine("SuperHeroesApp!");

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super Fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

var regeneracion = new SuperPoder();
regeneracion.Nombre = "Regeneracion";
regeneracion.Nivel = NivelPoder.NivelTres;

var superman = new SuperHeroe();
var flash = new SuperHeroe();

superman.Id = 1;
superman.Nombre = "    Superman    ";
superman.IdentidadSecreta = "Clark kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

var DarkSuperman = new SuperHeroe();

DarkSuperman.Id = 2;
DarkSuperman.Nombre = "DarkSuperman";
DarkSuperman.IdentidadSecreta = "Clark kent";
DarkSuperman.Ciudad = "Metropolis";
DarkSuperman.PuedeVolar = true;

Console.WriteLine(superman == DarkSuperman);

SuperHeroeRecord superHeroeRecord = new(1, "SuperMan", "Clark Kent");
SuperHeroeRecord superHeroeRecord2 = new(1, "SuperMan", "Clark Kent");

Console.WriteLine(superHeroeRecord == superHeroeRecord2);

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman;
string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);



flash.Id = 2;
flash.Nombre = "flash";
flash.IdentidadSecreta = "Andres";
flash.Ciudad = "Starts";
flash.PuedeVolar = false;
//flash.SuperPoderes = new[] {"Super velocidad" };


var wolverine = new AntiHero();
wolverine.Id = 3;
wolverine.Nombre = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar = false;

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(superFuerza);
wolverine.SuperPoderes = poderesWolverine;
string resultPoderesWolverine = wolverine.UsarSuperPoderes();
Console.WriteLine(resultPoderesWolverine);

string accionAntiHero = wolverine.RealizarAccionDeAntiHero("Ataca la policia");
Console.WriteLine(accionAntiHero);


enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}

public record SuperHeroeRecord(int Id, string Nombre, string IdentidadSecreta);
