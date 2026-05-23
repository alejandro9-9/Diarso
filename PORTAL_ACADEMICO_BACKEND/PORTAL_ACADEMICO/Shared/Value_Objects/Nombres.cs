using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Shared.Value_Objects;
public sealed record Nombres
{
    private Nombres(string nombre, string apellido_Paterno, string apellido_Materno)
    {
        Nombre = nombre;
        Apellido_Paterno = apellido_Paterno;
        Apellido_Materno = apellido_Materno;
    }

    public string Nombre { get; }
    public string Apellido_Paterno { get; }
    public string Apellido_Materno { get; }


    public static Nombres Create(string nombre, string apellido_paterno, string apellido_materno)
    {


        if (string.IsNullOrWhiteSpace(nombre) || nombre.Any(char.IsDigit))
        {
            throw new ArgumentException("El nombre debe tener un formato válido");
        }
        if (string.IsNullOrWhiteSpace(apellido_paterno) || apellido_paterno.Any(char.IsDigit))
        {
            throw new ArgumentException("El apellido paterno debe tener un formato válido");
        }


        if (string.IsNullOrWhiteSpace(apellido_materno) || apellido_materno.Any(char.IsDigit))
        {
            throw new ArgumentException("El apellido materno debe tener un formato válido");
        }
        return new Nombres(nombre, apellido_paterno, apellido_materno);

    }


    public Nombres Edit(string nombre, string apellido_paterno, string apellido_materno) {

        if (string.IsNullOrWhiteSpace(nombre) || nombre.Any(char.IsDigit))
        {
            throw new ArgumentException("El nombre debe tener un formato válido");
        }
        if (string.IsNullOrWhiteSpace(apellido_paterno) || apellido_paterno.Any(char.IsDigit))
        {
            throw new ArgumentException("El apellido paterno debe tener un formato válido");
        }


        if (string.IsNullOrWhiteSpace(apellido_materno) || apellido_materno.Any(char.IsDigit))
        {
            throw new ArgumentException("El apellido materno debe tener un formato válido");
        }
        return  Create(nombre, apellido_paterno, apellido_materno);



    }

}

