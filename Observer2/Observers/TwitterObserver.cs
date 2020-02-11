using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverInSharp.Observers;
using ObserverInSharp.News;

namespace ObserverInSharp.Observers
{
    class TwitterObserver : IWidgetable
    {
        private string _twitter;
        public void Display()
        {
            Console.WriteLine($"Twitter:{_twitter}");
        }
        
        public void Update(object sender, NewsEventArgs e)
        {
            _twitter = e.Twitter;
            Display();
        }
       
    }
}
