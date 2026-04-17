namespace TP01.Models;

public class Integrante 
{
    private int dni;
    private string nombre;
    private DateTime fechaNacimiento;
    private string foto;
    private List<Familiar> familiares = new List<Familiar>() 
    {
     new Familiar(555, "Juan", "Padre"),
     new Familiar("Maria", "Madre"),
     new Familiar("Ana", "Hermana")
    }
    private List<Intereses> intereses = new List<Intereses>()
    {
        new Intereses("Futbol"),
        new Intereses("Musica"),
        new Intereses("Viajar")
    }

    public Integrante(int dni, string nombre, DateTime fechaNacimiento, string foto)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.fechaNacimiento = fechaNacimiento;
        this.foto = foto;
        this.familiares = new List<string>();
        this.intereses = new List<string>();
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

