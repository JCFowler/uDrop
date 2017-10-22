using System;
using System.Collections.Generic;
using uDrop.Model;

namespace uDrop.ViewModel
{
    public class ContactViewModel
    {
        public List<Contact> contacts { get; set; }

        public ContactViewModel()
        {
            contacts = new Contact().GetContacts();
        }
    }
}
