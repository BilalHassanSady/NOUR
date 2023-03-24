using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Storage;
using Nour.model;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp;
using Newtonsoft.Json;

namespace Nour.model.firebase
{
    internal class getListUser : @interface
    {
        public Account Account { get; set; }

        public IFirebaseConfig FirebaseConfig { get; }

        public getListUser(Account account)
        {
            Account=account;

            FirebaseConfig = new FirebaseConfig
            {
                AuthSecret = "AIzaSyADpbEM1gl3G_yb5op8Z_oFQisvc8baUzs\r\n",
                BasePath = "https://com-inf-ca85f.firebaseio.com/"
            };
        }
        public async Task<List<string>> getListAsync()
        {
            IFirebaseClient firebaseClient = new FirebaseClient(FirebaseConfig);
            while (firebaseClient != null)
                break;

            try
            {
                var result = firebaseClient.GetAsync($"Titels/");
                System.IO.File.WriteAllText( "test.txt" , result.Result.Body);
                string[] x = result.Result.Body.Split(':');
                List<string> strings = new List<string>();
                for(int i = 0; i < x.Length - 1; i++)
                {
                    strings.Add(x[i + 1].Remove(0, 1).Split(new string[] { "\"" }, StringSplitOptions.None)[0]);
                }
                return strings;
            }
            catch(Exception ex)
            {

            }
            return new List<string>();


        }
    }
}
