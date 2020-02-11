using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverInSharp.Observers;
using ObserverInSharp.News;

namespace ObserverInSharp.Observers
{
    class TvObserver : IWidgetable
    {
        private string _tv;
       
        public void Display()
        {
            Console.WriteLine($"TV:{_tv}");
        }
        
        public void Update(object sender, NewsEventArgs e)
        {
            _tv = e.Tv;
            Display();
        }
        
    }
}
