using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Curso;

public interface ICursoRepository {
    Task<Curso?> GetByIdAsync(Guid Id, CancellationToken cancellationToken = default);
    Task<List<Curso>> GetAllAsync(CancellationToken cancellationToken = default);
    Task Add(Curso curso);
    Task Update(Curso curso);
    Task Delete(Guid Id);
    
}