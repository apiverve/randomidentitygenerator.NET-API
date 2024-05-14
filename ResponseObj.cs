using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class company
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("catchPhrase")]
    public string catchPhrase { get; set; }

    [JsonProperty("bs")]
    public string bs { get; set; }

}

public class data
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("username")]
    public string username { get; set; }

    [JsonProperty("email")]
    public string email { get; set; }

    [JsonProperty("phone")]
    public string phone { get; set; }

    [JsonProperty("website")]
    public string website { get; set; }

    [JsonProperty("company")]
    public company company { get; set; }

    [JsonProperty("gender")]
    public string gender { get; set; }

    [JsonProperty("birthdate")]
    public string birthdate { get; set; }

    [JsonProperty("cell")]
    public string cell { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
