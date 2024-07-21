using System.ComponentModel.DataAnnotations;

namespace API_DbManagers.Models
{
    public class Db_Manager
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Company { get; set; }

        public required int Year_creation { get; set; }
    }
}
