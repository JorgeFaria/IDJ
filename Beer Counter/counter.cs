using System;
using System.Collections.Generic;
using System.Text;

namespace Beer_Counter
{
    public static class counter
    {

        public static int beerDrankCount;
        public static int beerInStock;
        public static int BuyBeer(int BottleCount)
        {
            beerInStock += BottleCount;
            return(beerInStock) ;
        }

        public static int DrinkBeer(int bottlesCount)
        {
            beerDrankCount += bottlesCount;
            beerInStock -= bottlesCount;
            return (beerDrankCount);
        }
    }
}
