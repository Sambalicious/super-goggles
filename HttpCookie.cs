using System.Collections.Generic;
namespace Basics
{
    public class HttpCookie
    {
        private Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        public HttpCookie()
        {
            
        }

        public string this[string key]
        {
            get{
                return _dictionary[key];
            }
            set{
                _dictionary[key] = value;
            }
        }
    }

}