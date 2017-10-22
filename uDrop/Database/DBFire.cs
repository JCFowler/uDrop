using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uDrop.Model;
using Firebase.Xamarin.Database;
using Firebase.Xamarin.Database.Query;
using Firebase.Xamarin.Auth;

namespace uDrop.Database
{
    public class DBFire
    {
        FirebaseClient firebase;

        public DBFire()
        {
            firebase = new FirebaseClient("https://udrop-499ca.firebaseio.com/");
        }


        public async Task addComputer(Computer c) {
            await firebase.Child("Computer").PostAsync(c);
        }

        public async Task deleteComputer(Computer c) {
            await firebase.Child("Computer").Child(c.id).DeleteAsync();
        }

        public async Task editComputer(Computer c)
        {
            var com = firebase.Child("Computer").Child(c.id);
            await com.Child("fullname").PutAsync(c.fullname);
            await com.Child("hardwarePower").PutAsync(c.hardwarePower);

            //var list = await firebase
            //            .Child("Computer")
            //            .OnceAsync<Computer>();
            //string key = "";
            //foreach (var item in list)
            //{
            //    if (item.Object.fullname == c.fullname)
            //        key = item.Key;
            //}

            //if(key != "")
                //await firebase.Child("Computer").Child(key).PostAsync(c);
        }

        public async Task<List<Computer>> getList() {
            var list = (await firebase
                .Child("Computer")
                        .OnceAsync<Computer>())
                .Select(item =>
                        new Computer
                        {
                            id = item.Key,
                            fullname = item.Object.fullname,
                            hardwarePower = item.Object.hardwarePower
            }).ToList();

            return list;
        }
    }
}
