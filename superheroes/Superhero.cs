using System.Text;
using Interfaces;

namespace SuperHeroe.superheroes
{
    public class Superhero : Heroe, SuperHeroeInterface 
    {
        private int _Id;
        private string _Nombre;
        public int Id { 
            get{
                return this._Id;
            }
            set{
                this._Id=value;
            }
        }
        public override string Nombre { 
            get{
                return this._Nombre;
            } 
            set{
                this._Nombre=value.Trim();
            } 
        }
        public Superhero(string identidadaSecreta, string ciudad) 
        {
            this.IdentidadaSecreta = identidadaSecreta;
                this.Ciudad = ciudad;
               
        }
        public string IdentidadaSecreta { get; set; } 
        public string Ciudad { get; set; }
        public List<SuperPoder> SuperPoderes { get; set;}
        public bool PuedeVolar  {get; set; }

        public string NombreEIdentidadSecreta{
            get{
                return $"{this._Nombre} ({this.IdentidadaSecreta})";
            }
        }
        public Superhero(){
            this.Id=1;
            this.SuperPoderes=new List<SuperPoder>();
            this.PuedeVolar=false;
        }

        public string usarSuperPoder(){
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.SuperPoderes)
            {
                sb.AppendLine($"{this.NombreEIdentidadSecreta} esta usando el super poder de { item.nombre }");
            }
            return sb.ToString();
        }

        public override string SalvarElMundo()
        {
            return $"{NombreEIdentidadSecreta} ha salvado el mundo";
        }

        public override string SalvarLaTierra()
        {
            return $"{this.NombreEIdentidadSecreta} ha salvado la tierra";
        }
    }
}