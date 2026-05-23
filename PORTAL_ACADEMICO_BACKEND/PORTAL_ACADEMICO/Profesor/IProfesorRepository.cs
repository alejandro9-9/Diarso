using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Profesor;

public interface IProfesorRepository {

    Task<Profesor> GetByIdAsync(Guid id, CancellationToken cancellationToken= default);

    Task<List<Profesor>> GetAllAsync(CancellationToken cancellationToken= default);

    void Add(Profesor profesor);
    void Update(Profesor profesor);
    void Delete(Guid Id);



}