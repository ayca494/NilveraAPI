using NilveraAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class ExpensesDto
    {
        public ExpenseType ExpenseType { get; set; }
        public decimal Percent { get; set; }
        public decimal Amount { get; set; }
    }
}
