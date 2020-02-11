using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverInSharp.News;

namespace ObserverInSharp.Observers
{
    class FacebookObserver : IWidgetable
    {
        private string _facebook;
        public void Update(object sender, NewsEventArgs e)
        {
            _facebook = e.Facebook;
            Display();
        }
        public void Display()
        {
            Console.WriteLine($"Facebook: {_facebook}");
        }
    }
}
