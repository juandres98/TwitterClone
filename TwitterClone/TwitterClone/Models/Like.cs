using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Models
{
    public class Like
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        [ForeignKey(typeof(Tweet))]
        public int IdTweet { get; set; }

    }
}
