using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using PORTAL_ACADEMICO_DOMAIN.Matricula;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Ciclo;

public sealed class Ciclo: Entity {



    public string Nombre_Ciclo { get; private set; }


    public int Numero_Mensualidades { get; private set; }


    public int Duracion { get; private set; }


    public DateOnly Fecha_Inicio { get; private set; }


    public DateOnly Fecha_Final { get; private set; }


    public bool Is_Active    { get; private set; }


  
    private Ciclo() { }

    public Ciclo(Guid Id,string nombre_Ciclo, int numero_Mensualidades, int duracion, DateOnly fecha_Inicio, DateOnly fecha_Final, bool is_Active): base(Id)
    {
        Nombre_Ciclo = nombre_Ciclo;
        Numero_Mensualidades = numero_Mensualidades;
        Duracion = duracion;
        Fecha_Inicio = fecha_Inicio;
        Fecha_Final = fecha_Final;
        Is_Active = is_Active;
    }

    public static  Result<Ciclo>Create(string nombre_ciclo, int numero_mensualidades, int duracion, DateOnly fecha_inicio, DateOnly fecha_final) {

        if (fecha_inicio >= fecha_final)
            return Result.Failure<Ciclo>(CicloErrors.FechaInicioMayorQueFinal);

        if (fecha_final < fecha_inicio.AddMonths(1))
            return Result.Failure<Ciclo>(CicloErrors.DiferenciaMinima);


        if (fecha_final > fecha_inicio.AddMonths(6))
            return Result.Failure<Ciclo>(CicloErrors.DiferenciaMaxima);


        var result= new Ciclo(Guid.NewGuid(), nombre_ciclo, numero_mensualidades,duracion,fecha_inicio,fecha_final,true);

        result.AddDomainEvent(new CicloCreatedEvent(result.Id));

        return Result.Success(result);
    
    }

    public Result Update(string nombre_ciclo, int numero_mensualidades, int duracion, DateOnly fecha_inicio, DateOnly fecha_final) {

        if (fecha_inicio >= fecha_final)
            return Result.Failure<Ciclo>(CicloErrors.FechaInicioMayorQueFinal);

        if (fecha_final < fecha_inicio.AddMonths(1))
            return Result.Failure<Ciclo>(CicloErrors.DiferenciaMinima);


        if (fecha_final > fecha_inicio.AddMonths(6))
            return Result.Failure<Ciclo>(CicloErrors.DiferenciaMaxima);
        Nombre_Ciclo=nombre_ciclo;
        Numero_Mensualidades=numero_mensualidades;
        Duracion=duracion;
        Fecha_Inicio=fecha_inicio;
        Fecha_Final=fecha_final;
        return Result.Success();
    }

    public void Delete()
    {
        Is_Active = false;
        AddDomainEvent(new MatriculaDeletedEvent(Id));
    }
}