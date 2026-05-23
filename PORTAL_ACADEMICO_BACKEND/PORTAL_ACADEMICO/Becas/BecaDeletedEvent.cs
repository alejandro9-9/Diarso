using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Becas;
public sealed record BecaDeletedEvent(Guid Id) : IDomainEvent;