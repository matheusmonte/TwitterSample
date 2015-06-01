using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Windows.System;

namespace TwitterSample.Utils
{
    public static class TwitterUtils
    {
        private const string TWITTER_URL = "https://twitter.com/intent/tweet?text={0}&url={1}";

        public static async void ShareOnTwitter(string Content, string Url)
        {
            string twitterUrl = string.Format(TWITTER_URL, new string[] { WebUtility.UrlEncode(Content), WebUtility.UrlEncode(Url) });
            await Launcher.LaunchUriAsync(new Uri(twitterUrl));
        }
    }
}
