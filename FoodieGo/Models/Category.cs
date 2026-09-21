using SQLite;

namespace FoodieGo.Models
{
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
        public string Icon { get; set; }
        public int ProductCount { get; set; }
    }
}
