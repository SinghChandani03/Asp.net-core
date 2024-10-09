using System;
using System.Collections.Generic;

namespace WebAPICRUD.Models;

public partial class User
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
