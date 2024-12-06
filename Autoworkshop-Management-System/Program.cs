using Microsoft.Data.SqlClient;

namespace Autoworkshop_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.GetVehicleData();

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.GetVehicleData();
        }

    }
}

/*I forhold til Christinas løsning, så vil jeg mene at både 
  vores og hendes løsning er gode på hver deres måde.

  Den ting som jeg mener der er bedre ved vores løsning, er,
  at vi har lavet child-klasser til de forskellige
  typer af køretøjer, så vi minimere mængden af null-værdier
  
  Jeg vil personligt også mene at vores projekt er lidt mere læseligt
  da hendes kode virker meget presset sammen, ift til vores 
  database management

  Hendes løsning er dog meget bedre på det punkt,
  at hun har lavet en C# klasse til kun at have database
  management i, hvilket er en meget god ting, for så
  er det ikke hver eneste objekt/klasse der har direkte adgang
  til databasen, men kun en enkelt klasse

  Noget som begge løsninger burde få fikset, er dog
  at ID'en til de forskellige klasser ikke er
  "private set" men bare "set", så de kan pilles ved
  ude fra, hvilket ikke er særlig godt, så der
  burde vi begge have tænkt på at sætte ID'erne 
  til private, så kun objekterne/klasserne selv
  kan ændre på den værdi

  Udover det, så vil jeg sige at vores løsning har mange ligheder
  med hendes også, hvilket er derfor at jeg ikke rigtig vil
  ændre på så meget.*/