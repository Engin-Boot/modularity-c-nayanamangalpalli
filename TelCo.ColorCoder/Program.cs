using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{   /// <summary>
    /// The 25-pair color code, originally known as even-count color code, 
    /// is a color code used to identify individual conductors in twisted-pair wiring for telecommunications.
    /// This class provides the color coding and mapping of pair number to color and color to pair number.
    /// </summary>
    class Program
    {   /// <summary>
        /// Test code for the class
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            int pairNumber = 4;
            ColorPair testPair1 = NumberCodeConversion.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.Brown);

            pairNumber = 5;
            testPair1 = NumberCodeConversion.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.SlateGray);

            pairNumber = 23;
            testPair1 = NumberCodeConversion.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.Violet);
            Debug.Assert(testPair1.minorColor == Color.Green);

            ColorPair testPair2 = new ColorPair() { majorColor = Color.Yellow, minorColor = Color.Green };
            pairNumber =ColorCodeConversion.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 18);

            testPair2 = new ColorPair() { majorColor = Color.Red, minorColor = Color.Blue };
            pairNumber = ColorCodeConversion.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
            Debug.Assert(pairNumber == 6);
            
            for(int pairNumberIndex =1 ; pairNumberIndex <= 25; pairNumberIndex++){
                testPair1 = NumberCodeConversion.GetColorFromPairNumber(pairNumberIndex);
                ColorCodes _colorCodes = new ColorCodes(pairNumberIndex,testPair1);
                Console.WriteLine(_colorCodes.ToString());
                Debug.Assert(_colorCodes._PairNumber == pairNumberIndex);
                Debug.Assert(_colorCodes._ColorPair.majorColor == testPair1.majorColor);
                Debug.Assert(_colorCodes._ColorPair.minorColor == testPair1.minorColor);
            }
        }
    }
}
