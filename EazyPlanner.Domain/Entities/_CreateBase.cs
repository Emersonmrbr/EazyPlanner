using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyPlanner.Domain.Entities
{
    public class _CreateBase
    {
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "The Created by field cannot be longer than 50 characters")]
        public string? CreatedBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreateDate { get; set; }

        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "The Update by field cannot be longer than 50 characters")]
        public string? UpdateBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? UpdateDate { get; set; }
    }
}
