using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace udacity_react_backend.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaModificacion { get; set; } 
    }
}
