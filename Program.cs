﻿using System;
using System.Linq;
using System.Numerics;

namespace KeyGenSpeed
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(BitConverter.ToString(((BigInteger)((2*2*3*7)^89)*(((31*281)^(2*2*2*2*3*3*71))/3)*((2*3*3*587)^(3*3061))*((2*331*(((BigInteger)2*3*13*13*7699*81373)^((BigInteger)38299*((2*2*3*3*3*3*337*683)^(3*13*((3*((5*7*124529)^(2*2*2*17*113*433)))^(2*383*7237)))))))^(3*((2*2)+1)*((2*2*3*7)^89)*((50*2)+3)*(((BigInteger)23*((2*3*7*113*409*503)^(3*7*19*((2*3*3*3*3*5*9781)^(23*137*2083)))))^(2*3*13099*16843))))*((5*7*(112^1023)*(((BigInteger)2*2*2*2*2*3*3*19*113*(((BigInteger)3*13*23*29*391631)^((BigInteger)2*2*2*3*3*((3*5*31*241*5557)^(2*2*3*((5*17*204251)^(2*2*2*7*17*23*2939)))))))^(((7*71*2003)^(2*2*2*2*2*2*3*643))*(((BigInteger)3*1499*((2*3*1319*1499)^(11*557*1609)))^((BigInteger)2*47*199*((5*37*2551)^(2*2*2*71*1741)))))))^(2*2*2*3*3*((3*5*13*2999)^(2*2*((2*2*2*3*13*37*47)^(227*2879))))*(((BigInteger)3*19*13757*152311)^((BigInteger)2*3*7*9157*107507))))).ToByteArray().Take(0x10).Reverse().ToArray()).Replace("-","").ToUpper());
        }
    }
}
