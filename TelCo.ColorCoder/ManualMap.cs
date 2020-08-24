using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
  class ManualMap{
    
    public static void GetAllMapping(){
      for(int pairNumber = 1; pairNumber < = 25; pairNumber++){

          ColorPair testPair1 = ColorToNumber.GetColorFromPairNumber(pairNumber);
          Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);

      } 
    }
      
  }
}
