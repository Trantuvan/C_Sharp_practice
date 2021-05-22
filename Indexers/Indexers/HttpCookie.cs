using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        //declaring a dict and always remember to initialize with empty dict avoid null excpetion
        //adding readonly modifier to avoid lost data
        private readonly Dictionary<string, string> _dictionary;

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        //declaring an indexers for dictionary
        public string this[string key]
        { 
            get 
            { /* return the specified index here */
                return _dictionary[key];
            }
            set 
            { /* set the specified index to value here */
                _dictionary[key] = value;
            }
        }
    }
}
