using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using FireSharp;
using FireSharp.Config;
using FireSharp.Extensions;
using FireSharp.Interfaces;
using Newtonsoft.Json;

namespace Nour.model.firebase
{
    internal class LogIn : @interface
    {
        public IFirebaseConfig FirebaseConfig { get; }


        public LogIn()
        {
            FirebaseConfig = new FirebaseConfig
            {
                AuthSecret = "AIzaSyADpbEM1gl3G_yb5op8Z_oFQisvc8baUzs\r\n",
                BasePath = "https://com-inf-ca85f.firebaseio.com/"
            };
        }

        public async Task<bool> checkAccount(Account account)
        {
            IFirebaseClient firebaseClient = new FirebaseClient(FirebaseConfig);
            if (firebaseClient == null)
                return false;

            var result = await firebaseClient.GetAsync("Account");
            var accounts = JsonConvert.DeserializeObject<List<Account>>(result.Body.ToString());


            foreach(var item in accounts)
            {
                if (item.username == account.username)
                {
                    if (item.password == account.password)
                    {
                        return true;
                    }
                
                }
            }
            return false;
        }
    }
}
