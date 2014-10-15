using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities.DTOs
{
    // A delegate is a reference to a method
    public delegate Grade GradeCovertor(int percent);

    public enum Grade
    {
        A,B,C,D,E,F
    }
    public enum Country
    {
        Canada, SouthKorea
    }
    public class KoreanSchool
    {
        public Grade ConvertToGrade(int percent)
        {
            Grade result;
            if (percent >= 95)
                result = Grade.A;
            else if (percent >= 85)
                result = Grade.B;
            else
                result = Grade.F;
            return result;
        }
    }
    public class CanadianSchool
    {
        public Grade ConvertToGrade(int percent)
        {
            Grade result;
            if (percent >= 70)
                result = Grade.A;
            else if (percent >= 65)
                result = Grade.B;
            else if (percent >= 50)
                result = Grade.C;
            else
                result = Grade.F;
            return result;
        }
    
    public class AdHoc : IAdHoc // This class implements IAdHoc interface
    {
        // A class has field, properties, construcotrs, and methods
        public bool IsHonors(GradeCovertor callback)
        {
            Grade result = callback(75);
            return IsHonors(result);
        }

        public Grade ConvertToGrade(int percent)
        {
            Grade result;
            if (percent > 80)
                result = Grade.A;
            else if (percent >= 70)
                result = Grade.B;
            else if (percent >= 60)
                result = Grade.C;
            else if (percent >= 50)
                result = Grade.D;
            else
                result = Grade.F;

            return result;
        }
        public bool IsHonors(Grade value)
        {
            if (value == Grade.A)
                return true;
            else
                return false;
        }
        public string AsText(int value)
        {
            return value.ToString();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    }
    public interface IAdHoc
    {
        // An interface has properties and methods
        // Preperties and methods do NOT have an implementation in an interface
        string AsText(int value);
        int Count { get; } // Properties can have A get, set, or both
    }
}
