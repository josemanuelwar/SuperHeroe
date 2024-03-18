using Interfaces;

namespace SuperHeroe.superheroes
{
    public class ImprimirInfo
    {
        public void ImprimirSuperHeroe(SuperHeroeInterface superHeroe){
            Console.WriteLine($"ID = {superHeroe.Id}");
            Console.WriteLine($"Nombre = {superHeroe.Nombre}");
            Console.WriteLine($"Identidad secreta = {superHeroe.IdentidadaSecreta}");
            Console.WriteLine("-------------------------------");
        }
    }
}