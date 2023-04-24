using DeckOfCardLabAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace DeckOfCardLabAssignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;
        private string _deckId;     


        public HomeController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IActionResult> Index()
        {
            // Make a call to the API to generate a new deck           
            var response = await _httpClient.GetAsync("https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1");
            var result = await response.Content.ReadAsStringAsync();
            var deck = JsonConvert.DeserializeObject<NewDeck>(result);

            // Capture the deck ID returned
            _deckId = deck.DeckId;

            // Draw 5 cards from the deck
            response = await _httpClient.GetAsync($"https://deckofcardsapi.com/api/deck/{_deckId}/draw/?count=5");
            result = await response.Content.ReadAsStringAsync();
            var cards = JsonConvert.DeserializeObject<CardList>(result);

            return View(cards);
        }

        public async Task<ActionResult> DrawCards(string _deckId)
        {
            // Draw 5 cards from the same deck
            var response = await _httpClient.GetAsync($"https://deckofcardsapi.com/api/deck/{_deckId}/draw/?count=5");
            var result1 = await response.Content.ReadAsStringAsync();
           CardList cards = JsonConvert.DeserializeObject<CardList>(result1);

            return View("_Cards", cards);
        }
    }
}