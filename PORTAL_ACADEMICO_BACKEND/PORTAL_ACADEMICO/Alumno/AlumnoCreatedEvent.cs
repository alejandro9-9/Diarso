using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Alumno;
public sealed record AlumnoCreatedEvent(Guid Id) : IDomainEvent;