using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Shared.Value_Objects;

public sealed record Direccion
{




    public static readonly IReadOnlyList<string> PaisesPermitidos = new[]
    {
        "Perú",
    };

    public static readonly IReadOnlyDictionary<string, IReadOnlyList<string>> DepartamentosPorPais =
        new Dictionary<string, IReadOnlyList<string>>
        {
            ["Perú"] = new[] { "Lima", "Trujillo", "Cajamarca" },

        };

    public static readonly IReadOnlyDictionary<string, IReadOnlyList<string>> DistritosPorDepartamento =
        new Dictionary<string, IReadOnlyList<string>>
        {

            ["Lima"] = new[]
        {
            "Ancón", "Ate", "Barranco", "Breña", "Carabayllo", "Chaclacayo",
            "Chorrillos", "Cieneguilla", "Comas", "El Agustino", "Independencia",
            "Jesús María", "La Molina", "La Victoria", "Lince", "Los Olivos",
            "Lurigancho", "Lurín", "Magdalena del Mar", "Miraflores", "Pachacámac",
            "Pucusana", "Pueblo Libre", "Puente Piedra", "Punta Hermosa",
            "Punta Negra", "Rímac", "San Bartolo", "San Borja", "San Isidro",
            "San Juan de Lurigancho", "San Juan de Miraflores", "San Luis",
            "San Martín de Porres", "San Miguel", "Santa Anita", "Santa María del Mar",
            "Santa Rosa", "Santiago de Surco", "Surquillo", "Villa El Salvador",
            "Villa María del Triunfo"
        },
            ["Trujillo"] = new[]
        {
            "Trujillo", "El Porvenir", "Florencia de Mora", "Huanchaco",
            "La Esperanza", "Laredo", "Moche", "Poroto", "Salaverry",
            "Simbal", "Victor Larco Herrera"
        },
            ["Cajamarca"] = new[]
        {
            "Cajamarca", "Asunción", "Chetilla", "Cospan", "Encañada",
            "Jesús", "Llacanora", "Los Baños del Inca", "Magdalena",
            "Namora", "San Juan"
        },
        };


    private Direccion(string pais, string departamento, string distrito, string calle, int numero, string referencias)
    {
        Pais = pais;
        Departamento = departamento;
        Distrito = distrito;
        Calle = calle;
        Numero = numero;
        Referencias = referencias;
    }

    public string Pais { get; }

    public string Departamento { get; }

    public string Distrito { get; }

    public string Calle { get; }

    public int Numero { get; }

    public string Referencias { get; }



    public static Direccion Create(string Pais, string Departamento, string Distrito, string Calle,
        int Numero, string Referencias)
    {
        if (!PaisesPermitidos.Contains(Pais))
        {
            throw new ArgumentException("Debe colocar un país válido");
        }

        if (!DepartamentosPorPais.ContainsKey(Pais) || !DepartamentosPorPais[Pais].Contains(Departamento))
            throw new ArgumentException("Debe colocar un departamento válido");


        if (!DistritosPorDepartamento.ContainsKey(Departamento) || !DistritosPorDepartamento[Departamento].Contains(Distrito))
            throw new ArgumentException("Debe colocar un distrito válido");

      

        if (string.IsNullOrWhiteSpace(Calle))
        {
            throw new ArgumentException("Debe colocar el nombre de la Calle");
        }

        if (Numero <= 0)
        {
            throw new ArgumentException("Debe colocar un número mayor a 0");
        }

        if (string.IsNullOrWhiteSpace(Referencias))
        {
            throw new ArgumentException("Es necesario colocar las referencias de su dirección");
        }

        return new Direccion(Pais, Departamento, Distrito, Calle, Numero, Referencias);



    }

    public Direccion Edit(string pais, string departamento, string distrito,
      string calle, int numero, string referencias)
    {

        return Create(pais, departamento, distrito, calle, numero, referencias);
    }






}