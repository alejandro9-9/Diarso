using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Becas;

public sealed class Beca : Entity{

    private Beca() { }

    public Beca(Guid Id,string nombre_Beca, double descuento_Aplicable, bool isactive): base(Id)
    {
        Nombre_Beca = nombre_Beca;
        Descuento_Aplicable = descuento_Aplicable;
        IsActive= isactive;

    }

    public string Nombre_Beca { get; private set; }


    public double Descuento_Aplicable    { get; private set; }


    public bool IsActive { get; private set; }


    public static Beca Create(string nombre_beca, double descuento_aplicable) {
        
        var result= new Beca(Guid.NewGuid(), nombre_beca, descuento_aplicable,true);
        result.AddDomainEvent(new BecaCreatedEvent(result.Id));
        return result;
    
    }

    public void Update(string nombre_beca, double descuento_aplicable) { 

        Nombre_Beca= nombre_beca;
        Descuento_Aplicable= descuento_aplicable;
        AddDomainEvent(new BecaUpdatedEvent(Id));
    
    
    }

    public void Delete() { 
        IsActive= false;
        AddDomainEvent(new BecaDeletedEvent(Id));
   
    }



}