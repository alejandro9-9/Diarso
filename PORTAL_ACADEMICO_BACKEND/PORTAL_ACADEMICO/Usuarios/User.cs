using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Usuarios;


public sealed class User : Entity
{
    private User(
        Guid id,
        string userName,
        string password,
        Guid idRole,
        bool isActive,
        DateTime fechaCreacion) : base(id)
    {
        UserName = userName;
        IdRole = idRole;
        IsActive = isActive;
        Password = password;
        FechaCreacion = fechaCreacion;
    }

    public string UserName { get; private set; }
    public string Password { get; private set; }
    public Guid IdRole { get; private set; }
    public Role? Role { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime FechaCreacion { get; private set; }

    public static User CreateUser(
        string userName,
        string password,
        DateTime createdAt,
        Guid idRole)
    {
        return new User(Guid.NewGuid(), userName, password, idRole, true, createdAt);
    }


}
