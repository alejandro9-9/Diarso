using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using PORTAL_ACADEMICO_DOMAIN.Shared.Value_Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Empleado;

public sealed class Empleado: Entity {
   

    public Empleado(Guid Id,Guid id_Rol, Nombres nombres, Celular celular, Direccion direccion, bool is_Active): base (Id)
    {
        Id_Rol = id_Rol;
        Nombres = nombres;
        Celular = celular;
        Direccion = direccion;
        Is_Active = is_Active;
    }

    private Empleado() { }


    public Guid Id_Rol { get; private set; }

    public Nombres Nombres { get; private set; }

    public Celular Celular { get; private set; }

    public Direccion Direccion { get; private set; }

    public bool Is_Active { get; private set; }

    public static Empleado Create(Guid id_Rol, Nombres nombres, Celular celular, Direccion direccion)
    {
        var result = new Empleado(Guid.NewGuid(), id_Rol, nombres, celular, direccion, true);
        result.AddDomainEvent(new EmpleadoCreatedEvent(result.Id));
        return result;
    }

    public void Update(Guid id_Rol, Nombres nombres, Celular celular, Direccion direccion)
    {
        Id_Rol = id_Rol;
        Nombres = nombres;
        Celular = celular;
        Direccion = direccion;
        AddDomainEvent(new EmpleadoUpdatedEvent(Id));
    }

    public void Delete()
    {
        Is_Active = false;
        AddDomainEvent(new EmpleadoDeletedEvent(Id));
    }





}