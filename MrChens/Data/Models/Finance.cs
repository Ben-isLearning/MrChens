﻿using System.ComponentModel.DataAnnotations;

namespace MrChens.Data.Models
{
    public class Finance
    {
        [Key]
        public int FinanceId { get; set; }
        public string TransactionType { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
    }
}
