﻿using System;
using System.Collections.Generic;

namespace Onsdagapi.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
