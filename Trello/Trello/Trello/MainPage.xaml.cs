using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Trello
{
    public class Card
    {
        public string Title { get; set; }

        public Card(string title)
        {
            Title = title;
        }
    }
    
    public class CardGroup
    {
        public string Title { get; set; }
        public ObservableCollection<Card> Cards { get; set; }
    }
    
    
    public partial class MainPage : ContentPage
    {
        public List<CardGroup> CardCroups { get; set; } = new List<CardGroup>()
        {
            new CardGroup()
            {
                Title = "First Group",
                Cards = new ObservableCollection<Card>()
                {
                    new Card("Card 1"),
                    new Card("Card 2, with a much longer title than the first one"),
                    new Card("Card 3"),
                    new Card("Card 4")
                }
            },
            new CardGroup()
            {
                Title = "Second Group",
                Cards = new ObservableCollection<Card>()
                {
                    new Card("Card 1"),
                    new Card("Card 2"),
                    new Card("Card 3"),
                    new Card("Card 4")
                }
            }
        };
        
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
