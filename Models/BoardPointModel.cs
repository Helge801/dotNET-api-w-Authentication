using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIAuth.Models
{
    public class BoardPointModel
    {
        public int[][] points  { get; set; }
        public string BoardName { get; set;  }
    }
}