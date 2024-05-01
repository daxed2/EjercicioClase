using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    public class SuperHeroe
    {
        public SuperHeroe()
        {
            superPoder = new SuperPoder();
        }
        /// <summary>
        /// Nombre del super hereo
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Identidad secreta del super hereo
        /// </summary>
        public string IdentidadSecreta { get; set; }

        /// <summary>
        /// Ciudad natal del super hereo
        /// </summary>
        public string Ciudad {  get; set; }

        /// <summary>
        /// Indica si puede volar el super hereo
        /// </summary>
        public bool PuedeVolar {  get; set; }

        /// <summary>
        /// Datos del super poder del super hereo
        /// </summary>
        public SuperPoder superPoder { get; set; }

        public void imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Puede Volar: {(PuedeVolar ? "Sí":"No")}");
            Console.WriteLine($"Super Poder: {superPoder.Nombre}");
            Console.WriteLine($"Descripcion: {superPoder.Descripcion}");
            Console.WriteLine($"Nivel: {superPoder.Nivel}");
            Console.WriteLine("\n");
        }
    }
}
