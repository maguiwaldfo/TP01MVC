using System;
using System.Collections.Generic;

namespace TP01.Models
{
  public class grupo
  {
    public Dictionary<int, Integrante> Integrantes { get; set; }

    public grupo()
    {
      Integrantes = new Dictionary<int, Integrante>();
      cargaDatosManual();
    }

    public void cargaDatosManual()
    {
      
     List<string> famIara = new List<string> { "Mamá Carla" };
     List<string> intIara = new List<string> { "Jugar al hockey" };
     Integrante integrante1 = new Integrante(50289096, "Iara Cohen Lozie", new DateTime(2010, 5, 8), "iara.png", famIara, intIara);

      List<string> famMagali = new List<string> { "Mamá Estefania" };
      List<string> intMagali = new List<string> { "Bailar" };
      Integrante integrante2 = new Integrante(49553387, "Magali Waldfogiel", new DateTime(2009, 7, 24), "magui.png", famMagali, intMagali);

      Integrantes.Add(integrante1.obtenerDni(), integrante1);
      Integrantes.Add(integrante2.obtenerDni(), integrante2);
   
    }

    public Dictionary<int, Integrante> devolverIntegrantes()
    {
      return Integrantes;
    }
    
    public Integrante getIntegrante(int dni)
    {
      if (Integrantes != null && Integrantes.ContainsKey(dni))
      {
        return Integrantes[dni];
      }
      return null;
  }
}
}