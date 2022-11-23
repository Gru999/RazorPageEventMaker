using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RazorPageEventMaker.Models {
    public class Hotel {

        //[Required(ErrorMessage = "The Id cannot be set to negative numbers or beyond the max value")]
        //[Range(typeof(int), "1", "50")]
        public int Id { get; set; }
        [Display(Name = "Hotel Name")]
        [Required(ErrorMessage = "Name of the Hotel is required"), MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "The Address can not be longer than 30 chars")]
        public string Address { get; set; }

        public Hotel(int id, string name, string address) {
            Id= id;
            Name= name;
            Address= address;
        }
        public Hotel()
        {

        }
    }
}
