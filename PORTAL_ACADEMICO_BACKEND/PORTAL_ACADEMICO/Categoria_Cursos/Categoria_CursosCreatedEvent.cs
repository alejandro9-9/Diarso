using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Categoria_Cursos;

public sealed record Categoria_CursosCreatedEvent(Guid Id): IDomainEvent;