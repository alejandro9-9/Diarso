using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Alumno_Perfil;


public sealed record Alumno_PerfilCreatedEvent(Guid Id):IDomainEvent;