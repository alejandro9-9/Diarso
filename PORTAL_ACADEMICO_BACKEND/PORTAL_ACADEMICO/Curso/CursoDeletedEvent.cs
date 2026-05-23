using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Curso;
public sealed record CursoDeletedEvent(Guid Id) : IDomainEvent;