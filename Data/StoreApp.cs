using System;
using System.Collections.Generic;
using Newtonsoft.Json;
// get and set is executed when the property is assinged a new value. A property without a set is read only and a property without a get is write only.
 public class StoreApp
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

         [JsonProperty("people")]
         public string People { get; set; }

         [JsonProperty("category")]
         public string Category { get; set; }

         [JsonProperty("date")]
         public string Date { get; set; }

         [JsonProperty("price")]
         public string Price { get; set; }





}


public class StoreDetail {
    [JsonProperty("appList")]
    public List<StoreApp> AppList { get; set; }

    [JsonProperty("totalPageCount")]
    public decimal TotalPageCount { get; set; }
    
}