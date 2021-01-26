
namespace PryUserRuizFloresMR.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Root
    {
        [Key]
        //[Required]
        //[StringLength(80, ErrorMessage = "Nombre debe contener de 5 a 80 caracteres", MinimumLength = 5)]
        //[Range(0, 10000, ErrorMessage = "El precio oscila entre 0 a 10000")]
        public int id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Nombre debe contener de 5 a 100 caracteres", MinimumLength = 5)]
        public string name { get; set; }
        //public string username { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public Address address { get; set; }
        [Required]
        public string phone { get; set; }
        public string website { get; set; }
        public Company company { get; set; }
    }
}