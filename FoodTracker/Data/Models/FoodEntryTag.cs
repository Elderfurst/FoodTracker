namespace FoodTracker.Data.Models
{
	public class FoodEntryTag
	{
		public int Id { get; set; }
		public int FoodEntryId { get; set; }
		public string Value { get; set; }
	}
}
