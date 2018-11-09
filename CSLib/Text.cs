using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLib
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AdapaterLink(string url)
        {
            Console.WriteLine("Added link to:  {0}", url);
        }
    }
}
