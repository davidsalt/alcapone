using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(Namespace = "http://KnockKnock.readify.net", IncludeExceptionDetailInFaults = true)]
    public class RedPill : IRedPill
    {
        Dictionary<string, long> d = new Dictionary<string, long>();

        public RedPill()
        {
            
            d.Add("-92", -7540113804746350000);
            d.Add("-91", -4660046610375530000);
            d.Add("-90", -2880067194370820000);
            d.Add("-89", -1779979416004710000);
            d.Add("-88", -1100087778366100000);
            d.Add("-87", -679891637638612000);
            d.Add("-86", -420196140727490000);
            d.Add("-85", -259695496911123000);
            d.Add("-84", -160500643816367000);
            d.Add("-83", -99194853094755500);
            d.Add("-82", -61305790721611600);
            d.Add("-81", -37889062373143900);
            d.Add("-80", -23416728348467700);
            d.Add("-79", -14472334024676200);
            d.Add("-78", -8944394323791460);
            d.Add("-77", -5527939700884760);
            d.Add("-76", -3416454622906710);
            d.Add("-75", -2111485077978050);
            d.Add("-74", -1304969544928660);
            d.Add("-73", -806515533049393);
            d.Add("-72", -498454011879264);
            d.Add("-71", -308061521170129);
            d.Add("-70", -190392490709135);
            d.Add("-69", -117669030460994);
            d.Add("-68", -72723460248141);
            d.Add("-67", -44945570212853);
            d.Add("-66", -27777890035288);
            d.Add("-65", -17167680177565);
            d.Add("-64", -10610209857723);
            d.Add("-63", -6557470319842);
            d.Add("-62", -4052739537881);
            d.Add("-61", -2504730781961);
            d.Add("-60", -1548008755920);
            d.Add("-59", -956722026041);
            d.Add("-58", -591286729879);
            d.Add("-57", -365435296162);
            d.Add("-56", -225851433717);
            d.Add("-55", -139583862445);
            d.Add("-54", -86267571272);
            d.Add("-53", -53316291173);
            d.Add("-52", -32951280099);
            d.Add("-51", -20365011074);
            d.Add("-50", -12586269025);
            d.Add("-49", -7778742049);
            d.Add("-48", -4807526976);
            d.Add("-47", -2971215073);
            d.Add("-46", -1836311903);
            d.Add("-45", -1134903170);
            d.Add("-44", -701408733);
            d.Add("-43", -433494437);
            d.Add("-42", -267914296);
            d.Add("-41", -165580141);
            d.Add("-40", -102334155);
            d.Add("-39", -63245986);
            d.Add("-38", -39088169);
            d.Add("-37", -24157817);
            d.Add("-36", -14930352);
            d.Add("-35", -9227465);
            d.Add("-34", -5702887);
            d.Add("-33", -3524578);
            d.Add("-32", -2178309);
            d.Add("-31", -1346269);
            d.Add("-30", -832040);
            d.Add("-29", -514229);
            d.Add("-28", -317811);
            d.Add("-27", -196418);
            d.Add("-26", -121393);
            d.Add("-25", -75025);
            d.Add("-24", -46368);
            d.Add("-23", -28657);
            d.Add("-22", -17711);
            d.Add("-21", -10946);
            d.Add("-20", -6765);
            d.Add("-19", -4181);
            d.Add("-18", -2584);
            d.Add("-17", -1597);
            d.Add("-16", -987);
            d.Add("-15", -610);
            d.Add("-14", -377);
            d.Add("-13", -233);
            d.Add("-12", -144);
            d.Add("-11", -89);
            d.Add("-10", -55);
            d.Add("-9", -34);
            d.Add("-8", -21);
            d.Add("-7", -13);
            d.Add("-6", -8);
            d.Add("-5", -5);
            d.Add("-4", -3);
            d.Add("-3", -2);
            d.Add("-2", -1);
            d.Add("-1", -1);
            d.Add("0", 0);
            d.Add("1", 1);
            d.Add("2", 1);
            d.Add("3", 2);
            d.Add("4", 3);
            d.Add("5", 5);
            d.Add("6", 8);
            d.Add("7", 13);
            d.Add("8", 21);
            d.Add("9", 34);
            d.Add("10", 55);
            d.Add("11", 89);
            d.Add("12", 144);
            d.Add("13", 233);
            d.Add("14", 377);
            d.Add("15", 610);
            d.Add("16", 987);
            d.Add("17", 1597);
            d.Add("18", 2584);
            d.Add("19", 4181);
            d.Add("20", 6765);
            d.Add("21", 10946);
            d.Add("22", 17711);
            d.Add("23", 28657);
            d.Add("24", 46368);
            d.Add("25", 75025);
            d.Add("26", 121393);
            d.Add("27", 196418);
            d.Add("28", 317811);
            d.Add("29", 514229);
            d.Add("30", 832040);
            d.Add("31", 1346269);
            d.Add("32", 2178309);
            d.Add("33", 3524578);
            d.Add("34", 5702887);
            d.Add("35", 9227465);
            d.Add("36", 14930352);
            d.Add("37", 24157817);
            d.Add("38", 39088169);
            d.Add("39", 63245986);
            d.Add("40", 102334155);
            d.Add("41", 165580141);
            d.Add("42", 267914296);
            d.Add("43", 433494437);
            d.Add("44", 701408733);
            d.Add("45", 1134903170);
            d.Add("46", 1836311903);
            d.Add("47", 2971215073);
            d.Add("48", 4807526976);
            d.Add("49", 7778742049);
            d.Add("50", 12586269025);
            d.Add("51", 20365011074);
            d.Add("52", 32951280099);
            d.Add("53", 53316291173);
            d.Add("54", 86267571272);
            d.Add("55", 139583862445);
            d.Add("56", 225851433717);
            d.Add("57", 365435296162);
            d.Add("58", 591286729879);
            d.Add("59", 956722026041);
            d.Add("60", 1548008755920);
            d.Add("61", 2504730781961);
            d.Add("62", 4052739537881);
            d.Add("63", 6557470319842);
            d.Add("64", 10610209857723);
            d.Add("65", 17167680177565);
            d.Add("66", 27777890035288);
            d.Add("67", 44945570212853);
            d.Add("68", 72723460248141);
            d.Add("69", 117669030460994);
            d.Add("70", 190392490709135);
            d.Add("71", 308061521170129);
            d.Add("72", 498454011879264);
            d.Add("73", 806515533049393);
            d.Add("74", 1304969544928660);
            d.Add("75", 2111485077978050);
            d.Add("76", 3416454622906710);
            d.Add("77", 5527939700884760);
            d.Add("78", 8944394323791460);
            d.Add("79", 14472334024676200);
            d.Add("80", 23416728348467700);
            d.Add("81", 37889062373143900);
            d.Add("82", 61305790721611600);
            d.Add("83", 99194853094755500);
            d.Add("84", 160500643816367000);
            d.Add("85", 259695496911123000);
            d.Add("86", 420196140727490000);
            d.Add("87", 679891637638612000);
            d.Add("88", 1100087778366100000);
            d.Add("89", 1779979416004710000);
            d.Add("90", 2880067194370820000);
            d.Add("91", 4660046610375530000);
            d.Add("92", 7540113804746350000);
          
        }


        public string ReverseWords(string s)
        {
            string[] a = s.Split();
           
            string c = "";

            List<string> l = a.ToList();

            List<string> nl = new List<string>();

            for (int i = 0; i< l.Count; i++)
            {
                char[] ca = l[i].ToCharArray();
                Array.Reverse(ca);
                nl.Add(new string(ca));
            }

            for (int i = 0; i < nl.Count; i++)
            {
                c = c + nl[i];
                c = c + " ";
            }

            return c.Trim();
        }

        public Guid WhatIsYourToken()
        {
            return new Guid("d8c8cf54-2c59-4ea9-9476-0897630bc7c1");
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if(a > 0 && b > 0 && c > 0)
            {
                if (a != c && b != a && c != b)
                    return TriangleType.Scalene;
                if (a == c && b == a && c == b)
                    return TriangleType.Equilateral;
                if(a==c || a==b || c==b )
                    return TriangleType.Isosceles;
            }

            return TriangleType.Error;
        }

        public long FibonacciNumber(long n)
        {
            return d[n.ToString()];
        }
    }
}
