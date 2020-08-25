using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
  /// <summary>
  /// data type defined to hold the number and its equivalent color  
  /// </summary>
  class ColorCodes{
    
    public int _PairNumber;
    public ColorPair _ColorPair;
    
    /// <summary>
    /// default constructor required for parametrized constructor  
    /// </summary>
    public ColorCodes(){}
    
    /// <summary>
    /// parametrized constructor to initialize class varibles using parameters 
    /// </summary>
    public ColorCodes(int number,ColorPair colorPair){
      _PairNumber = number;
      _ColorPair = colorPair;
    }
    
    /// <summary>
    /// Overridden method to return string of number and color 
    /// </summary>
    public override string ToString(){
      return string.Format("Pair Number: {0},Colors: {1}\n", PairNumber, colorPair); 
    }
      
  }
}
