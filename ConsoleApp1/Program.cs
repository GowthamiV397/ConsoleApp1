using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
          static void Main(string[] args)
          {
                string title = "";
                string body = "";
                var data = new { action = "Play", userId = 5 };

                Console.WriteLine("Hello Everyone!");
                Console.WriteLine("Let's send push notifications!!!");

                Console.Write("Title of Notification: ");
                title = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Ok, so now I have the title, I'll need a description");
                body = Console.ReadLine();

                Console.WriteLine();

                Console.Write("How many devices are going to receive this notification? ");
                int.TryParse(Console.ReadLine(), out int devicesCount);
                var tokens = new string[devicesCount];

                Console.WriteLine();

                for (int i = 0; i < devicesCount; i++)
                {
                    Console.Write($"Token for device number {i + 1}: ");
                    tokens[i] = Console.ReadLine();
                    Console.WriteLine();
                }

                Console.WriteLine("Do you want to send notifications?");
                Console.WriteLine("1 - Yes!!!!");
                Console.WriteLine("0 - No, I'm wasting my time!!!");
                int.TryParse(Console.ReadLine(), out int sendNotification);
                if (sendNotification == 1)
                {
                    var pushSent = PushNotificationLogic.SendPushNotification(tokens, title, body, data);
                    Console.WriteLine($"Notification sent");
                }
                else
                {
                    Console.WriteLine("BUUUUUU");
                }

                Console.ReadKey();
          }
        public static class PushNotificationLogic
        {
            private static Uri FireBasePushNotificationsURL = new Uri("https://fcm.googleapis.com/fcm/send");
            private static string ServerKey = "AAAAyNCQTi8:APA91bEJlzg9FUq4HztJ_JVHbaM9NoMvkouXQz0u7deBkcRGSxS7rLeXSYkzo5rmNQWd3wDbtAW1ldZrpEAwGiTlh_FdEXkhPul_CdGP72akGm9Z0tcnq8eENC4YqnXKpGphMRaAP33Q";

            /// <summary>
            /// 
            /// </summary>
            /// <param name="deviceTokens">List of all devices assigned to a user</param>
            /// <param name="title">Title of notification</param>
            /// <param name="body">Description of notification</param>
            /// <param name="data">Object with all extra information you want to send hidden in the notification</param>
            /// <returns></returns>
            public static async Task<bool> SendPushNotification(string[] deviceTokens, string title, string body, object data)
            {
                bool sent = false;

                if (deviceTokens.Count() > 0)
                {
                    //Object creation

                    var messageInformation = new Message()
                    {
                        notification = new Notification()
                        {
                            title = title,
                            text = body
                        },
                        data = data,
                        registration_ids = deviceTokens,
                        MessageType = "testtype"
                    };

                    //Object to JSON STRUCTURE => using Newtonsoft.Json;
                    string jsonMessage = JsonConvert.SerializeObject(messageInformation);

                    /*
                     ------ JSON STRUCTURE ------
                     {
                        notification: {
                                        title: "",
                                        text: ""
                                        },
                        data: {
                                action: "Play",
                                playerId: 5
                                },
                        registration_ids = ["id1", "id2"]
                     }
                     ------ JSON STRUCTURE ------
                     */

                    //Create request to Firebase API
                    var request = new HttpRequestMessage(HttpMethod.Post, FireBasePushNotificationsURL);

                    request.Headers.TryAddWithoutValidation("Authorization", "key=" + ServerKey);
                    request.Content = new StringContent(jsonMessage, Encoding.UTF8, "application/json");

                    HttpResponseMessage result;
                    using (var client = new HttpClient())
                    {
                        result = await client.SendAsync(request);
                        sent = sent && result.IsSuccessStatusCode;
                    }
                }

                return sent;
            }

        }

    }
    

    public class Message
    {
        public string[] registration_ids { get; set; }
        public Notification notification { get; set; }
        public object data { get; set; }
        public string MessageType { get; set; }
    }
    public class Notification
    {
        public string title { get; set; }
        public string text { get; set; }
    }
}
