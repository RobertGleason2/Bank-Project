using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment0
{
    public class MintBase 
    {
        public static Money Mint(COIN coin)
        {
            Money newCoin = null;
            switch(coin){
                case (COIN.PENNY):
                    newCoin = new Penny();
                    break;
                case (COIN.NICKLE):
                    newCoin = new Nickle();
                    break;
                case (COIN.DIME):
                    newCoin = new Dime();
                    break;
                case (COIN.QUARTER):
                    newCoin = new Quarter();
                    break;
                case (COIN.HALFDOLLAR):
                    newCoin = new HalfDollar();
                    break;
                case (COIN.DOLLAR):
                    newCoin = new Dollar();
                    break;
            }
            return newCoin;
        }
    }
}
