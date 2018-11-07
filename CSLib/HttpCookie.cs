using System.Collections.Generic;

namespace CSLib
{
    class HttpCookie
    {
        private Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();        
        }
    }
}
