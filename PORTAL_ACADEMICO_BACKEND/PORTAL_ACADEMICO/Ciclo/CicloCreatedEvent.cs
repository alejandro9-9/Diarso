using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Ciclo;

public sealed record CicloCreatedEvent(Guid Id): IDomainEvent;