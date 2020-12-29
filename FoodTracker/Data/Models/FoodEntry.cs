using System;
using System.Collections.Generic;

namespace FoodTracker.Data.Models
{
	public class FoodEntry
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public DateTime Date { get; set; }
		public string Title { get; set; }
		public IEnumerable<FoodEntryTag> Tags { get; set; }
	}
}
