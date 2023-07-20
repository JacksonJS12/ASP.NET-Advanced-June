using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Data.Models
{
    public class Agent
    {
        [Key]
        public Guid Id { get; set; }

        public TYPE Type { get; set; }
    }
}
