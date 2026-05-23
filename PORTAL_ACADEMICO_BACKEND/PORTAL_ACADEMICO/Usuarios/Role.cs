using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Usuarios;

public sealed class Role : Entity
{
    private Role(
        Guid id,
        string name,
        bool isActive) : base(id)
    {
        Name = name;
        IsActive = isActive;
    }
    public string Name { get; private set; }
    public bool IsActive { get; private set; }

    public static Role CreateRole(string name)
    {
        return new Role(Guid.NewGuid(), name, true);
    }
}


