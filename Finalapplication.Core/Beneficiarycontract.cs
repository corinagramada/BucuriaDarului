﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace Finalaplication.Models
{
    public class Beneficiarycontract
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string BeneficiarycontractID { get; set; }

        public string OwnerID { get; set; }

        public string Fullname { get; set; }
        public string NumberOfPortion { get; set; }

        public string CNP { get; set; }

        public string Address { get; set; }

        public string Nrtel { get; set; }
        public string CIinfo { get; set; }

        //public string CIseria { get; set; }

        //public string CINr { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        //public DateTime CIEliberat { get; set; }

        //public string CIeliberator { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Birthdate { get; set; }

        public string NumberOfRegistration { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime RegistrationDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ExpirationDate { get; set; }

        public bool GetDayExpiration(DateTime date)
        {
            var now = DateTime.Now;
            var firstday = now.AddDays(-1);
            var lastday = now.AddDays(10);
            var answer = false;
            if (date >= firstday && date <= lastday)
            {
                answer = true;
            }
            return answer;
        }

        public string IdInvestigation { get; set; }
        public string IdApplication { get; set; }
    }
}