using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.HTTP
{
    public class Cookie
    {

        public Cookie(string cookieString)
        {

            var partCookie = cookieString.Split(new char[] { '=' }, 2);

            this.Name = partCookie[0];
            this.Value = partCookie[1];


        }


        public string Name { get; set; }

        public string Value { get; set; }


    }
}
