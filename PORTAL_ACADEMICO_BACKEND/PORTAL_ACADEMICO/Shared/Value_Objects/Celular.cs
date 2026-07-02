using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Shared.Value_Objects;

public sealed record Celular {

    public static readonly IReadOnlyList<string> CodigosDeArea = new[]
        {
        "+51",
    };



    public Celular(string cod_Area, string numero)
    {
        Cod_Area = cod_Area;
        Numero = numero;
    }

    public string Cod_Area { get;  }
    public string Numero { get; }


    public static Celular Create(string cod_area, string numero) {

        if (!CodigosDeArea.Contains(cod_area)) {
            throw new ArgumentException("Código de área inválido");
        }
        if (numero.Length != 9) {
            throw new ArgumentException("El número debe contener 9 dígitos");
        }


        return new Celular(cod_area, numero);
    
    
    }

    public Celular Edit(string cod_area, string numero) {
        if (!CodigosDeArea.Contains(cod_area))
        {
            throw new ArgumentException("Código de área inválido");
        }
        if (numero.Length != 9)
        {
            throw new ArgumentException("El número debe contener 9 dígitos");
        }


        return Create (cod_area, numero);


    }



}