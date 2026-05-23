using System;
using System.Collections.Generic;
using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Categoria_Cursos;

public sealed record Categoria_CursosDeletedEvent(Guid Id): IDomainEvent;