﻿using System;

namespace Composite
{
    public class Player : IParticipant
    {
        public string Name { get; set; }
        public double Gold { get; set; }

        public void Stats()
        {
            Console.WriteLine("{0} has {1} coins.", Name, Gold);
        }
    }
}
