using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace VolCommon
{
    public class Additionalinfo
    {
        [BsonIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string AdditionalinfoID { get; set; }
        public bool HasDrivingLicence { get; set; }
        public bool HasCar { get; set; }
        public string Remark { get; set; }
    }
}