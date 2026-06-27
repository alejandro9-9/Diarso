using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using PORTAL_ACADEMICO_DOMAIN.Shared.Value_Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Alumno
;


public sealed class Alumno : Entity {
    public Alumno(Guid Id, Guid id_Rol, Nombres nombres, Celular celular, Correo correo, bool isActive) : base(Id)
    {
        Id_Rol = id_Rol;
        Nombres = nombres;
        Celular = celular;
        Correo = correo;
        IsActive = isActive;
    }

    private Alumno() { }

    public Guid Id_Rol { get; private set; }
    public Nombres Nombres { get; private set; }
    public Celular Celular { get; private set; }
    public Correo Correo { get; private set; }
    public bool IsActive { get; private set; }


    public static Alumno Create(Guid id_rol, Nombres nombres, Celular celular, Correo correo)
    {
        var result = new Alumno(Guid.NewGuid(), id_rol, nombres, celular, correo, true);
        result.AddDomainEvent(new AlumnoCreatedEvent(result.Id));
        return new Alumno();
    }

    public void Update(Guid id_rol, Nombres nombres, Celular celular, Correo correo) {
        Id_Rol = id_rol;
        Nombres = nombres;
        Celular = celular;
        Correo = correo;
        AddDomainEvent(new AlumnoUpdatedEvent(Id));
    
    }

    public void Delete() {
        IsActive= false;
        AddDomainEvent(new AlumnoDeletedEvent(Id));

    }
    
        
        
        
        

}