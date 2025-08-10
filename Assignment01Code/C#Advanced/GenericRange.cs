using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Code.C_Advanced
{
    #region Q.2
    //public class Range<T> where T : IComparable<T>
    //{ 
    //    public T Min { get; set; }
    //    public T Max { get; set; }
    //   public Range(T min ,T max) 
    //    {
    //        if (min.CompareTo(max) > 0)
    //            throw new ArgumentException("Min value Must Be Less Than or Equal Max");
    //      Min=min;
    //      Max=max; 
        
    //    }

    //    public bool IsInRange(T value)
    //    { 
    //      return value.CompareTo(Min) > 0 && value.CompareTo(Max) <=0;
    //    }
    //    public double Lenght()
    //    {
    //        try
    //        {

    //            double minVal = Convert.ToDouble(Min);
    //            double maxVal = Convert.ToDouble(Max);
    //            return maxVal - minVal;
    //        }
    //        catch
    //        {
    //            throw new InvalidOperationException("Length() only Works For Numeric types");
    //        }
        
        
    //    }
    
    
    
    //}
    #endregion
}
