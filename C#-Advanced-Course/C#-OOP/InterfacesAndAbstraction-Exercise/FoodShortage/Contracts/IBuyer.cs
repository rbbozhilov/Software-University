using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Contracts
{
    public interface IBuyer
    {

        public string Name { get; }
        public int Food { get; }

        void BuyFood();

    }
}
