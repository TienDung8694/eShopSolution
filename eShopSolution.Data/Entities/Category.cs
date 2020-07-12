using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.Data.Enum;

namespace eShopSolution.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public bool IsSHowOnHome { get; set; }
        public int? ParientId { get; set; }
        public Status Status { get; set; }
    }
}
