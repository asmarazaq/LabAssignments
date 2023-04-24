using Newtonsoft.Json;

namespace DeckOfCardLabAssignment.Models
{
    public class NewDeck
    {
        [JsonProperty("deck_id")]
        public string DeckId { get; set; }
    }
}
