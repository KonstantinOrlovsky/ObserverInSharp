using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverInSharp.Observers;
using ObserverInSharp.News;

namespace ObserverInSharp.Observers
{
    class LentaObserver : IWidgetable
    {
        private string _lenta;
        
       
        public void Update(object sender, NewsEventArgs e )
        {
            _lenta = e.Lenta;
            Display();

        }
        
        public void Display()
        {
            Console.WriteLine($"Lenta: {_lenta}");
        }

        
    }
}
