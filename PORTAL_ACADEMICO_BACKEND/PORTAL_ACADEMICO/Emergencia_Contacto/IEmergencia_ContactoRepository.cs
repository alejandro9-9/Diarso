using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Emergencia_Contacto;

public interface IEmergencia_ContactoRepository
{ 

    Task<Emergencia_Contacto> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<List<Emergencia_Contacto>> GetAllAsync(CancellationToken cancellationToken = default);
    void Add(Emergencia_Contacto emergencia_contacto);
    void Update(Guid id);
    void Delete(Emergencia_Contacto emergencia_contacto);

}