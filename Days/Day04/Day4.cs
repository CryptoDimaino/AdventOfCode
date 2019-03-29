using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode
{
    public static class Day4
    {
        // ID: 2039 Max Minute: 49
        // Who slept the most after you find that find the minute with the most minutes slept for tht person.
        // What is the ID of the guard you chose multiplied by the minute you chose?
        public static int Part1(IEnumerable<string> FileInput)
        {
            // Create List of all inputs and sort by DateTime
            List<string> File = FileInput.OrderBy(l => DateTime.ParseExact(l.Substring(1, 16), "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture)).ToList();
            
            // Create List of Guards
            List<Guard> Guards = new List<Guard>();
            
            // Create a guard and set it to null because error is through without instantiation
            Guard guard = null;
            Action action;

            // Loop through all lines in the list
            foreach(string Line in File)
            {
                // Check for the string guard and create a new guard
                if(Line.Substring(19, 5) == "Guard")
                {
                    // Create a new guard but only add the guard if it does no exist
                    guard = new Guard(Line);
                    bool GuardExists = Guards.Any(id => id.GuardID == guard.GuardID);
                    if(!GuardExists)
                    {
                        Guards.Add(guard);
                    }
                }
                else
                {
                    // Add action to the specific guard
                    action = new Action(Line);
                    guard = Guards.Single(id => id.GuardID == guard.GuardID);
                    guard.AddAction(action);
                }
            }

            // Create and populate dictionary for 60 minutes
            Dictionary<int, int> MinuteCounter = new Dictionary<int, int>();
            for(int minute = 0; minute < 60; minute++)
            {
                MinuteCounter.Add(minute, 0);
            }

            // Loop through all the guards
            for(int i = 0; i < Guards.Count; i++)
            {
                // Loop through all the actions in every guard
                for(int j = 0; j < Guards[i].Action.Count; j += 2)
                {
                    // Loop the the total time spent sleeping and awake added to minutes counter
                    // MinuteCount - The time the guard went to sleep
                    // Guards[i].Action[j + 1].Date.Minute - Time woke up.
                    // Eg. 6/23/1518 12:33:00 AM - 6/23/1518 12:27:00 AM
                    // Loop = 27 < 33
                    for(int MinuteCount = Guards[i].Action[j].Date.Minute; MinuteCount < Guards[i].Action[j + 1].Date.Minute; MinuteCount++)
                    {
                        MinuteCounter[MinuteCount]++;
                    }
                }
                
                // Gets the total for Minutes slept.
                foreach(var y in MinuteCounter)
                {
                    //Console.WriteLine($"Guard ID: {Guards[i].GuardID} Minute: {y.Key} Total: {y.Value}");
                    Guards[i].TotalMinutesSlept += y.Value;
                }

                // Sets the Largest Minute Value to the MinuteCounter's Minute
                Guards[i].Minute = MinuteCounter.FirstOrDefault(x => x.Value == MinuteCounter.Values.Max()).Key;
                
                // Reset all values in MinuteCounter to 0
                for(int minute = 0; minute < 60; minute++)
                {
                    MinuteCounter[minute] = 0;
                }
            }
            Console.WriteLine(Guards.Aggregate((x1, x2) => x1.Minute > x2.Minute ? x1 : x2).GuardID);
            // Get the ID and Minute and return them multiplied by each other
            int ID = int.Parse(Guards.Aggregate((x1, x2) => x1.TotalMinutesSlept > x2.TotalMinutesSlept ? x1 : x2).GuardID);
            int MaxMinutes = Guards.Aggregate((x1, x2) => x1.TotalMinutesSlept > x2.TotalMinutesSlept ? x1 : x2).Minute;
            return ID * MaxMinutes;
        }

        // 38 * 1733
        // Of all guards, which guard is most frequently asleep on the same minute?
        // What is the ID of the guard you chose multiplied by the minute you chose?
        public static int Part2(IEnumerable<string> FileInput)
        {
            return -1;
        }
    }
}