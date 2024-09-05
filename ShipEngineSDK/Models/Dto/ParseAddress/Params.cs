#nullable disable
using ShipEngineSDK.Models.Dto.Common;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.Models.Dto.ParseAddress
{
    /// <summary>
    /// The only required field is text, which is the text to be parsed. You can optionally also provide an addresscontaining already-known values. For example, you may already know the recipient's name, city, and country, and only want to parse the street address into separate lines. 
    /// </summary>
    public class Params
    {
        /// <summary>
        /// The unstructured text that contains address-related entities
        /// </summary>
        /// <value>The unstructured text that contains address-related entities</value>
        /// <example>
        /// Margie McMiller at 3800 North Lamar suite 200 in austin, tx.  The zip code there is 78652.
        /// </example>
        [JsonPropertyName("text")]
        [JsonRequired]
        public string Text { get; set; }

        /// <summary>
        /// You can optionally provide any already-known address values. For example, you may already know the recipient&#39;s name, city, and country, and only want to parse the street address into separate lines. 
        /// </summary>
        /// <value>You can optionally provide any already-known address values. For example, you may already know the recipient&#39;s name, city, and country, and only want to parse the street address into separate lines. </value>
        [JsonPropertyName("address")]
        public PartialAddress Address { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ParseAddressRequestBody {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson(JsonSerializerOptions options)
        {
            return JsonSerializer.Serialize(this, options);
        }

    }
}
