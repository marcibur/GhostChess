﻿namespace GhostChess.Models
{
    public class Move
    {
        public Move(string from, string to)
        {
            From = from;
            To = to;
        }

        public string From { get; set; }
        public string To { get; set; }
    }
}
