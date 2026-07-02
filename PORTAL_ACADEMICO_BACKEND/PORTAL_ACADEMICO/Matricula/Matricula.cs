using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Matricula;

public sealed class Matricula : Entity
{

    public Guid Id_Ciclo { get; private set; }

    public string Nombre_Matricula { get; private set; }

    public DateTime Periodo_Pago_Inicio { get; private set; }

    public DateTime Periodo_Pago_Final { get; private set; }
    public double Costo_Matricula { get; private set; }

    public bool Is_Active { get; private set; }


    private Matricula() { }

    public Matricula(Guid Id, Guid id_Ciclo, string nombre_Matricula, DateTime periodo_Pago_Inicio, DateTime periodo_Pago_Final, double costo_Matricula, bool is_Active): base(Id)
    {
        Id_Ciclo = id_Ciclo;
        Nombre_Matricula = nombre_Matricula;
        Periodo_Pago_Inicio = periodo_Pago_Inicio;
        Periodo_Pago_Final = periodo_Pago_Final;
        Costo_Matricula = costo_Matricula;
        Is_Active = is_Active;
    }

    public static Result<Matricula> Create(Guid id_ciclo, string nombre_matricula, DateTime periodo_pago_inicio, DateTime periodo_pago_final, double costo_matricula)
    {
        if(periodo_pago_inicio > periodo_pago_final)
        {
            return Result.Failure<Matricula>(MatriculaErrors.FechaInicioMayorQueFinal);
        }
        if (periodo_pago_final > periodo_pago_inicio.AddMonths(1)) {

            return  Result.Failure<Matricula>(MatriculaErrors.DiferenciaMaxima);
        }
        var result = new Matricula(Guid.NewGuid(), id_ciclo, nombre_matricula, periodo_pago_inicio, periodo_pago_final, costo_matricula, true);
        result.AddDomainEvent(new MatriculaCreatedEvent(result.Id));
        return Result.Success(result);
    }

    public Result Update(Guid id_ciclo, string nombre_matricula, DateTime periodo_pago_inicio, DateTime periodo_pago_final, double costo_matricula)
    {
        if(periodo_pago_inicio > periodo_pago_final)
        {
            return Result.Failure<Matricula>(MatriculaErrors.FechaInicioMayorQueFinal);
        }
        if (periodo_pago_final > periodo_pago_inicio.AddMonths(1)) {

            return  Result.Failure<Matricula>(MatriculaErrors.DiferenciaMaxima);
        }
        Id_Ciclo = id_ciclo;
        Nombre_Matricula = nombre_matricula;
        Periodo_Pago_Inicio = periodo_pago_inicio;
        Periodo_Pago_Final = periodo_pago_final;
        Costo_Matricula = costo_matricula;
        AddDomainEvent(new MatriculaUpdatedEvent(Id));
        return Result.Success();


    }

        public void Delete()
        {
            Is_Active = false;
            AddDomainEvent(new MatriculaDeletedEvent(Id));
    }
}