using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Categoria_Cursos;

public sealed class Categoria_Cursos: Entity { 


    public string Nombre_Categoria_Curso { get; private set; }

    public bool IsActive { get; private set; }


    private Categoria_Cursos() { }

    public Categoria_Cursos(Guid Id,String nombre_Categoria_Curso, bool isActive) : base(Id)
    {
        Nombre_Categoria_Curso = nombre_Categoria_Curso;
        IsActive = isActive;
    }

    public static Categoria_Cursos Create(string nombre_Categoria_Curso)
    {
        var result = new Categoria_Cursos(Guid.NewGuid(), nombre_Categoria_Curso, true);
        result.AddDomainEvent(new Categoria_CursosCreatedEvent(result.Id));
        return result;
    }
    public void Update(string nombre_Categoria_Curso)
    {
        Nombre_Categoria_Curso = nombre_Categoria_Curso;
        AddDomainEvent(new Categoria_CursosUpdatedEvent(Id));
    }
    public void Delete()
    {
        IsActive = false;
        AddDomainEvent(new Categoria_CursosDeletedEvent(Id));
    }
}
