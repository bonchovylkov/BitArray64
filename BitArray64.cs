using System;
using System.Collections;
using System.Collections.Generic;

public class BitArray64 : IEnumerable<int> 
    {
       public ulong Number { get; set; }
       public BitArray64(ulong number)
       {
           this.Number = number;
       }
       public IEnumerator<int> GetEnumerator()
       {

           for (int i = 0; i < 64; i++)
           {
               ulong checkBitOnPosition = Number & ((ulong)1 << i);
               if (checkBitOnPosition>0)
               {
                   yield return 1;
               }
               else
               {
                   yield return 0;
               }
           }
       }
       IEnumerator IEnumerable.GetEnumerator()
       {
           return this.GetEnumerator();
       }
       public override bool Equals(object number)
       {
           BitArray64 justNumber = number as BitArray64;
           if (justNumber==null)
           {
               return false;
           }
           if (this.Number!=justNumber.Number)
           {
               return false;
           }
           return true;
       }
       public override int GetHashCode()
       {
           return ((int)Number^(int)(Number*Number*Number));
       }
       public static bool operator ==(BitArray64 numberOne, BitArray64 numberTwo)
       {
           return BitArray64.Equals(numberOne, numberTwo);
       }
       public static bool operator !=(BitArray64 numberOne, BitArray64 numberTwo)
       {
           return !(BitArray64.Equals(numberOne, numberTwo));
       }

    }



