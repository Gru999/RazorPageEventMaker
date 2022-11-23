using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RazorPageEventMaker.Models {
    public class Hotel {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Hotel(int id, string name, string address) {
            Id = id;
            Name = name;
            Address = address;
        }
    }
}
