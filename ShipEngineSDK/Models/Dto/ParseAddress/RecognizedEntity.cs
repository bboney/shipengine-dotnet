namespace ShipEngineSDK.Models.Dto.ParseAddress;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

/// <summary>
/// An entity is a single piece of data that was recognized in unstructured text.  For example, a city, a postal code, package dimensions, insured value, etc.  Each entity includes the original text and the parsed value. 
/// </summary>
public class RecognizedEntity
{
    /// <summary>
    /// The Entity type (e.g. \&quot;weight\&quot;, \&quot;person\&quot;, \&quot;address_line1\&quot;, etc.)
    /// </summary>
    /// <value>The Entity type (e.g. \&quot;weight\&quot;, \&quot;person\&quot;, \&quot;address_line1\&quot;, etc.)</value>
    [JsonPropertyName("type")]
    [JsonRequired]
    public string Type { get; set; }

    /// <summary>
    /// A confidence score between zero and one that indicates how certain the API is that it correctly recognized this entity 
    /// </summary>
    /// <value>A confidence score between zero and one that indicates how certain the API is that it correctly recognized this entity </value>
    [JsonPropertyName("score")]
    [JsonRequired]
    public double Score { get; set; }

    /// <summary>
    /// The substring from the original text that was recognized as this entity
    /// </summary>
    /// <value>The substring from the original text that was recognized as this entity</value>
    [JsonPropertyName("text")]
    [JsonRequired]
    public string Text { get; set; }

    /// <summary>
    /// The index of the first character of this entity within the original text
    /// </summary>
    /// <value>The index of the first character of this entity within the original text</value>
    [JsonPropertyName("start_index")]
    [JsonRequired]
    public int StartIndex { get; set; }

    /// <summary>
    /// The index of the last character of this entity within the original text
    /// </summary>
    /// <value>The index of the last character of this entity within the original text</value>
    [JsonPropertyName("end_index")]
    [JsonRequired]
    public int EndIndex { get; set; }

    /// <summary>
    /// The normalized value of the entity.  Most entity results have a &#x60;value&#x60; field, which is the normalized value of the entity.  For example, if the substring \&quot;john doe\&quot; was recognized as a \&quot;person\&quot; entity, then the value might be normalized to have proper capitalization (e.g. \&quot;John Doe\&quot;).  Or if the substring \&quot;ft worth\&quot; was recognized as a \&quot;city\&quot; entity, then the value might be normalized to \&quot;Fort Worth\&quot;.  Some entities have other information in addition to, or instead of a &#x60;value&#x60;.  For example, a \&quot;dimensions\&quot; entity will have separate fields for &#x60;length&#x60;, &#x60;width&#x60;, &#x60;height&#x60;, and &#x60;unit&#x60;. 
    /// </summary>
    /// <value>The normalized value of the entity.  Most entity results have a &#x60;value&#x60; field, which is the normalized value of the entity.  For example, if the substring \&quot;john doe\&quot; was recognized as a \&quot;person\&quot; entity, then the value might be normalized to have proper capitalization (e.g. \&quot;John Doe\&quot;).  Or if the substring \&quot;ft worth\&quot; was recognized as a \&quot;city\&quot; entity, then the value might be normalized to \&quot;Fort Worth\&quot;.  Some entities have other information in addition to, or instead of a &#x60;value&#x60;.  For example, a \&quot;dimensions\&quot; entity will have separate fields for &#x60;length&#x60;, &#x60;width&#x60;, &#x60;height&#x60;, and &#x60;unit&#x60;. </value>
    [JsonPropertyName("result")]
    public Dictionary<string, Object> Result { get; set; }

}
