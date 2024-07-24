﻿using Domain.Common;

namespace Domain.Entities;

public class PasswordPolicy : Entity
{
    public bool RequireDigit { get; set; }
    public bool RequireLowerCase { get; set; }
    public bool RequireUpperCase { get; set; }
    public bool RequireNonAlphanumeric { get; set; }
    public int RequiredLength { get; set; }
}