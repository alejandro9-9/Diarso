using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using PORTAL_ACADEMICO_DOMAIN.Alumno;
using PORTAL_ACADEMICO_DOMAIN.Shared.Value_Objects;
using PORTAL_ACADEMICO_DOMAIN.Ticket;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Emergencia_Contacto;

public sealed class Emergencia_Contacto : Entity
{
    public Guid Id_Alumno { get; private set; }
    public Guid Id_Profesor{ get; private set; }
    public Guid Id_Empleado { get; private set; }
    public Nombres Nombres { get; private set; }
    public Celular Celular { get; private set; }
    public Correo Correo { get; private set; }
    public Direccion Direccion { get; private set; }
    public bool Is_Active { get; private set; }


    private Emergencia_Contacto() { }

    public Emergencia_Contacto(Guid Id,Guid id_Alumno, Guid id_Profesor, Guid id_Empleado, Nombres nombres, Celular celular, Correo correo, Direccion direccion, bool is_Active): base(Id)
    {
        Id_Alumno = id_Alumno;
        Id_Profesor = id_Profesor;
        Id_Empleado = id_Empleado;
        Nombres = nombres;
        Celular = celular;
        Correo = correo;
        Direccion = direccion;
        Is_Active = is_Active;
    }

    public static Emergencia_Contacto Create(Guid id_Alumno, Guid id_Profesor, Guid id_Empleado, Nombres nombres, Celular celular, Correo correo, Direccion direccion)
    {
        var result = new Emergencia_Contacto(Guid.NewGuid(), id_Alumno,  id_Profesor,  id_Empleado,  nombres,  celular,  correo,  direccion ,true);
        result.AddDomainEvent(new Emergencia_ContactoCreatedEvent(result.Id));
        return result;
    }

    public void Update(Guid id_Alumno, Guid id_Profesor, Guid id_Empleado, Nombres nombres, Celular celular, Correo correo, Direccion direccion)
    {
        Id_Alumno = id_Alumno;
        Id_Profesor = id_Profesor;
        Id_Empleado = id_Empleado;
        Nombres = nombres;
        Celular = celular;
        Correo = correo;
        Direccion = direccion;

        AddDomainEvent(new Emergencia_ContactoUpdatedEvent(Id));

    }

        public void Delete()
        {
            Is_Active = false;
            AddDomainEvent(new Emergencia_ContactoDeletedEvent(Id));
    }
}