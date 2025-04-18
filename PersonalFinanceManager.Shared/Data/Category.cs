﻿using System.ComponentModel.DataAnnotations;

namespace PersonalFinanceManager.Shared.Data
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public int TransactionTypeId { get; set; }
    }
}
