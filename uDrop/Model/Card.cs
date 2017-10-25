using System;
using System.Collections.Generic;

namespace uDrop.Model
{
    public class Card
    {
        public string id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string company { get; set; }
        public string title { get; set; }

        public string firstLast { get { return fName + " " + lName; }}

		public List<Card> GetCards()
		{
			List<Card> cards = new List<Card>() {
			new Card(){ id="1", fName="John", lName="Fowler", phone="970-200-3779",
                    email="krasez@yahoo.com", company="Revature", title="Software Engineer" },
				
                new Card() { id="2", fName="Jake", lName="Fowler", phone="970-222-222",
				email="jake@yahoo.com", company="Jakes Knives", title="Knife maker"},
				new Card() { id="3", fName="Ai", lName="Wakikawa", phone="970-333-3333",
				email="ai@yahoo.com", company="Falmenco", title="Dancer"}
		};
			return cards;
		}
    }
}
