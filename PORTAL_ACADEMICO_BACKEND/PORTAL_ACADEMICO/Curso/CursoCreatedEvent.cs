using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Curso;

public sealed record CursoCreatedEvent(Guid Id): IDomainEvent;  