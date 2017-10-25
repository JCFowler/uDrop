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
        DBFire db2;

		public CardViewModel()
		{
            db = new CardFire();
            db2 = new DBFire();
		}

        public async void Add(Card c)
        {
            await db.Add(c);
        }

        public async void Delete(Card c)
        {
            await db.Delete(c);
        }

        public async void Edit(Card c)
        {
            await db.Edit(c);
        }

        public async Task<List<Card>> GetAll()
        {
            //return await db2.GetAll();
            return await db.GetAll();
        }

    }
}
