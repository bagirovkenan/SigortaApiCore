using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepApiTest.Models.DbModels
{
    public class Base
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool? IsActive { get; set; } = false;
    }
}
