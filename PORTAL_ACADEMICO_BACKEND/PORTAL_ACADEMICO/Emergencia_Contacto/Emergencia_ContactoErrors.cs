using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Emergencia_Contacto;
public static class Emergencia_ContactoErrors
{
    public static readonly Error Emergencia_Contactos_nodatos = new(
        "Emergencia_Contacto.SinDatos",
        "No se encuentra datos de contacto ya sea Nombres, Celular o Correo");

}