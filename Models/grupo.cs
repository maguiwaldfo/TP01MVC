using System;
using System.Collections.Generic;

namespace TP01.Models
{
  public class Grupo
  {
    public Dictionary<int, Integrante> Integrantes { get; set; }

    public Grupo()
    {
      Integrantes = new Dictionary<int, Integrante>();
      cargaDatosManual();
    }

    public void cargaDatosManual()
    {
      
     List<string> famIara = new List<string> { "Mamá Carla" };
     List<string> integIara = new List<string> { "Jugar al hockey" };
     Integrante integrante1 = new Integrante(50289096, "Iara Cohen Lozie", new DateTime(2010, 5, 8), "Iara.png", famIara, integIara);

      List<string> famMagali = new List<string> { "Mamá Estefania" };
      List<string> integMagali = new List<string> { "Bailar" };
      Integrante integrante2 = new Integrante(49553387, "Magali Waldfogiel", new DateTime(2009, 7, 24), "Magui.png", famMagali, integMagali);

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