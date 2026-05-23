using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Ciclo;


public interface ICicloRepository {


    Task<Ciclo?> GetByIdAsyncCiclo(Guid Id, CancellationToken cancellationToken = default);

    Task<List<Ciclo>> GetAllAsyncCiclo( CancellationToken cancellationToken = default);


    void Add(Ciclo ciclo);

    void Update(Ciclo ciclo);

    void Delete(Guid Id);

}