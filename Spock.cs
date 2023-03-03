﻿//Written by
//     Mikiyas Yoseph
//     Niftalem Kassa
//     Tinsay Gebremariam
//on 3/2/23
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSSL
{
    public class Spock : Move
    {
        //compare method that takes in computer move and returns player result after checking condition
        public override string Compare(string compPlay)
        {
            if (compPlay == "Rock" || compPlay == "Scissor")
                return "Win";
            return "Lost";
        }
    }
}