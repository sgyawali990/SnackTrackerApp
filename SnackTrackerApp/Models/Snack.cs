using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SnackTrackerApp.Models
{
    public class Snack
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime LastUpdated { get; set; } = DateTime.Now;
        public int WarningLevel { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public int WarningThreshold { get; set; } = 2;
    }
}
