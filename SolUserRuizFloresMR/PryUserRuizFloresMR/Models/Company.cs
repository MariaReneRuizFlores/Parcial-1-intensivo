
namespace PryUserRuizFloresMR.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Company
    {
        [Key]
        [Required]
        public string name { get; set; }
        public string catchPhrase { get; set; }
        //public string bs { get; set; }
    }
}