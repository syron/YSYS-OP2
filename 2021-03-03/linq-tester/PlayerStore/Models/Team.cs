using System;
using System.Collections.Generic;

namespace PlayerStore.Models
{
    public class Team
    {
        public Team()
        {
        }

        public string Name { get; set; }
        public List<Player> Players { get; set; }
    }
}
