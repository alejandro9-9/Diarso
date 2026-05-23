using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Categoria_Cursos;

public interface ICategoria_CursosRepository {
    Task<Categoria_Cursos?> GetByIdAsync(Guid Id, CancellationToken cancellationToken = default);
    Task<List<Categoria_Cursos>> GetAllAsync(CancellationToken cancellationToken = default);

    Task Add(Categoria_Cursos categoria_cursos);
    Task Update(Categoria_Cursos categoria_cursos);
    Task Delete(Guid Id);
    
}