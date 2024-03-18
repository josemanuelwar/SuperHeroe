
using SuperHeroe.superheroes;

var volar = new SuperPoder();
volar.nombre="volar";
volar.Descripcion="El poder de volar por el mundo";
volar.Nivel= NivelPoder.avanzado;

var fuerza=new SuperPoder();
fuerza.nombre="super Fuerza";
fuerza.Descripcion="Es tener furza sobre humana";
fuerza.Nivel=NivelPoder.avanzado;

var velocidad = new SuperPoder();
velocidad.nombre="Velocidad";
velocidad.Descripcion="tener la capasidad de moverse mas rapido de lo que se puede mover la humanidad";
velocidad.Nivel= NivelPoder.avanzado;

var superman = new Superhero();

superman.Nombre ="Superman";
superman.Id=1;
superman.IdentidadaSecreta="Clark kent";
superman.Ciudad="Metropolis";
superman.PuedeVolar=true;
superman.SuperPoderes.Add(volar);
superman.SuperPoderes.Add(fuerza);

var Flash=new Superhero();

Flash.Id=1;
Flash.Nombre="Flash";
Flash.IdentidadaSecreta="Barry Alen";
Flash.Ciudad="central city";
Flash.PuedeVolar=false;
Flash.SuperPoderes.Add(velocidad);

var regenaracion = new SuperPoder();
regenaracion.nombre="regeneracoion de su cuerpo";

var wolverine = new AntiHeroe();

wolverine.Id=5;
wolverine.Nombre="wolverine";
wolverine.IdentidadaSecreta="Logan";
wolverine.PuedeVolar=false;
wolverine.SuperPoderes.Add(fuerza);
wolverine.SuperPoderes.Add(regenaracion);



Console.WriteLine(superman.usarSuperPoder());
Console.WriteLine(superman.SalvarElMundo());
Console.WriteLine(superman.SalvarLaTierra());
 
Console.WriteLine(Flash.usarSuperPoder());

Console.WriteLine(wolverine.usarSuperPoder());
Console.WriteLine(wolverine.RealizarAccionDeAntiheroe("Atacar la police"));

var imprimir = new ImprimirInfo();
imprimir.ImprimirSuperHeroe(Flash);
imprimir.ImprimirSuperHeroe(superman);
imprimir.ImprimirSuperHeroe(wolverine);