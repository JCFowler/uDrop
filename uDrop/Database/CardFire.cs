﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uDrop.Model;
using Firebase.Xamarin.Database;
using Firebase.Xamarin.Database.Query;
using Firebase.Xamarin.Auth;

namespace uDrop.Database
{
    public class CardFire
    {
        FirebaseClient firebase;

        public CardFire()
        {
            firebase = new FirebaseClient("https://udrop-499ca.firebaseio.com/");
        }

        public async Task<Card> GetByKey(string key)
        {
            return (Card)await firebase.Child("Card").Child(key).OnceSingleAsync<Card>();
        }

        public async Task Add(Card c)
        {
            await firebase.Child("Card").PostAsync(c);
        }

        public async Task Delete(Card c)
        {
            await firebase.Child("Card").Child(c.id).DeleteAsync();
        }

        public async Task Edit(Card newC, Card oldC)
        {
            await firebase.Child("Card").Child(oldC.id).PutAsync(newC);
        }

        public async Task<List<Card>> GetAll()
        {
            var cardList = new List<Card>();

                
            var fireList = await firebase
                        .Child("Card")
                        .OnceAsync<Card>();

            foreach (var item in fireList)
            {
                var card = new Card();
                card.id = item.Key;
                card.fName = item.Object.fName;
                card.lName = item.Object.lName;
                card.phone = item.Object.phone;
                card.email = item.Object.email;
                card.company = item.Object.company;
                card.title = item.Object.title;

                cardList.Add(card);
            }

            return cardList;
        }
    }
}
