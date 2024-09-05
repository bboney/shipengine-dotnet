namespace ShipEngineSDK.Models.Dto.ParseAddress;

using ShipEngineSDK.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Result
{
    /// <summary>
    /// A confidence score between zero and one that indicates how certain the API is that it understood the text. 
    /// </summary>
    /// <value>A confidence score between zero and one that indicates how certain the API is that it understood the text. </value>
    [JsonPropertyName("score")]
    [JsonRequired]
    public double Score { get; set; }

    /// <summary>
    /// The parsed address.  This address may not be complete, depending on how much information was included in the text and how confident the API is about each recognized entity.  &gt; **Note:** The shipment-recognition API does not currently perform any validation of the parsed addresses, so we recommend that you use the [address-validation API](https://www.shipengine.com/docs/addresses/validation/) to ensure that the addresses are correct. 
    /// </summary>
    /// <value>The parsed address.  This address may not be complete, depending on how much information was included in the text and how confident the API is about each recognized entity.  &gt; **Note:** The shipment-recognition API does not currently perform any validation of the parsed addresses, so we recommend that you use the [address-validation API](https://www.shipengine.com/docs/addresses/validation/) to ensure that the addresses are correct. </value>
    [JsonPropertyName("address")]
    [JsonRequired]
    public Address? Address { get; set; }

    /// <summary>
    /// All of the entities that were recognized in the text. An \&quot;entity\&quot; is a single piece of data, such as a city, a postal code, a carrier name, or a package weight.  Each entity includes the original text and the parsed value. 
    /// </summary>
    /// <value>All of the entities that were recognized in the text. An \&quot;entity\&quot; is a single piece of data, such as a city, a postal code, a carrier name, or a package weight.  Each entity includes the original text and the parsed value. </value>
    [JsonPropertyName("entities")]
    [JsonRequired]
    public List<RecognizedEntity>? Entities { get; set; }
}
