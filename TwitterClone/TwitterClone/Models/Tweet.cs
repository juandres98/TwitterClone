using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Models
{
    public class Tweet
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string Text { get; set; }
    }
}
