using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Aula;

public interface IAulaRepository {
    Task<Aula?> GetByIdAsync(Guid Id, CancellationToken cancellationToken = default);
    Task<List<Aula>> GetAllAsync(CancellationToken cancellationToken = default);
    Task Add(Aula aula);
    Task Update(Aula aula);
    Task Delete(Guid Id);
    
}