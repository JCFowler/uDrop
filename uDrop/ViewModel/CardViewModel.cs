using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using uDrop.Database;
using uDrop.Model;

namespace uDrop.ViewModel
{
    public class CardViewModel
    {
        //ObservableCollection<Computer> obs = new ObservableCollection<Computer>();
        CardFire db;

		public CardViewModel()
		{
            db = new CardFire();
		}

        public async Task<Card> GetByKey(string key)
        {

            return await db.GetByKey(key);
        }

        public async void Add(Card c)
        {
            await db.Add(c);
        }

        public async void Delete(Card c)
        {
            await db.Delete(c);
        }

        public async void Edit(Card newC, Card oldC)
        {
            await db.Edit(newC, oldC);
        }

        public async Task<List<Card>> GetAll()
        {
            return await db.GetAll();
        }

    }
}
