﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebECApp.Models
{
    // defining properties relevant for comment class
    public class Comment
    {
        public int CommentID { get; set; }
        public string ProductId { get; set; }
        public string Text { get; set; }
        public DateTime TimeStamp { get; set; }
        public string UserId { get; set; }
        public int Ratings { get; set; }
    }
}
