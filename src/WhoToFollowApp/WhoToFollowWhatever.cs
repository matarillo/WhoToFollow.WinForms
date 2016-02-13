using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace WhoToFollowApp
{
    public partial class WhoToFollowWhatever
    {
        private IList<JToken> users;
        private readonly PeopleToFollow display = new PeopleToFollow();
        private readonly Random random = new Random();
        private readonly HttpClient client = CreateHttpClient();

        private static HttpClient CreateHttpClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "WhoToFollowApp");
            return client;
        }

        public async void RefreshAll(object sender, RefreshEventArgs e)
        {
            var randomOffset = random.Next(500);
            var requestUrl = "https://api.github.com/users?since=" + randomOffset;
            var json = await client.GetStringAsync(requestUrl);
            users = JArray.Parse(json);
            display.Clear();
            for (var i = 0; i < 3; i++)
            {
                dynamic user = users[random.Next(users.Count)];
                this.SuggestedPeople.Add(new PersonToFollow
                {
                    Name = (string)user.login,
                    Url = new Uri((string)user.html_url),
                    Image = new Uri((string)user.avatar_url)
                });
            }
        }

        public void CloseOne(object sender, CloseEventArgs e)
        {
            dynamic user = users[random.Next(users.Count)];
            this.SuggestedPeople[e.Index] = new PersonToFollow
            {
                Name = (string)user.login,
                Url = new Uri((string)user.html_url),
                Image = new Uri((string)user.avatar_url)
            };
        }

        public PeopleToFollow SuggestedPeople { get { return display; } }
    }
}
