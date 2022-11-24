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
        public Hotel() { }

        public override bool Equals(object? obj) {
            if (obj == null) {
                return false;
            } else {
                Hotel other = obj as Hotel;
                if (other.Id == Id) {
                    return true;
                } else {
                    return false;
                }
            }
        }
    }
}
