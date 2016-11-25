using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoutwestWater
{
    public class Navigation
    {
        public class LinkDetails
        {
            public LinkDetails(string linkText, string url)
            {

                LinkText = linkText;
                Url = url;
            }

            public LinkDetails()
            { }

            public string LinkText { get; set; }
            public string Url { get; set; }
        }
    }
}
