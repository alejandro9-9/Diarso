using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Aula;

public sealed class Aula: Entity
{
    public string Nombre_Aula { get; private set; }
    public int Numero_Piso  { get; private set; }

    public int Capacidad { get; private set; }

    public bool Is_Active { get; private set; }
    private Aula() { }

    public Aula(Guid Id, global::System.String nombre_Aula, global::System.Int32 numero_Piso, global::System.Int32 capacidad, global::System.Boolean is_Active): base(Id)
    {
        Nombre_Aula = nombre_Aula;
        Numero_Piso = numero_Piso;
        Capacidad = capacidad;
        Is_Active = is_Active;
    }

    public static Aula Create(string nombre_Aula, int numero_Piso, int capacidad)
    {
        var result = new Aula(Guid.NewGuid(), nombre_Aula, numero_Piso, capacidad, true);
        result.AddDomainEvent(new AulaCreatedEvent(result.Id));
        return result;
    }

    public void Update(string nombre_Aula, int numero_Piso, int capacidad)
    {
        Nombre_Aula = nombre_Aula;
        Numero_Piso = numero_Piso;
        Capacidad = capacidad;
        AddDomainEvent(new AulaUpdatedEvent(Id));
    }
    public void Delete()
    {
        Is_Active = false;
        AddDomainEvent(new AulaDeletedEvent(Id));
    }

}