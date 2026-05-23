using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Aula;
public sealed record AulaUpdatedEvent(Guid Id) : IDomainEvent;