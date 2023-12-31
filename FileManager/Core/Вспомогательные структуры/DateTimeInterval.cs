﻿using System;

namespace Core
{
    public struct DateTimeInterval
    {
        public DateTimeInterval(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }
        public DateTime Start {  get; set; }
        public DateTime End { get; set; }
    }
}
