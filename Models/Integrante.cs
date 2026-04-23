using System;
using System.Collections.Generic;

namespace TP01.Models;

public class Integrante
{
    private int dni;
    private string nombre;
    private DateTime fechaNacimiento;
    private string foto;
    private List<string> familiares;
    private List<string> intereses;

    public Integrante(int dni, string nombre, DateTime fechaNacimiento, string foto, List<string> familiares = null, List<string> intereses = null)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.fechaNacimiento = fechaNacimiento;
        this.foto = foto;
        this.familiares = familiares;
        this.intereses = intereses;
    }

    public int obtenerDni()
    {
        return this.dni;
    }

    public string obtenerNombre()
    {
        return this.nombre;
    }

    public DateTime obtenerFechaNacimiento()
    {
        return this.fechaNacimiento;
    }

    public string obtenerFoto()
    {
        return this.foto;
    }

    public List<string> obtenerFamiliares()
    {
        return this.familiares;
    }

    public List<string> obtenerIntereses()
    {
        return this.intereses;
    }
}