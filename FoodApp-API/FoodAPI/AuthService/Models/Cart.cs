using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AuthService.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
