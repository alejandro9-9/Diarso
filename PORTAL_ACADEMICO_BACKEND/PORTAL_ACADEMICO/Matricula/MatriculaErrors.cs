using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Matricula;
public static class MatriculaErrors
{
    public static readonly Error FechaInicioMayorQueFinal = new(
        "Matricula.FechaInvalida",
        "El inicio del periodo de pago debe ser menor que el periodo final de pago");

  

    public static readonly Error DiferenciaMaxima = new(
        "Matricula.DiferenciaMaxima",
        "No puede haber más de 1 mes de diferencia entre las fechas");
}