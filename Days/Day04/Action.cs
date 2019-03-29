using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;


namespace AdventOfCode
{
    public class Action
    {
        public DateTime Date {get;set;}
        public string ActionType {get;set;}
        
        public Action(String Input)
        {
            Date = DateTime.ParseExact(Input.Substring(1, 16), "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            ActionType = Input.Substring(19);
        }
    }
}