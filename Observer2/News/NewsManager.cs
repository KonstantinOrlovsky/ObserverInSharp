using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverInSharp.News;
using ObserverInSharp.Observers;


namespace ObserverInSharp.News
{

    public class NewsEventArgs
    {
        public NewsEventArgs(string twitter, string lenta, string tv, string facebook)
        {
            Twitter = twitter;
            Lenta = lenta;
            Tv = tv;
            Facebook = facebook;
        }
        public string Twitter { get; private set; }
        public string Lenta { get; private set; }
        public string Tv { get; private set; }
        public string Facebook { get; private set; }


    }
    public delegate void NewsChangedEventHandler(object sender, NewsEventArgs e);
    class NewsManager 
    {
        
        
        private static Random _random;
        public NewsManager()
        {
            _random = new Random();
            
        }
        public event NewsChangedEventHandler NewsChanged;

        public string GetLenta()
        {
            var news = new List<string>()
            {
                "new news on lenta N1",
                "new news on lenta N2",
                "new news on lenta N3",
            };
            return news[_random.Next(3)];
        }
        public string GetTv()
        {
            var news = new List<string>()
            {
                "new news on tv N1",
                "new news on tv N2",
                "new news on tv N3",
            };
            return news[_random.Next(3)];
        }
        public string GetTwitter()
        {
            var news = new List<string>()
            {
                "new news on twitter N1",
                "new news on twitter N2",
                "new news on twitter N3",
            };
            return news[_random.Next(3)];
        }
        public string GetFacebook()
        {
            var news = new List<string>()
            {
                "new news on facebook N1",
                "new news on facebook N2",
                "new news on facebook N3",
            };
            return news[_random.Next(3)];
        }


        public void NewNewsObserver()
        {
            string lenta = GetLenta();
            string tv = GetTv();
            string twitter = GetTwitter();
            string facebook = GetFacebook();


            NewsChanged?.Invoke(this, new NewsEventArgs(twitter, lenta, tv, facebook));

        }
    }
}
