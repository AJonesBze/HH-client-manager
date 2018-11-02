using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace HH_client_manager.Models
{
    public class FuzzyMatch
    {
        public static List<string> FuzzyMatchParameters(string input, object analogue, int confidence = 2)
        {
            List<string> output = new List<string>();

            foreach(PropertyInfo property in analogue.GetType().GetProperties())
            {
                if(FuzzyMatchString(input,GetDisplayName(input[0].GetType(), property, true), confidence))
                {
                    output.Add(GetDisplayName(input[0].GetType(), property, true));
                }
            }

            if ( output != new List<string>() ) { return output; }
            return null;
        }


        public static bool FuzzyMatchString(string input, string analogue, int confidence = 2)
        {
            if( CalcLevenshteinDistance(input, analogue) <= confidence ) { return true; }
            return false;
        }
         


        //via https://stackoverflow.com/questions/9453731/how-to-calculate-distance-similarity-measure-of-given-2-strings
        public static int CalcLevenshteinDistance(string a, string b)
        {
            if (String.IsNullOrEmpty(a) && String.IsNullOrEmpty(b))
            {
                return 0;
            }
            if (String.IsNullOrEmpty(a))
            {
                return b.Length;
            }
            if (String.IsNullOrEmpty(b))
            {
                return a.Length;
            }
            int lengthA = a.Length;
            int lengthB = b.Length;
            var distances = new int[lengthA + 1, lengthB + 1];
            for (int i = 0; i <= lengthA; distances[i, 0] = i++) ;
            for (int j = 0; j <= lengthB; distances[0, j] = j++) ;

            for (int i = 1; i <= lengthA; i++)
                for (int j = 1; j <= lengthB; j++)
                {
                    int cost = b[j - 1] == a[i - 1] ? 0 : 1;
                    distances[i, j] = Math.Min
                        (
                        Math.Min(distances[i - 1, j] + 1, distances[i, j - 1] + 1),
                        distances[i - 1, j - 1] + cost
                        );
                }
            return distances[lengthA, lengthB];
        }

        // this fxn from https://forums.asp.net/t/1698787.aspx?How+do+I+access+the+DisplayName+attribute+of+a+property+in+code+
        public static String GetDisplayName(Type type, PropertyInfo info, bool hasMetaDataAttribute)
        {
            if (!hasMetaDataAttribute)
            {
                object[] attributes = info.GetCustomAttributes(typeof(DisplayNameAttribute), false);
                if (attributes != null && attributes.Length > 0)
                {
                    var displayName = (DisplayNameAttribute)attributes[0];
                    return displayName.DisplayName;
                }
                return info.Name;
            }
            PropertyDescriptor propDesc = TypeDescriptor.GetProperties(type).Find(info.Name, true);
            DisplayNameAttribute displayAttribute =
                propDesc.Attributes.OfType<DisplayNameAttribute>().FirstOrDefault();
            return displayAttribute != null ? displayAttribute.DisplayName : "";
        }
    }
}
