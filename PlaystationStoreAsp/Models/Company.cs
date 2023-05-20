using PlaystationStoreAsp.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace PlaystationStoreAsp.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public CompanyCountries Country { get; set; }

        //Relationship
        public List<Game>? Games { get; set; }
    }
}
