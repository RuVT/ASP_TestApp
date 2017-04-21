using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MealSchedule.Models
{
    public partial class Ingredient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<string> SimilarNames { get; set; }
    }
}
