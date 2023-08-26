using System.Xml.Linq;

namespace Registration.Models
{
    public class RegistrationDetails
    {
        public string Name { get; set; }
        public string EmailId { get; set; }
        public int MobileNumber { get; set; }
        public string Password { get; set; }

    }
}
