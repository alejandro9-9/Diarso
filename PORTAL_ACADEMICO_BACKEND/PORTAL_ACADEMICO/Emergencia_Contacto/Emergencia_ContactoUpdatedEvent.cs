using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Emergencia_Contacto;
public sealed record Emergencia_ContactoUpdatedEvent(Guid Id) : IDomainEvent;