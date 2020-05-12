using System;
using System.Collections.Generic;
using System.Text;

namespace ParksRec.Client
{
    public class ParksRecConfig
    {
        public Uri Uri { get; } = new Uri("https://parks-and-rec-api.herokuapp.com/api/v1/");
        public string Token { get; set; }
    }
}
