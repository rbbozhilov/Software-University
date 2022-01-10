using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.HTTP
{
    public class ResponseCookie : Cookie
    {
        public ResponseCookie(string name, string value) : base(name, value)
        {
        }

        public int MaxAge { get; set; }

        public bool HttpOnly { get; set; }

        public string Path { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append($"{this.Name}={this.Value};");

            if(this.MaxAge != 0)
            {
                builder.Append($" Max-Age={this.MaxAge};");
            }

            if (!string.IsNullOrWhiteSpace(this.Path))
            {
                builder.Append($" Path={this.Path};");
            }

            if (this.HttpOnly)
            {
                builder.Append($" HttpOnly;");
            }

            return builder.ToString();
        }

    }
}
