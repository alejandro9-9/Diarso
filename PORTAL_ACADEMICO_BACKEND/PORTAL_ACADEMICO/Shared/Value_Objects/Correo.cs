using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Shared.Value_Objects;
public sealed record Correo
{
    public string Direccion { get; }

    private Correo(string direccion)
    {
        Direccion = direccion;
    }

    public static Correo Create(string direccion)
    {
        if (string.IsNullOrWhiteSpace(direccion))
            throw new ArgumentException("El correo no puede estar vacío.");

        try
        {
            var addr = new System.Net.Mail.MailAddress(direccion);
            if (addr.Address != direccion)
                throw new ArgumentException("Correo inválido.");
        }
        catch (FormatException)
        {
            throw new ArgumentException("Correo inválido.");
        }

        return new Correo(direccion);
    }
}