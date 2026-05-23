using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Becas;

public interface IBecaRepository { 

    Task<Beca?>GetByIdAsync(Guid id, CancellationToken cancellationToken= default);

    Task<List<Beca>>GetAllAsync(CancellationToken cancellationToken= default);


    void Add(Beca beca);
    void Update(Beca beca);
    void Delete(Guid id);


}
