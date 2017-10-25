using System;
using uDrop.Database;
using uDrop.Model;

namespace uDrop.ViewModel
{
    public class CardCreateViewModel
    {
        CardFire db;

        public CardCreateViewModel()
        {
            db = new CardFire();
        }

        public async void Add(Card c)
        {
            await db.Add(c);
        }

    }
}
