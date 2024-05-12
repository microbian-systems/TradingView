using System.Text.Json.Serialization;

namespace BlockMountain.TradingView.Models
{
    /// <summary>
    /// Represents a symbol exchgange.
    /// </summary>
    public class TvSymbolExchange
    {
        /// <summary>
        /// The value of the exchange.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// The name of the exchange.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of the exchange.
        /// </summary>
        [JsonPropertyName("desc")]
        public string Description { get; set; }
    }
}