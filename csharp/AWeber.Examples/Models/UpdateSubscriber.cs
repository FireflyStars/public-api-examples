﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace AWeber.Examples.Models
{
    public class UpdateSubscriber
    {
        [JsonProperty("ad_tracking")] public string AdTracking { get; set; }
        [JsonProperty("custom_fields")] public IDictionary<string, string> CustomFields { get; set; }
        [JsonProperty("email")] public string Email { get; set; }
        [JsonProperty("last_followup_message_number_sent")] public int? LastFollowupMessageNumberSent { get; set; }
        [JsonProperty("misc_notes")] public string MiscellaneousNotes { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("status")] public string Status { get; set; }
        [JsonProperty("strict_custom_fields")] public string StrictCustomFields { get; set; }
        [JsonProperty("tags")] public IDictionary<string, IList<string>> Tags { get; set; }
    }
}