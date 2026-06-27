using System;
using System.Collections.Generic;
using System.Text;
using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using PORTAL_ACADEMICO_DOMAIN.Alumno;
using PORTAL_ACADEMICO_DOMAIN.Shared.Value_Objects;

namespace PORTAL_ACADEMICO_DOMAIN.Emergencia_Contacto;

public sealed class Emergencia_Contacto : Entity
{
    public Guid Id_Emergencia { get; private set; }
    public Guid Id_Usuario { get; private set; }
    public Nombres Nombres { get; private set; }
    public Celular Celular { get; private set; }
    public Correo Correo { get; private set; }
    public bool Is_Active { get; private set; }


    private Emergencia_Contacto() { }

    public Emergencia_Contacto(Guid Id,Guid id_Usuario, Nombres nombres,Celular celular, Correo correo, bool is_Active): base(Id)
    {
        Id_Usuario = id_Usuario;
        Nombres = nombres;
        Celular = celular;
        Correo = correo;
        Is_Active = is_Active;
    }

    public static Emergencia_Contacto Create(Guid id_usuario, Nombres nombres, Celular celular, Correo correo)
    {
        var result = new Emergencia_Contacto(Guid.NewGuid(),id_usuario, nombres, celular, correo, true);
        result.AddDomainEvent(new Emergencia_ContactoCreatedEvent(result.Id));
        return new Emergencia_Contacto();
    }

    public Result Update(Nombres nombres, Celular celular, Correo correo)
    {
        if (nombres is null || celular is null || correo is null)
        {
            return Result.Failure<Emergencia_Contacto>(Emergencia_ContactoErrors.Emergencia_Contactos_nodatos);
        }
        Nombres = nombres;
        Celular = celular;
        Correo = correo;
        AddDomainEvent(new Emergencia_ContactoUpdatedEvent(Id));
        return Result.Success();

    }

        public void Delete()
        {
            Is_Active = false;
            AddDomainEvent(new Emergencia_ContactoDeletedEvent(Id));
    }
}