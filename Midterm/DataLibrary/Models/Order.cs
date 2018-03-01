using System.Collections.Generic;
using System;

namespace DataLibrary.Models 
{
    public class Order
    {
        public string DestinationOne {get; set;}
        public string DestinationTwo {get; set;}
        public string Type {get; set;}   
        public DateTime OrderedDate {get; set;} 
        public string Customer {get;set;}

    }
}