using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverInSharp.News;
using ObserverInSharp.Observers;

namespace ObserverInSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            NewsManager newsManager = new NewsManager();
            var lenta = new LentaObserver();
            var tv = new TvObserver();
            var twitter = new TwitterObserver();
            var facebook = new FacebookObserver();
            newsManager.NewsChanged += lenta.Update;
            newsManager.NewsChanged += tv.Update;
            newsManager.NewsChanged += twitter.Update;
            newsManager.NewNewsObserver();
            Console.WriteLine();
            newsManager.NewsChanged -= twitter.Update;
            newsManager.NewsChanged -= tv.Update;
            newsManager.NewsChanged += facebook.Update;


            newsManager.NewNewsObserver();



            Console.Read();
        }
    }
}
