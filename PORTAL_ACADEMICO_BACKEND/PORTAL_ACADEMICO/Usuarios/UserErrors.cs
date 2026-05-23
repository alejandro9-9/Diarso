using PORTAL_ACADEMICO_DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Usuarios;

public class UserErrors
{
    public static Error UserNotFound => new("UserErrors.NotFound", "The user was not found.");
    public static Error InvalidPassword => new("UserErrors.InvalidPassword", "The password is incorrect.");
    public static Error NotFoundRole => new("UserErrors.NotFoundRole", "The user not have role.");
}
