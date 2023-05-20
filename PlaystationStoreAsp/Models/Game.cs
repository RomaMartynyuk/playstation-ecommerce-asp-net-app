using PlaystationStoreAsp.Models.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlaystationStoreAsp.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public double Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int NumberOfPlayers { get; set; }
        public GameGenre Genre { get; set; }

        //Relationship
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company? Company { get; set; }
    }
}
