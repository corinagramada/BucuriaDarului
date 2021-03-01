using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace VolCommon
{
    public class Marca
    {
        [BsonIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MarcaID { get; set; }
        public string marca { get; set; }
        public string IdAplication { get; set; }
        public string IdInvestigation { get; set; }
        public string IdContract { get; set; }
    }
}