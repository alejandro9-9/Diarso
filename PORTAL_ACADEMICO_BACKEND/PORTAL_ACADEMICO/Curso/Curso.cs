using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Curso;

public sealed class Curso: Entity {

public Guid Categoria_Curso { get; private set; }

public string Nombre_Curso { get; private set; }


public Guid Ciclo_Curso { get; private set; }

public int Creditos_Curso { get; private set; }

public bool IsActive { get; private set; }



    private Curso() { }

    public Curso(Guid categoria_Curso, String nombre_Curso, Guid ciclo_Curso, int creditos_Curso, bool isActive)
    {
        Categoria_Curso = categoria_Curso;
        Nombre_Curso = nombre_Curso;
        Ciclo_Curso = ciclo_Curso;
        Creditos_Curso = creditos_Curso;
        IsActive = isActive;
    }


    public static Curso Create(Guid categoria_Curso, string nombre_Curso, Guid ciclo_Curso, int creditos_Curso)
    {
        var result = new Curso(categoria_Curso, nombre_Curso, ciclo_Curso, creditos_Curso, true);
        result.AddDomainEvent(new CursoCreatedEvent(result.Categoria_Curso));
        return result;
    }

    public void Update(Guid categoria_Curso, string nombre_Curso, Guid ciclo_Curso, int creditos_Curso)
    {
        Categoria_Curso = categoria_Curso;
        Nombre_Curso = nombre_Curso;
        Ciclo_Curso = ciclo_Curso;
        Creditos_Curso = creditos_Curso;
        AddDomainEvent(new CursoUpdatedEvent(Categoria_Curso));
    }

    public void Delete()
    {
        IsActive = false;
        AddDomainEvent(new CursoDeletedEvent(Categoria_Curso));
    }   
}