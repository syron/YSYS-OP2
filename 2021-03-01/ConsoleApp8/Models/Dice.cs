using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Models
{
    class Dice
    {
        public int Result { get; set; }

        public Dice()
        {

        }

        public void Throw()
        {
            if (Result == 0)
                SetResult();
        }

        private void SetResult()
        {
            Random random = new Random();
            Result = random.Next(1, 6 + 1);
        }
    }
}
