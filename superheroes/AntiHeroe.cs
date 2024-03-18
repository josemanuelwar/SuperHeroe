namespace SuperHeroe.superheroes
{
    public class AntiHeroe : Superhero
    {
       public string RealizarAccionDeAntiheroe(string accion){
        return $"El Antieroe {NombreEIdentidadSecreta} ha raleizado {accion}";
       } 
    }
}