using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Ciclo;

public static class CicloErrors
{
    public static readonly Error FechaInicioMayorQueFinal = new(
        "Ciclo.FechaInvalida",
        "La fecha de inicio debe ser menor que la fecha final");

    public static readonly Error DiferenciaMinima = new(
        "Ciclo.DiferenciaMinima",
        "Debe haber al menos 1 mes de diferencia entre las fechas");

    public static readonly Error DiferenciaMaxima = new(
        "Ciclo.DiferenciaMaxima",
        "No puede haber más de 6 meses de diferencia entre las fechas");
}