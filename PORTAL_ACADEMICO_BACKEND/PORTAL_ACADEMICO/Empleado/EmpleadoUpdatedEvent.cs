using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Empleado;

public sealed record EmpleadoUpdatedEvent (Guid Id) : IDomainEvent;
