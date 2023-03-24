using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp;
using Newtonsoft.Json;

namespace Nour.model.firebase
{
    internal class downloadQuestion : @interface
    {
        public string title {
            get; set;
        }

        public IFirebaseConfig FirebaseConfig { get; }

        public downloadQuestion(string title)
        {
            this.title=title;

            FirebaseConfig = new FirebaseConfig
            {
                AuthSecret = "AIzaSyADpbEM1gl3G_yb5op8Z_oFQisvc8baUzs\r\n",
                BasePath = "https://com-inf-ca85f.firebaseio.com/"
            };
        }
        public async Task downloadAsync()
        {
            IFirebaseClient firebaseClient = new FirebaseClient(FirebaseConfig);
            if (firebaseClient == null)
                return;

            var result = await firebaseClient.GetAsync($"Question/{title}");
            var accounts = JsonConvert.DeserializeObject<ASKImage>(result.Body.ToString());
            WebClient webClient =new WebClient();
            webClient.DownloadFile(accounts.image, $"{accounts.title}.png");
        }
    }
}
