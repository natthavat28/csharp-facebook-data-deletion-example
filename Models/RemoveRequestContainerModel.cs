using System;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace Facebook.DataDeleteExample
{
    public class RemoveRequestContainerModel
    {
        [JsonProperty("signed_request")]
        [FromForm(Name = "signed_request")]
        public string SignedRequest { get; set; }

        public string UserId
        {
            get
            {
                return JsonConvert.DeserializeObject<RemoveRequestPayloadModel>(Base64UrlEncoder.Decode(SignedRequest?.Split(".")?.LastOrDefault() ?? "")).UserId;
            }
        }
    }

    public class RemoveRequestPayloadModel
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }

    public class RemoveRequestResponseModel
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("confirmation_code")]
        public string ConfirmationCode { get; set; }
    }
}