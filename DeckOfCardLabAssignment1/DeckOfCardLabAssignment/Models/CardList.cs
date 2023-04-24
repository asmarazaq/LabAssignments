using Newtonsoft.Json;

namespace DeckOfCardLabAssignment.Models
{
    public class CardList
    {
        [JsonProperty("cards")]
        public List<Card> Cards { get; set; }
        [JsonProperty("deck_id")]
        public string _deckId { get; set; }  
    }
}
