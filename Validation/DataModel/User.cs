using System;
using System.Collections.Generic;

namespace Validation.DataModel;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Age { get; set; }

    public string IdentityNumber { get; set; } = null!;
}
