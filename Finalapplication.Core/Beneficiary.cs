﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using VolCommon;

namespace Finalaplication.Models
{
    public class Beneficiary : BeneficiaryBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BeneficiaryID { get; set; }

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
    }
}