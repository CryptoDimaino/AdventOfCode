using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace AdventOfCode
{
    public class Guard
    {
        public DateTime Date {get;set;}
        public string GuardID {get;set;}
        public List<Action> Action {get;set;}

        public int Minute {get;set;}
        public int ActualMinute {get;set;}
        public int TotalMinutesSlept {get;set;}

        public Guard(string Input)
        {
            Date = DateTime.ParseExact(Input.Substring(1, 16), "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            GuardID = Input.Substring(26, 4);
            Action = new List<Action>();
        }

        public void AddAction(Action TempAction)
        {
            Action.Add(TempAction);
        }
    }
}