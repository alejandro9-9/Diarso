using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using PORTAL_ACADEMICO_DOMAIN.Shared.Value_Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Profesor;

public sealed class Profesor: Entity { 


    public Guid Id_Rol  { get; private set; }
    
    public Guid Id_Categoria_Cursos { get; private set; }

    public Nombres Nombres { get; private set; }

    public Celular Celular { get; private set; }  

    public Direccion Direccion { get; private set; }

    public bool Is_Active { get; private set; } 

    private Profesor() { }

    public Profesor(Guid Id,Guid id_Rol, Guid id_Categoria_Cursos, Nombres nombres, Celular celular, Direccion direccion, global::System.Boolean is_Active): base (Id)
    {
        Id_Rol = id_Rol;
        Id_Categoria_Cursos = id_Categoria_Cursos;
        Nombres = nombres;
        Celular = celular;
        Direccion = direccion;
        Is_Active = is_Active;
    }


    public static Profesor Create(Guid id_Rol, Guid id_Categoria_Cursos, Nombres nombres, Celular celular, Direccion direccion)
    {
        var result = new Profesor(Guid.NewGuid(), id_Rol, id_Categoria_Cursos, nombres, celular, direccion, true);
        result.AddDomainEvent(new ProfesorCreatedEvent(result.Id));
        return result;
    }

    public void Update(Guid id_Rol, Guid id_Categoria_Cursos, Nombres nombres, Celular celular, Direccion direccion)
    {
        Id_Rol = id_Rol;
        Id_Categoria_Cursos = id_Categoria_Cursos;
        Nombres = nombres;
        Celular = celular;
        Direccion = direccion;
        AddDomainEvent(new ProfesorUpdatedEvent(Id));
    }

    public void Delete()
    {
        Is_Active = false;
        AddDomainEvent(new ProfesorDeletedEvent(Id));
    }
}