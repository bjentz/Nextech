using System;
using System.Collections.Generic;
using System.Text;


namespace Nextech.Domain
{
    
    public class Article:INextechDomain
    {
       public string by { get;set;}
        public string title { get; set; }
        public string url { get; set; }
    }
}
