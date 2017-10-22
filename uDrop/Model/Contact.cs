using System;
using System.Collections.Generic;

namespace uDrop.Model
{
    public class Contact
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }


		public List<Contact> GetContacts()
		{
            List<Contact> contacts = new List<Contact>() {
                new Contact(){ id=1, name="John", phone="970-200-3779"},
				new Contact() { id=2, name="Jake", phone="970-222-222"},
                new Contact() { id=3, name="Ai", phone="970-333-3333"}
		};
			return contacts;
		}
    }
}
