using System.ComponentModel.DataAnnotations;

namespace RazorPageEventMaker.Models
{
    public class Country
    {
        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                Country other = obj as Country;
                if (other.Code == Code)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
