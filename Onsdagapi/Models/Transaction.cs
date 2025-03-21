﻿using System;
using System.Collections.Generic;

namespace Onsdagapi.Models;

public partial class Transaction
{
    public int TransactionId { get; set; }

    public int? AccountId { get; set; }

    public string? TransactionType { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? TransactionDate { get; set; }

    public virtual Account? Account { get; set; }
}
