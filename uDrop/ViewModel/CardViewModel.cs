using System;
using System.Collections.Generic;
using uDrop.Model;

namespace uDrop.ViewModel
{
    public class CardViewModel
    {
        public List<Card> cards { get; set; }

		public CardViewModel()
		{
			cards = new Card().GetCards();
		}
    }
}
