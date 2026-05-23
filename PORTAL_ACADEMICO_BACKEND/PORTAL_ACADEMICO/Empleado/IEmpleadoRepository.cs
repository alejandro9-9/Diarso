using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Empleado;

public interface IEmpleadoRepository { 
    Task<Empleado?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<List<Empleado>> GetAllAsync(CancellationToken cancellationToken = default);
    void Add(Empleado empleado);
    void Update(Empleado empleado);
    void Delete(Guid Id);
}