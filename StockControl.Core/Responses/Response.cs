using StockControl.Core.Configurations;
using System.Text.Json.Serialization;


namespace StockControl.Core.Responses
{
    public class Response<TData>
    {
        public TData? Data { get; set; }

        public string? Message { get; set; }

        private readonly int _code;

        [JsonIgnore]
        public bool IsSucces => _code is >= 200 and <= 299;

        [JsonConstructor]
        public Response() => _code = Configuration.DefaultStatusCode;

        public Response(TData? data, int code = Configuration.DefaultStatusCode, string? message = null)
        {
            Data = data;
            Message = message;
            _code = code;
        }
    }
}
