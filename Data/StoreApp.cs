using System;
using System.Collections.Generic;
using Newtonsoft.Json;

 public class StoreApp
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }

    }


public class StoreDetail {
    [JsonProperty("appList")]
    public List<StoreApp> AppList { get; set; }

    [JsonProperty("totalPageCount")]
    public decimal TotalPageCount { get; set; }
    
}