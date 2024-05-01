using EjercicioClase;
using static System.Runtime.InteropServices.JavaScript.JSType;


SuperHeroe superHeroe1 = new SuperHeroe();
SuperHeroe superHeroe2 = new SuperHeroe();
SuperHeroe superHeroe3 = new SuperHeroe();

//Super hereo1
superHeroe1.Nombre = "Batman";
superHeroe1.IdentidadSecreta = "Bruce Wayne";
superHeroe1.Ciudad = "Gotica";
superHeroe1.PuedeVolar = false;
superHeroe1.superPoder.Nombre = "Millonario";
superHeroe1.superPoder.Descripcion = "Intelecto, Artes marciales, aplicaciones cientficas y tecnologicas para crear armas y herramientas.";
superHeroe1.superPoder.Nivel = 10;

//Super hereo2
superHeroe2.Nombre = "Super Man";
superHeroe2.IdentidadSecreta = "Clark Kent";
superHeroe2.Ciudad = "Metropolis";
superHeroe2.PuedeVolar = true;
superHeroe2.superPoder.Nombre = "Alienigena";
superHeroe2.superPoder.Descripcion = "Puede volar, vision laser y super fuerza.";
superHeroe2.superPoder.Nivel = 9;

//Super hereo3
superHeroe3.Nombre = "Mujer Maravilla";
superHeroe3.IdentidadSecreta = "Diana Prince";
superHeroe3.Ciudad = "Isla de las amazonas";
superHeroe3.PuedeVolar = true;
superHeroe3.superPoder.Nombre = "Amazona";
superHeroe3.superPoder.Descripcion = "Combate cuerpo a cuerpo, longevidad y puede volar.";
superHeroe3.superPoder.Nivel = 9;

superHeroe1.imprimir();
superHeroe2.imprimir();
superHeroe3.imprimir();