using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Matricula;

public interface IMatriculaRepository { 

    Task<Matricula> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<List<Matricula>> GetAllAsync(CancellationToken cancellationToken = default);
    void Add(Matricula matricula);
    void Update(Matricula matricula);
    void Delete(Guid id);

}