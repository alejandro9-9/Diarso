using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Curso;

public sealed class Curso: Entity {

public Guid Categoria_Curso { get; private set; }

public string Nombre_Curso { get; private set; }


public int Ciclo_Curso { get; private set; }

public int Creditos_Curso { get; private set; }

public bool IsActive { get; private set; }



    private Curso() { }

    public Curso(Guid Id,Guid categoria_Curso, String nombre_Curso, int ciclo_Curso, int creditos_Curso, bool isActive) : base(Id)
    {
        Categoria_Curso = categoria_Curso;
        Nombre_Curso = nombre_Curso;
        Ciclo_Curso = ciclo_Curso;
        Creditos_Curso = creditos_Curso;
        IsActive = isActive;
    }


    public static Curso Create(Guid categoria_Curso, string nombre_Curso, int ciclo_Curso, int creditos_Curso)
    {
        var result = new Curso(Guid.NewGuid(),categoria_Curso, nombre_Curso, ciclo_Curso, creditos_Curso, true);
        result.AddDomainEvent(new CursoCreatedEvent(result.Id));
        return result;
    }

    public void Update(Guid categoria_Curso, string nombre_Curso, int ciclo_Curso, int creditos_Curso)
    {
        Categoria_Curso = categoria_Curso;
        Nombre_Curso = nombre_Curso;
        Ciclo_Curso = ciclo_Curso;
        Creditos_Curso = creditos_Curso;
        AddDomainEvent(new CursoUpdatedEvent(Id));
    }

    public void Delete()
    {
        IsActive = false;
        AddDomainEvent(new CursoDeletedEvent(Id));
    }   
}