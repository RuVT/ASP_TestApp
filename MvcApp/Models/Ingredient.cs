using System.Data.Entity;
using MealSchedule.Models;

namespace MvcApp.Models
{
	public class IngredientDBContext: DbContext
	{
        public DbSet<Ingredient> Ingredients { get; set; }
	}
}