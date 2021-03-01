using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace VolCommon
{
    public class ContactInformation
    {
        [BsonIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ContactInformationID { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAdress { get; set; }
    }
}