using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.bitArrayClass
{
    class Program
    {
        static void Main()
        {
            BitArray64 someNumber = new BitArray64(15);
            BitArray64 otherNumber = new BitArray64(150);
            //chech IEnumerable
            StringBuilder str = new StringBuilder();
            foreach (var bit in someNumber)
            {
                
                str.Append(bit);
            }
            string bitReperentation = str.ToString();

            char[] arrayBits = bitReperentation.ToCharArray();
            Array.Reverse(arrayBits);
            string finalBitRep = new string(arrayBits);
            finalBitRep = finalBitRep.TrimStart('0');
            Console.WriteLine(finalBitRep);
            //check equals and hashcode
            Console.WriteLine(someNumber.Equals(otherNumber));
            Console.WriteLine(someNumber.GetHashCode());
            Console.WriteLine(otherNumber.GetHashCode());

            //chech == and !=
            Console.WriteLine(someNumber==otherNumber);
            Console.WriteLine(someNumber!=otherNumber);
        }
    }
}
