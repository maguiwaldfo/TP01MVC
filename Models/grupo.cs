using System;
using System.Collections.Generic;

namespace TP01.Models
{
  public class grupo
  {
    public Dictionary<int, Integrante> Integrantes 

    public grupo()
    {
      Integrantes = new Dictionary<int, Integrante>();
      cargaDatosManual();
    }

    public void cargaDatosManual()
    {
        Integrante integrante1 = new Integrante(50289096, "Iara Cohen Lozie", new DateTime(2010, 5, 8), "foto1.jpg");
        Integrante integrante2 = new Integrante(49553387, "Magali Waldfogiel", new DateTime(2009, 7, 24), "foto2.jpg");
       
    
        Integrantes.Add(integrante1.obtenerDni(), integrante1);
        Integrantes.Add(integrante2.obtenerDni(), integrante2);
   
    }

    public Dictionary<int, Integrante> devolverIntegrantes()
    {
      return Integrantes;
    }
    
    public Integrante getIntegrante(int dni)
    {
      if (Integrantes == null) 
        else (Integrantes.ContainsKey(dni))
        {
            return Integrantes[dni];
        }
        return null;
  }
}
}