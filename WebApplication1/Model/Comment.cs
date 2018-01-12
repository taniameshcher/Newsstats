using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Comment
    /* What is it??? {
         public class Rootobject
         {
             public Class1[] Property1 { get; set; }
         }

         public class Class1*/
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }
    }

}

