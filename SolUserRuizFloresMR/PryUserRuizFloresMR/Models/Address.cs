
namespace PryUserRuizFloresMR.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Address
    {
        [Key]
        [Required]
        public string street { get; set; }
        [Required]
        public string suite { get; set; }
        [Required]
        public string city { get; set; }
        //public string zipcode { get; set; }
        public Geo geo { get; set; }
    }
}