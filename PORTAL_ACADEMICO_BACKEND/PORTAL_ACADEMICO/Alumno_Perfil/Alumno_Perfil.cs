using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using PORTAL_ACADEMICO_DOMAIN.Categoria_Cursos;
using PORTAL_ACADEMICO_DOMAIN.Curso;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Alumno_Perfil;


public sealed class Alumno_Perfil: Entity {


    public Guid Id_Alumno { get; private set; }
    public int Creditos_Aprobados_Total { get; private set; }
    public int Creditos_Desaprobados_Total { get; private set; }
    public int Cursos_Aprobados_Total { get; private set; }
    public int Cursos_Desaprobados_Total { get; private set; }
    public string Ciclo_Actual { get; private set; }

    public double Promedio_General { get; private set; }
    public DateTime Ultima_Actualizacion { get; private set; }

    public bool IsActive { get; private set; }

    private Alumno_Perfil() { }

    public Alumno_Perfil(Guid Id,Guid id_Alumno, int creditos_Aprobados_Total, int creditos_Desaprobados_Total, int cursos_Aprobados_Total, int cursos_Desaprobados_Total, string ciclo_Actual, double promedio_General, DateTime ultima_Actualizacion, bool isActive): base(Id)
    {
        Id_Alumno = id_Alumno;
        Creditos_Aprobados_Total = creditos_Aprobados_Total;
        Creditos_Desaprobados_Total = creditos_Desaprobados_Total;
        Cursos_Aprobados_Total = cursos_Aprobados_Total;
        Cursos_Desaprobados_Total = cursos_Desaprobados_Total;
        Ciclo_Actual = ciclo_Actual;
        Promedio_General = promedio_General;
        Ultima_Actualizacion = ultima_Actualizacion;
        IsActive = isActive;
    }

    public static Alumno_Perfil Create(Guid id_Alumno, int creditos_Aprobados_Total, int creditos_Desaprobados_Total, int cursos_Aprobados_Total,
        int cursos_Desaprobados_Total, string ciclo_Actual, double promedio_General, DateTime ultima_Actualizacion)
    {
        var result = new Alumno_Perfil(Guid.NewGuid(),id_Alumno, creditos_Aprobados_Total,  creditos_Desaprobados_Total,  cursos_Aprobados_Total,  cursos_Desaprobados_Total,  ciclo_Actual,  promedio_General,  ultima_Actualizacion ,true);
        result.AddDomainEvent(new Alumno_PerfilCreatedEvent(result.Id));
        return result;
    }



    public void Update(Guid id_Alumno, int creditos_Aprobados_Total, int creditos_Desaprobados_Total, int cursos_Aprobados_Total, int cursos_Desaprobados_Total, string ciclo_Actual, double promedio_General, DateTime ultima_Actualizacion)
    {
        Id_Alumno= id_Alumno;
        Creditos_Aprobados_Total = creditos_Aprobados_Total;
        Creditos_Desaprobados_Total = creditos_Desaprobados_Total;
        Cursos_Aprobados_Total = cursos_Aprobados_Total;
        Cursos_Desaprobados_Total = cursos_Desaprobados_Total;
        Ciclo_Actual = ciclo_Actual;
        Promedio_General = promedio_General;
        Ultima_Actualizacion = ultima_Actualizacion;


        AddDomainEvent(new Alumno_PerfilUpdatedEvent(Id));
    }

    public void Delete()
    {
        IsActive = false;
        AddDomainEvent(new Alumno_PerfilDeletedEvent(Id));
    }   
        


}