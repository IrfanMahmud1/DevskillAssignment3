﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Player
    {
        public string Name { get; set; }
        public Dictionary<string, (int,int,int)> Position { get; set; }

        public Player(string name, string key, List<(int,int,int)> pos)
        {
            Name = name;
            Position = new Dictionary<string, (int, int, int)>();
            for (int i = 1; i <= pos.Count; i++)
            {
                Position[key + i] = pos[i - 1];
            }
        }
    }
}