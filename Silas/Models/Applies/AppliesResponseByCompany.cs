﻿using System.Text.Json.Serialization;

namespace Silas.Models.Applies
{
    public class AppliesResponseByCompany
    {
        [JsonPropertyName("status")]
        public long Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("applies")]
        public List<ApplyByCompany> Applies { get; set; }
    }
}
