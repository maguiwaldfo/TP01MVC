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
        Integrante integrante1 = new Integrante(12345678, "Juan Perez", new DateTime(1990, 5, 15), "foto1.jpg");
        Integrante integrante2 = new Integrante(87654321, "Maria Gomez", new DateTime(1985, 10, 20), "foto2.jpg");
        Integrante integrante3 = new Integrante(11223344, "Carlos Rodriguez", new DateTime(1995, 3, 30), "foto3.jpg");
    
        Integrantes.Add(integrante1.obtenerDni(), integrante1);
        Integrantes.Add(integrante2.obtenerDni(), integrante2);
        Integrantes.Add(integrante3.obtenerDni(), integrante3);
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