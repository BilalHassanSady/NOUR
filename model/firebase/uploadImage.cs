using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Firebase.Storage;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using Newtonsoft.Json;

namespace Nour.model.firebase
{
    class ASKImage
    {
        public string title { get; set; }
        public string image { get; set; }
        public string response { get; set; }
        //public int id { get; set; }
    }
    internal class uploadImage : @interface
    {
        private string pathFile;
        Account Account { get; set; }
        public string titleQuestion { get; set;}

        public IFirebaseConfig FirebaseConfig { get; }


        public uploadImage(string pathFile, string titleQuestion,Account account)
        {
            this.Account = account;
            this.pathFile=pathFile;
            this.titleQuestion = titleQuestion;

            FirebaseConfig = new FirebaseConfig
            {
                AuthSecret = "AIzaSyADpbEM1gl3G_yb5op8Z_oFQisvc8baUzs\r\n",
                BasePath = "https://com-inf-ca85f.firebaseio.com/"
            };
        }

        public async void Upload()
        {
            var cancellation = new CancellationTokenSource();
            var stream = File.Open(pathFile, FileMode.Open);
            var year = DateTime.Today.Year;
            var Month = DateTime.Today.Month;
            var day = DateTime.Today.Day;
            var hour = DateTime.Today.Hour;
            try
            {
                var task = new FirebaseStorage(
                    "com-inf-ca85f.appspot.com",
                    new FirebaseStorageOptions
                    {
                        ThrowOnCancel = true
                    })
                    .Child($"Questions/{Account.username}")
                    .Child(titleQuestion+$":{year}-{Month}")
                    .PutAsync(stream, cancellation.Token);


                IFirebaseClient firebaseClient = new FirebaseClient(FirebaseConfig);
                if (firebaseClient == null)
                    return;



                Question question = new Question(titleQuestion,Account,"", $"https://firebasestorage.googleapis.com/v0/b/com-inf-ca85f.appspot.com/o/Questions%2F{Account.username}%2F{titleQuestion}:{year}-{Month}?alt=media");

                var dt = new Nour.model.firebase.ASKImage
                {
                    title = question.title,
                    image = question.image,
                    response = question.Response
                };

               

                var result = await firebaseClient.SetAsync($"Question/{dt.title}", dt);

                var reslut = await firebaseClient.PushAsync($"Titels/", titleQuestion);

            }
            catch(Exception ex)
            {

            }

        }
    }
}
