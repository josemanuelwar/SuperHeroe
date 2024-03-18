namespace SuperHeroe.superheroes
{
    public class SuperPoder
    {
        public string nombre { get; set; }
        public string Descripcion { get; set; }
        public NivelPoder Nivel { get; set; }

        public SuperPoder(){
            this.Nivel=NivelPoder.basico;
        }
    }

    public enum NivelPoder{
        basico,
        normal,
        avanzado
    }
}